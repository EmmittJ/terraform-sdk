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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerCredentials
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_credentials");
        set => this.WithProperty("authorizer_credentials", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? AuthorizerResultTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("authorizer_result_ttl_in_seconds");
        set => this.WithProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerUri
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_uri");
        set => this.WithProperty("authorizer_uri", value);
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
    /// The identity_source attribute.
    /// </summary>
    public TerraformProperty<string>? IdentitySource
    {
        get => GetProperty<TerraformProperty<string>>("identity_source");
        set => this.WithProperty("identity_source", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityValidationExpression
    {
        get => GetProperty<TerraformProperty<string>>("identity_validation_expression");
        set => this.WithProperty("identity_validation_expression", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProviderArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("provider_arns");
        set => this.WithProperty("provider_arns", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
