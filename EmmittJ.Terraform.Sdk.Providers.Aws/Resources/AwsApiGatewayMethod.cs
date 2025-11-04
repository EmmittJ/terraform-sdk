using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_method resource.
/// </summary>
public class AwsApiGatewayMethod : TerraformResource
{
    public AwsApiGatewayMethod(string name) : base("aws_api_gateway_method", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The authorization attribute.
    /// </summary>
    public string? Authorization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization")?.Value;
        set => this.WithProperty("authorization", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The authorizer_id attribute.
    /// </summary>
    public string? AuthorizerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_id")?.Value;
        set => this.WithProperty("authorizer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, bool>? RequestParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("request_parameters")?.Value;
        set => this.WithProperty("request_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, bool>>(value));
    }

    /// <summary>
    /// The request_validator_id attribute.
    /// </summary>
    public string? RequestValidatorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_validator_id")?.Value;
        set => this.WithProperty("request_validator_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
