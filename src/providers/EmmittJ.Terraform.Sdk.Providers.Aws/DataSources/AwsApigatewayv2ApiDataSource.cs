using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_api.
/// </summary>
public class AwsApigatewayv2ApiDataSource : TerraformDataSource
{
    public AwsApigatewayv2ApiDataSource(string name) : base("aws_apigatewayv2_api", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_endpoint");

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("api_key_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKeySelectionExpression => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_key_selection_expression");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformPropertyName("cors_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CorsConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors_configuration");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("disable_execute_api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableExecuteApiEndpoint => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_execute_api_endpoint");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_arn");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformPropertyName("protocol_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtocolType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol_type");

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("route_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteSelectionExpression => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_selection_expression");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
