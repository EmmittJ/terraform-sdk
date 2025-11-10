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
        set => SetProperty("request_parameter_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformProperty<bool> Required
    {
        set => SetProperty("required", value);
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
        SetOutput("api_id");
        SetOutput("api_key_required");
        SetOutput("authorization_scopes");
        SetOutput("authorization_type");
        SetOutput("authorizer_id");
        SetOutput("id");
        SetOutput("model_selection_expression");
        SetOutput("operation_name");
        SetOutput("region");
        SetOutput("request_models");
        SetOutput("route_key");
        SetOutput("route_response_selection_expression");
        SetOutput("target");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public TerraformProperty<bool> ApiKeyRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("api_key_required");
        set => SetProperty("api_key_required", value);
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AuthorizationScopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("authorization_scopes");
        set => SetProperty("authorization_scopes", value);
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_type");
        set => SetProperty("authorization_type", value);
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_id");
        set => SetProperty("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> ModelSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_selection_expression");
        set => SetProperty("model_selection_expression", value);
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public TerraformProperty<string> OperationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operation_name");
        set => SetProperty("operation_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RequestModels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("request_models");
        set => SetProperty("request_models", value);
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    public required TerraformProperty<string> RouteKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_key");
        set => SetProperty("route_key", value);
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> RouteResponseSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_response_selection_expression");
        set => SetProperty("route_response_selection_expression", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string> Target
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target");
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Block for request_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2RouteRequestParameterBlock>? RequestParameter
    {
        set => SetProperty("request_parameter", value);
    }

}
