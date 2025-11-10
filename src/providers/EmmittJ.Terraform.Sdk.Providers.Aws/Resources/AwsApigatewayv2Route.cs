using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for request_parameter in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2RouteRequestParameterBlock : ITerraformBlock
{
    /// <summary>
    /// The request_parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestParameterKey is required")]
    [TerraformPropertyName("request_parameter_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RequestParameterKey { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    [TerraformPropertyName("required")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Required { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_route resource.
/// </summary>
public class AwsApigatewayv2Route : TerraformResource
{
    public AwsApigatewayv2Route(string name) : base("aws_apigatewayv2_route", name)
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
    /// The api_key_required attribute.
    /// </summary>
    [TerraformPropertyName("api_key_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApiKeyRequired { get; set; }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    [TerraformPropertyName("authorization_scopes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AuthorizationScopes { get; set; }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [TerraformPropertyName("authorization_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizationType { get; set; }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizerId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("model_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ModelSelectionExpression { get; set; }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    [TerraformPropertyName("operation_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OperationName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    [TerraformPropertyName("request_models")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? RequestModels { get; set; }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    [TerraformPropertyName("route_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RouteKey { get; set; }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("route_response_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RouteResponseSelectionExpression { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformPropertyName("target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Target { get; set; }

    /// <summary>
    /// Block for request_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("request_parameter")]
    public TerraformSet<TerraformBlock<AwsApigatewayv2RouteRequestParameterBlock>>? RequestParameter { get; set; } = new();

}
