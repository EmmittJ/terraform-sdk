using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_rest_api.
/// </summary>
public class AwsApiGatewayRestApiDataSource : TerraformDataSource
{
    public AwsApiGatewayRestApiDataSource(string name) : base("aws_api_gateway_rest_api", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    [TerraformPropertyName("api_key_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKeySource => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key_source");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    [TerraformPropertyName("binary_media_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> BinaryMediaTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "binary_media_types");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EndpointConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoint_configuration");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_arn");

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    [TerraformPropertyName("minimum_compression_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MinimumCompressionSize => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "minimum_compression_size");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Policy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("root_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RootResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "root_resource_id");

}
