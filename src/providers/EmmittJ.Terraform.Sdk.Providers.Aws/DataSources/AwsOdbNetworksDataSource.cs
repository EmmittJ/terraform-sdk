using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_networks.
/// </summary>
public partial class AwsOdbNetworksDataSource : TerraformDataSource
{
    public AwsOdbNetworksDataSource(string name) : base("aws_odb_networks", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// List of odb networks returns basic information about odb networks.
    /// </summary>
    [TerraformProperty("odb_networks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OdbNetworks { get; }

}
