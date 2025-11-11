using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_accepter resource.
/// </summary>
public partial class AwsVpcEndpointConnectionAccepter : TerraformResource
{
    public AwsVpcEndpointConnectionAccepter(string name) : base("aws_vpc_endpoint_connection_accepter", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    [TerraformProperty("vpc_endpoint_service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpcEndpointServiceId { get; set; }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcEndpointState { get; }

}
