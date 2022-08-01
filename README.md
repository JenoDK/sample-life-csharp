## Command used to generate the csharp code
```
docker run --rm -v "/Users/dekeyzer/git/sample-life-csharp:/local" openapitools/openapi-generator-cli generate \
                    -i /local/sample-life-v1.0.yaml \
                    -g csharp \
                    -o /local/out/csharp
```
where `/Users/dekeyzer/git/sample-life-csharp` is the location of the repository.