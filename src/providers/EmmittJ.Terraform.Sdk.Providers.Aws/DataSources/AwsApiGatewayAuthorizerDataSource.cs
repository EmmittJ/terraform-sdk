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
        this.WithOutput("arn");
        this.WithOutput("authorizer_credentials");
        this.WithOutput("authorizer_result_ttl_in_seconds");
        this.WithOutput("authorizer_uri");
        this.WithOutput("identity_source");
        this.WithOutput("identity_validation_expression");
        this.WithOutput("name");
        this.WithOutput("provider_arns");
        this.WithOutput("type");
    }

    /// <summary>
    /// The authorizer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerId is required")]
    public required TerraformProperty<string> AuthorizerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authorizer_id");
        set => this.WithProperty("authorizer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
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
