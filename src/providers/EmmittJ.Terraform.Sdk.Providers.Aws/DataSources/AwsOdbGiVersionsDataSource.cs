using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_gi_versions.
/// </summary>
public class AwsOdbGiVersionsDataSource : TerraformDataSource
{
    public AwsOdbGiVersionsDataSource(string name) : base("aws_odb_gi_versions", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The system shape.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Shape { get; set; }

    /// <summary>
    /// Information about a specific version of Oracle Grid Infrastructure (GI) software that can be installed on a VM cluster.
    /// </summary>
    [TerraformPropertyName("gi_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GiVersions => new TerraformReference(this, "gi_versions");

}
