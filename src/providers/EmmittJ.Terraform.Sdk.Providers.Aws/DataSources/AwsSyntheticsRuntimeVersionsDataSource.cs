using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_synthetics_runtime_versions.
/// </summary>
public class AwsSyntheticsRuntimeVersionsDataSource : TerraformDataSource
{
    public AwsSyntheticsRuntimeVersionsDataSource(string name) : base("aws_synthetics_runtime_versions", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The runtime_versions attribute.
    /// </summary>
    [TerraformPropertyName("runtime_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RuntimeVersions => new TerraformReference(this, "runtime_versions");

}
