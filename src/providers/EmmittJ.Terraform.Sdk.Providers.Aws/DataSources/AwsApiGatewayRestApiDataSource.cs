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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The api_key_source attribute.
    /// </summary>
    [TerraformPropertyName("api_key_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiKeySource => new TerraformReference(this, "api_key_source");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The binary_media_types attribute.
    /// </summary>
    [TerraformPropertyName("binary_media_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> BinaryMediaTypes => new TerraformReference(this, "binary_media_types");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EndpointConfiguration => new TerraformReference(this, "endpoint_configuration");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutionArn => new TerraformReference(this, "execution_arn");

    /// <summary>
    /// The minimum_compression_size attribute.
    /// </summary>
    [TerraformPropertyName("minimum_compression_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MinimumCompressionSize => new TerraformReference(this, "minimum_compression_size");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Policy => new TerraformReference(this, "policy");

    /// <summary>
    /// The root_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("root_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootResourceId => new TerraformReference(this, "root_resource_id");

}
