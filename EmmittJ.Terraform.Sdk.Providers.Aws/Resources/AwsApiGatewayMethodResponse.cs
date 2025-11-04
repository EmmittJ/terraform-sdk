using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method_response resource.
/// </summary>
public class AwsApiGatewayMethodResponse : TerraformResource
{
    public AwsApiGatewayMethodResponse(string name) : base("aws_api_gateway_method_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The response_models attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseModels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_models")?.Value;
        set => this.WithProperty("response_models", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The response_parameters attribute.
    /// </summary>
    public Dictionary<string, bool>? ResponseParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("response_parameters")?.Value;
        set => this.WithProperty("response_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, bool>>(value));
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
    /// The status_code attribute.
    /// </summary>
    public string? StatusCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status_code")?.Value;
        set => this.WithProperty("status_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
