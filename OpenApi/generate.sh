#!/bin/bash

# Script to generate C# client from OpenAPI specification
# This uses the OpenAPI Generator Docker image to create a C# client library

set -e

# Configuration
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
OPENAPI_SPEC="$SCRIPT_DIR/openApi.json"
OUTPUT_DIR="$SCRIPT_DIR/../Generated"
PACKAGE_NAME="NationalWeatherService.Client"
PACKAGE_VERSION="2.6.0"

# Validate that the OpenAPI spec exists
if [ ! -f "$OPENAPI_SPEC" ]; then
    echo "Error: OpenAPI specification not found at $OPENAPI_SPEC"
    exit 1
fi

echo "Generating C# client from OpenAPI specification..."
echo "Input: $OPENAPI_SPEC"
echo "Output: $OUTPUT_DIR"

# Create output directory if it doesn't exist
mkdir -p "$OUTPUT_DIR"

# Generate C# client using OpenAPI Generator
# Mount the workspace root so we can write to the Generated directory
docker run --rm \
    -v "$(dirname "$SCRIPT_DIR"):/workspace" \
    openapitools/openapi-generator-cli generate \
    -i /workspace/OpenApi/openApi.json \
    -g csharp \
    -o /workspace/Generated \
    --additional-properties=packageName="$PACKAGE_NAME" \
    --additional-properties=packageVersion="$PACKAGE_VERSION" \
    --additional-properties=targetFramework=net8.0 \
    --additional-properties=netCoreProjectFile=true \
    --additional-properties=library=generichost

echo "C# client generation completed successfully!"
echo "Generated files are located in: $OUTPUT_DIR"
