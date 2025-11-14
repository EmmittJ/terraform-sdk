namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Abstraction for Terraform CLI operations to enable testing.
/// </summary>
public interface ITerraformCli
{
    /// <summary>
    /// Runs 'terraform init' in the specified working directory.
    /// </summary>
    Task InitializeAsync(string workingDirectory, CancellationToken cancellationToken = default);

    /// <summary>
    /// Runs 'terraform providers schema -json' and returns the schema JSON.
    /// </summary>
    Task<string> GetSchemaJsonAsync(string workingDirectory, CancellationToken cancellationToken = default);
}
