using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace NWS.WeatherDataService
{

    /// <summary>
    /// Factory interface for creating results to be cached
    /// </summary>
    public interface IResultFactory<TKey, TResult>
    {
        Task<TResult> GetResult(TKey key);
    }

    /// <summary>
    /// A key representing a geographic location
    /// </summary>
    public class LocationKey : IEquatable<LocationKey>
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public bool Equals(LocationKey other)
        {
            if (other == null) return false;
            return this.Latitude == other.Latitude && this.Longitude == other.Longitude;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Latitude, Longitude);
        }
    }


    /// <summary>
    /// A cache for URLs since NWS forecast and current conditions urls are not based off of longitude/latitude,
    /// but rather on internal NWS gridpoint identifiers. This class caches off the URLs for those gridpoints.
    /// </summary>
    public class ResultCache<TKey, TResult> where TKey : IEquatable<TKey> where TResult : class
    {
        /// <summary>
        /// The cache dictionary
        /// </summary>
        private static readonly ConcurrentDictionary<TKey, TResult> cache = new ConcurrentDictionary<TKey, TResult>();

        /// <summary>
        /// Locks for each key to ensure thread-safe access
        /// </summary>
        private static readonly ConcurrentDictionary<TKey, SemaphoreSlim> keyLocks =
            new ConcurrentDictionary<TKey, SemaphoreSlim>();

        /// <summary>
        /// Factory interface for creating results to be cached
        /// </summary>
        private readonly IResultFactory<TKey, TResult> resultFactory;

        /// <summary>
        /// Constructor that accepts a result factory
        /// </summary>
        /// <param name="resultFactory">Factory for creating results</param>
        public ResultCache(IResultFactory<TKey, TResult> resultFactory)
        {
            this.resultFactory = resultFactory;
        }


        /// <summary>
        /// Gets a result from the cache, or creates it using the factory if not present
        /// </summary>
        /// <param name="key">The key for the cached result</param>
        /// <returns>The cached result OR a newly created result</returns>
        public async Task<TResult> Get(TKey key)
        {
            // This is threadsafe due to ConcurrentDictionary
            if (cache.TryGetValue(key, out var cachedResult))
            {
                return cachedResult;
            }

            // Ok any of this stuff is not thread safe, we need to lock per key
            var semaphore = keyLocks.GetOrAdd(key, _ => new SemaphoreSlim(1, 1));

            await semaphore.WaitAsync();
            try
            {
                // Double-check after acquiring lock in case another thread added it while we were waiting
                if (cache.TryGetValue(key, out cachedResult))
                {
                    return cachedResult;
                }

                // Create the result since it is still not present
                var result = await resultFactory.GetResult(key);
                cache.TryAdd(key, result);
                return result;
            }
            finally
            {
                // Release the lock
                semaphore.Release();
            }
        }
    }
}
