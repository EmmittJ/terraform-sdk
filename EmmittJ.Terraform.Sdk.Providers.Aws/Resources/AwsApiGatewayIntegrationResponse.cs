using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_integration_response resource.
/// </summary>
public class AwsApiGatewayIntegrationResponse : TerraformResource
{
    public AwsApiGatewayIntegrationResponse(string name) : base("aws_api_gateway_integration_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    public string? ContentHandling
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_handling")?.Value;
        set => this.WithProperty("content_handling", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public string? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method")?.Value;
        set => this.WithProperty("http_method", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_parameters")?.Value;
        set => this.WithProperty("response_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_templates")?.Value;
        set => this.WithProperty("response_templates", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The selection_pattern attribute.
    /// </summary>
    public string? SelectionPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("selection_pattern")?.Value;
        set => this.WithProperty("selection_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public string? StatusCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status_code")?.Value;
        set => this.WithProperty("status_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
