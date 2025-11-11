using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_networks.
/// </summary>
public class AwsOdbNetworksDataSource : TerraformDataSource
{
    public AwsOdbNetworksDataSource(string name) : base("aws_odb_networks", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// List of odb networks returns basic information about odb networks.
    /// </summary>
    [TerraformPropertyName("odb_networks")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OdbNetworks => new TerraformReference(this, "odb_networks");

}
