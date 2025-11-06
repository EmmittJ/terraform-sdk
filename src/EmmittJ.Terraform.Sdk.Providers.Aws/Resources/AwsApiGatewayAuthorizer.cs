using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_authorizer resource.
/// </summary>
public class AwsApiGatewayAuthorizer : TerraformResource
{
    public AwsApiGatewayAuthorizer(string name) : base("aws_api_gateway_authorizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public string? AuthorizerCredentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_credentials")?.Value;
        set => this.WithProperty("authorizer_credentials", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The authorizer_uri attribute.
    /// </summary>
    public string? AuthorizerUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorizer_uri")?.Value;
        set => this.WithProperty("authorizer_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_source attribute.
    /// </summary>
    public string? IdentitySource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_source")?.Value;
        set => this.WithProperty("identity_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public string? IdentityValidationExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_validation_expression")?.Value;
        set => this.WithProperty("identity_validation_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The provider_arns attribute.
    /// </summary>
    public HashSet<string>? ProviderArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("provider_arns")?.Value;
        set => this.WithProperty("provider_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
