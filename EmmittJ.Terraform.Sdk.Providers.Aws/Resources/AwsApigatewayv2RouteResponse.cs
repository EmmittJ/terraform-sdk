using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_route_response resource.
/// </summary>
public class AwsApigatewayv2RouteResponse : TerraformResource
{
    public AwsApigatewayv2RouteResponse(string name) : base("aws_apigatewayv2_route_response", name)
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
    /// The response_models attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseModels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_models")?.Value;
        set => this.WithProperty("response_models", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The route_id attribute.
    /// </summary>
    public string? RouteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_id")?.Value;
        set => this.WithProperty("route_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_response_key attribute.
    /// </summary>
    public string? RouteResponseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_response_key")?.Value;
        set => this.WithProperty("route_response_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
