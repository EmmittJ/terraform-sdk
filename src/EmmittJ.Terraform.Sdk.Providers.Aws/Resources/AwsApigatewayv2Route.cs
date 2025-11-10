using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for request_parameter in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2RouteRequestParameterBlock : TerraformBlock
{
    /// <summary>
    /// The request_parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestParameterKey is required")]
    public required TerraformProperty<string> RequestParameterKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("request_parameter_key");
        set => WithProperty("request_parameter_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformProperty<bool> Required
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("required");
        set => WithProperty("required", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_route resource.
/// </summary>
public class AwsApigatewayv2Route : TerraformResource
{
    public AwsApigatewayv2Route(string name) : base("aws_apigatewayv2_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformProperty<bool>? ApiKeyRequired
    {
        get => GetProperty<TerraformProperty<bool>>("api_key_required");
        set => this.WithProperty("api_key_required", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AuthorizationScopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("authorization_scopes");
        set => this.WithProperty("authorization_scopes", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerId
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_id");
        set => this.WithProperty("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ModelSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("model_selection_expression");
        set => this.WithProperty("model_selection_expression", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string>? OperationName
    {
        get => GetProperty<TerraformProperty<string>>("operation_name");
        set => this.WithProperty("operation_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RequestModels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("request_models");
        set => this.WithProperty("request_models", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformProperty<string> RouteKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("route_key");
        set => this.WithProperty("route_key", value);
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? RouteResponseSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("route_response_selection_expression");
        set => this.WithProperty("route_response_selection_expression", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for request_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2RouteRequestParameterBlock>? RequestParameter
    {
        get => GetProperty<HashSet<AwsApigatewayv2RouteRequestParameterBlock>>("request_parameter");
        set => this.WithProperty("request_parameter", value);
    }

}
