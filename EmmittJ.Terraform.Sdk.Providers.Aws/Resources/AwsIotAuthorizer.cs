using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_authorizer resource.
/// </summary>
public class AwsIotAuthorizer : TerraformResource
{
    public AwsIotAuthorizer(string name) : base("aws_iot_authorizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The authorizer_function_arn attribute.
    /// </summary>
    public string? AuthorizerFunctionArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_function_arn")?.Value;
        set => this.WithProperty("authorizer_function_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    public bool? EnableCachingForHttp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_caching_for_http")?.Value;
        set => this.WithProperty("enable_caching_for_http", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The signing_disabled attribute.
    /// </summary>
    public bool? SigningDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("signing_disabled")?.Value;
        set => this.WithProperty("signing_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The token_key_name attribute.
    /// </summary>
    public string? TokenKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_key_name")?.Value;
        set => this.WithProperty("token_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    public Dictionary<string, string>? TokenSigningPublicKeys
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("token_signing_public_keys")?.Value;
        set => this.WithProperty("token_signing_public_keys", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
