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
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiEndpoint => new TerraformReference(this, "api_endpoint");

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("api_key_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApiKeySelectionExpression => new TerraformReference(this, "api_key_selection_expression");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformPropertyName("cors_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CorsConfiguration => new TerraformReference(this, "cors_configuration");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("disable_execute_api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableExecuteApiEndpoint => new TerraformReference(this, "disable_execute_api_endpoint");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutionArn => new TerraformReference(this, "execution_arn");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddressType => new TerraformReference(this, "ip_address_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [TerraformPropertyName("protocol_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProtocolType => new TerraformReference(this, "protocol_type");

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("route_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RouteSelectionExpression => new TerraformReference(this, "route_selection_expression");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
