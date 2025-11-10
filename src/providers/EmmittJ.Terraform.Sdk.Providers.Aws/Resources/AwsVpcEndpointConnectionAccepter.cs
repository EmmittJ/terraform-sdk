using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_connection_accepter resource.
/// </summary>
public class AwsVpcEndpointConnectionAccepter : TerraformResource
{
    public AwsVpcEndpointConnectionAccepter(string name) : base("aws_vpc_endpoint_connection_accepter", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointId is required")]
    [TerraformPropertyName("vpc_endpoint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_endpoint_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcEndpointServiceId is required")]
    [TerraformPropertyName("vpc_endpoint_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcEndpointServiceId { get; set; }

    /// <summary>
    /// The vpc_endpoint_state attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_endpoint_state");

}
