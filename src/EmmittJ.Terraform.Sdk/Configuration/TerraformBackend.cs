namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform backend configuration for remote state storage.
/// Backends determine where Terraform stores its state data.
/// </summary>
public partial class TerraformBackend : TerraformBlock
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformBackend"/> class.
    /// </summary>
    /// <param name="type">The backend type (e.g., "s3", "azurerm", "remote", "local", "gcs").</param>
    public TerraformBackend(string type) : base("backend")
    {
        Type = type ?? throw new ArgumentNullException(nameof(type));
    }

    /// <summary>
    /// Gets the backend type (e.g., "s3", "azurerm", "remote", "local", "gcs").
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// Cannot generate reference to backend blocks.
    /// </summary>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Backend blocks cannot be referenced.");
}

