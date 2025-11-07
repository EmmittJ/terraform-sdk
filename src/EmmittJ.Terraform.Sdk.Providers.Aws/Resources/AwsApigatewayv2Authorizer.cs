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
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizerCredentialsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_credentials_arn");
        set => this.WithProperty("authorizer_credentials_arn", value);
    }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizerPayloadFormatVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_payload_format_version");
        set => this.WithProperty("authorizer_payload_format_version", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AuthorizerResultTtlInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("authorizer_result_ttl_in_seconds");
        set => this.WithProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_type");
        set => this.WithProperty("authorizer_type", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizerUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_uri");
        set => this.WithProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableSimpleResponses
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_simple_responses");
        set => this.WithProperty("enable_simple_responses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_sources attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IdentitySources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("identity_sources");
        set => this.WithProperty("identity_sources", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
