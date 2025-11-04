using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_authorizer.
/// </summary>
public class AwsApiGatewayAuthorizerDataSource : TerraformDataSource
{
    public AwsApiGatewayAuthorizerDataSource(string name) : base("aws_api_gateway_authorizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("authorizer_credentials");
        this.DeclareOutput("authorizer_result_ttl_in_seconds");
        this.DeclareOutput("authorizer_uri");
        this.DeclareOutput("identity_source");
        this.DeclareOutput("identity_validation_expression");
        this.DeclareOutput("name");
        this.DeclareOutput("provider_arns");
        this.DeclareOutput("type");
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
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformExpression AuthorizerCredentials => this["authorizer_credentials"];

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformExpression AuthorizerResultTtlInSeconds => this["authorizer_result_ttl_in_seconds"];

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformExpression AuthorizerUri => this["authorizer_uri"];

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    public TerraformExpression IdentitySource => this["identity_source"];

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformExpression IdentityValidationExpression => this["identity_validation_expression"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    public TerraformExpression ProviderArns => this["provider_arns"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
