using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for request_parameter in AwsApigatewayv2Route.
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2RouteRequestParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_parameter";

    /// <summary>
    /// The request_parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestParameterKey is required")]
    public required TerraformValue<string> RequestParameterKey
    {
        get => GetArgument<TerraformValue<string>>("request_parameter_key");
        set => SetArgument("request_parameter_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_route Terraform resource.
/// Manages a aws_apigatewayv2_route resource.
/// </summary>
public partial class AwsApigatewayv2Route(string name) : TerraformResource("aws_apigatewayv2_route", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformValue<bool>? ApiKeyRequired
    {
        get => GetArgument<TerraformValue<bool>>("api_key_required");
        set => SetArgument("api_key_required", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizationScopes
    {
        get => GetArgument<TerraformSet<string>>("authorization_scopes");
        set => SetArgument("authorization_scopes", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationType
    {
        get => GetArgument<TerraformValue<string>>("authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerId
    {
        get => GetArgument<TerraformValue<string>>("authorizer_id");
        set => SetArgument("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? ModelSelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("model_selection_expression");
        set => SetArgument("model_selection_expression", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformValue<string>? OperationName
    {
        get => GetArgument<TerraformValue<string>>("operation_name");
        set => SetArgument("operation_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public TerraformMap<string>? RequestModels
    {
        get => GetArgument<TerraformMap<string>>("request_models");
        set => SetArgument("request_models", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformValue<string> RouteKey
    {
        get => GetArgument<TerraformValue<string>>("route_key");
        set => SetArgument("route_key", value);
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? RouteResponseSelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("route_response_selection_expression");
        set => SetArgument("route_response_selection_expression", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// RequestParameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsApigatewayv2RouteRequestParameterBlock>? RequestParameter
    {
        get => GetArgument<TerraformSet<AwsApigatewayv2RouteRequestParameterBlock>>("request_parameter");
        set => SetArgument("request_parameter", value);
    }

}
