using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iot_endpoint.
/// </summary>
public class AwsIotEndpointDataSource : TerraformDataSource
{
    public AwsIotEndpointDataSource(string name) : base("aws_iot_endpoint", name)
    {
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointType { get; set; }

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
    /// The endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_address");

}
