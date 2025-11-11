using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method resource.
/// </summary>
public class AwsApiGatewayMethod : TerraformResource
{
    public AwsApiGatewayMethod(string name) : base("aws_api_gateway_method", name)
    {
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    [TerraformPropertyName("api_key_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApiKeyRequired { get; set; }

    /// <summary>
    /// The authorization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authorization is required")]
    [TerraformPropertyName("authorization")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Authorization { get; set; }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    [TerraformPropertyName("authorization_scopes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AuthorizationScopes { get; set; }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizerId { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformPropertyName("http_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformPropertyName("operation_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OperationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    [TerraformPropertyName("request_models")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? RequestModels { get; set; }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformPropertyName("request_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<bool>? RequestParameters { get; set; }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    [TerraformPropertyName("request_validator_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RequestValidatorId { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestApiId { get; set; }

}
