namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform import block for declarative resource import (Terraform 1.5+).
/// Import blocks allow you to declare which existing infrastructure objects should be
/// imported into Terraform's state without requiring separate terraform import commands.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/import"/></para>
/// <para>
/// The import block has the following arguments:
/// - to (required): The resource address where the imported object should be imported to
/// - id (optional): The provider-specific ID of the object being imported (mutually exclusive with identity)
/// - identity (optional): A map of attributes that uniquely identifies a resource (mutually exclusive with id)
/// - for_each (meta-argument): Import multiple similar resources
/// - provider (meta-argument): Specify which provider configuration to use
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Import using ID
/// var import = new TerraformImportBlock
/// {
///     To = "aws_s3_bucket.this",
///     Id = "example-bucket"
/// };
///
/// // Import using identity attributes
/// var import = new TerraformImportBlock
/// {
///     To = "aws_instance.example",
///     Identity = new Dictionary&lt;string, object&gt;
///     {
///         ["name"] = "my-instance",
///         ["region"] = "us-west-2"
///     }
/// };
/// </code>
/// </example>
public class TerraformImportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type keyword for import blocks.
    /// </summary>
    public override string BlockType => "import";

    /// <summary>
    /// Gets the block labels for this import block (none).
    /// </summary>
    public override string[] BlockLabels => [];

    /// <summary>
    /// The resource address where the imported object should be imported to.
    /// This must be a resource address that exists in your configuration.
    /// </summary>
    public required TerraformValue<string> To
    {
        get => GetRequiredArgument<TerraformValue<string>>("to");
        set => SetArgument("to", value);
    }

    /// <summary>
    /// The provider-specific ID of the object being imported.
    /// The format of this ID depends on the resource type and provider.
    /// Mutually exclusive with <see cref="Identity"/>.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A map of attributes that uniquely identifies a resource.
    /// The keys are specific to the resource type and provider.
    /// Mutually exclusive with <see cref="Id"/>.
    /// </summary>
    public TerraformValue<IDictionary<string, object>>? Identity
    {
        get => GetArgument<TerraformValue<IDictionary<string, object>>>("identity");
        set => SetArgument("identity", value);
    }
}
