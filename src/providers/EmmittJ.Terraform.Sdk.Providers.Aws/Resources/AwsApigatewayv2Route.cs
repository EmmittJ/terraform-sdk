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
        get => new TerraformReference<string>(this, "request_parameter_key");
        set => SetArgument("request_parameter_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
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
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformValue<bool>? ApiKeyRequired
    {
        get => new TerraformReference<bool>(this, "api_key_required");
        set => SetArgument("api_key_required", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizationScopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "authorization_scopes").ResolveNodes(ctx));
        set => SetArgument("authorization_scopes", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationType
    {
        get => new TerraformReference<string>(this, "authorization_type");
        set => SetArgument("authorization_type", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizerId
    {
        get => new TerraformReference<string>(this, "authorizer_id");
        set => SetArgument("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? ModelSelectionExpression
    {
        get => new TerraformReference<string>(this, "model_selection_expression");
        set => SetArgument("model_selection_expression", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformValue<string>? OperationName
    {
        get => new TerraformReference<string>(this, "operation_name");
        set => SetArgument("operation_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public TerraformMap<string>? RequestModels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "request_models").ResolveNodes(ctx));
        set => SetArgument("request_models", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformValue<string> RouteKey
    {
        get => new TerraformReference<string>(this, "route_key");
        set => SetArgument("route_key", value);
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? RouteResponseSelectionExpression
    {
        get => new TerraformReference<string>(this, "route_response_selection_expression");
        set => SetArgument("route_response_selection_expression", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => new TerraformReference<string>(this, "target");
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
