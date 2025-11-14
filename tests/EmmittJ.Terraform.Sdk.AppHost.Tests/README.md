# AppHost Template Generation Tests

This project contains snapshot tests for the Terraform code generation templates using Verify.

## Running Tests

```powershell
dotnet test
```

## Accepting/Updating Snapshots

When template output changes, the tests will fail and show the differences. To accept the new output as correct:

1. Review the `.received.txt` files in the test directory
2. If the output is correct, copy the `.received.txt` files to `.verified.txt`:

```powershell
# Accept all snapshots
Get-ChildItem -Recurse -Filter "*.received.txt" | ForEach-Object {
    $verified = $_.FullName.Replace(".received.txt", ".verified.txt")
    Copy-Item $_.FullName $verified -Force
}
```

Or accept individual snapshots by renaming specific files.

## Test Coverage

- `ResourceTemplate_GeneratesCorrectCode`: Basic resource with arguments
- `ResourceTemplate_WithNestedBlocks_GeneratesCorrectCode`: Resource with nested block types
- `DataSourceTemplate_GeneratesCorrectCode`: Data source generation
- `ProviderTemplate_GeneratesCorrectCode`: Provider configuration
- `EphemeralResourceTemplate_GeneratesCorrectCode`: Ephemeral resource generation

## Snapshot Files

Snapshot files are stored alongside the test file and are checked into source control. They serve as documentation of expected output.
