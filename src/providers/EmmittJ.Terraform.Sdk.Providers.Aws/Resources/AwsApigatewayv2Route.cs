using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for request_parameter in .
/// Nesting mode: set
/// </summary>
public partial class AwsApigatewayv2RouteRequestParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The request_parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestParameterKey is required")]
    [TerraformProperty("request_parameter_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RequestParameterKey { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    [TerraformProperty("required")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Required { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_route resource.
/// </summary>
public partial class AwsApigatewayv2Route : TerraformResource
{
    public AwsApigatewayv2Route(string name) : base("aws_apigatewayv2_route", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    [TerraformProperty("api_key_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApiKeyRequired { get; set; }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    [TerraformProperty("authorization_scopes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AuthorizationScopes { get; set; }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [TerraformProperty("authorization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationType { get; set; }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [TerraformProperty("authorizer_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizerId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    [TerraformProperty("model_selection_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ModelSelectionExpression { get; set; }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformProperty("operation_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    [TerraformProperty("request_models")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequestModels { get; set; }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    [TerraformProperty("route_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RouteKey { get; set; }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    [TerraformProperty("route_response_selection_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RouteResponseSelectionExpression { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Target { get; set; }

    /// <summary>
    /// Block for request_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("request_parameter")]
    public partial TerraformSet<TerraformBlock<AwsApigatewayv2RouteRequestParameterBlock>>? RequestParameter { get; set; }

}
