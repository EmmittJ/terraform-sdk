using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_authorizer resource.
/// </summary>
public class AwsApigatewayv2Authorizer : TerraformResource
{
    public AwsApigatewayv2Authorizer(string name) : base("aws_apigatewayv2_authorizer", name)
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
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    public string? AuthorizerCredentialsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_credentials_arn")?.Value;
        set => this.WithProperty("authorizer_credentials_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    public string? AuthorizerPayloadFormatVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_payload_format_version")?.Value;
        set => this.WithProperty("authorizer_payload_format_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public double? AuthorizerResultTtlInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("authorizer_result_ttl_in_seconds")?.Value;
        set => this.WithProperty("authorizer_result_ttl_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    public string? AuthorizerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_type")?.Value;
        set => this.WithProperty("authorizer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public string? AuthorizerUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_uri")?.Value;
        set => this.WithProperty("authorizer_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    public bool? EnableSimpleResponses
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_simple_responses")?.Value;
        set => this.WithProperty("enable_simple_responses", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The identity_sources attribute.
    /// </summary>
    public HashSet<string>? IdentitySources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("identity_sources")?.Value;
        set => this.WithProperty("identity_sources", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
