using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_associations.
/// </summary>
public partial class AwsVpcEndpointAssociationsDataSource : TerraformDataSource
{
    public AwsVpcEndpointAssociationsDataSource(string name) : base("aws_vpc_endpoint_associations", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    [TerraformProperty("vpc_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcEndpointId { get; set; }

    /// <summary>
    /// The associations attribute.
    /// </summary>
    [TerraformProperty("associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Associations { get; }

}
