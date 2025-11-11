using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_associations.
/// </summary>
public class AwsVpcEndpointAssociationsDataSource : TerraformDataSource
{
    public AwsVpcEndpointAssociationsDataSource(string name) : base("aws_vpc_endpoint_associations", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    [TerraformPropertyName("vpc_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcEndpointId { get; set; }

    /// <summary>
    /// The associations attribute.
    /// </summary>
    [TerraformPropertyName("associations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Associations => new TerraformReference(this, "associations");

}
