using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_key_required attribute.
    /// </summary>
    public bool? ApiKeyRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("api_key_required")?.Value;
        set => this.WithProperty("api_key_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The authorization_scopes attribute.
    /// </summary>
    public HashSet<string>? AuthorizationScopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("authorization_scopes")?.Value;
        set => this.WithProperty("authorization_scopes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public string? AuthorizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_type")?.Value;
        set => this.WithProperty("authorization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    public string? AuthorizerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_id")?.Value;
        set => this.WithProperty("authorizer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model_selection_expression attribute.
    /// </summary>
    public string? ModelSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_selection_expression")?.Value;
        set => this.WithProperty("model_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The operation_name attribute.
    /// </summary>
    public string? OperationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operation_name")?.Value;
        set => this.WithProperty("operation_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_models attribute.
    /// </summary>
    public Dictionary<string, string>? RequestModels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("request_models")?.Value;
        set => this.WithProperty("request_models", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    public string? RouteKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_key")?.Value;
        set => this.WithProperty("route_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_response_selection_expression attribute.
    /// </summary>
    public string? RouteResponseSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_response_selection_expression")?.Value;
        set => this.WithProperty("route_response_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public string? Target
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target")?.Value;
        set => this.WithProperty("target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
