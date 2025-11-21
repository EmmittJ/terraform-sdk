namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform backend configuration for remote state storage.
/// Backends determine where Terraform stores its state data.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/terraform#backend"/></para>
/// </remarks>
public partial class TerraformBackendBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend";

    /// <summary>
    /// Gets the block labels (backend type as a quoted label).
    /// </summary>
    public override string[] BlockLabels => [Type];

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformBackendBlock"/> class.
    /// </summary>
    /// <param name="type">The backend type (e.g., "s3", "azurerm", "remote", "local", "gcs").</param>
    public TerraformBackendBlock(string type)
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

