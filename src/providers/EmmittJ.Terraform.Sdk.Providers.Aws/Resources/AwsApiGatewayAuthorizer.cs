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
        SetOutput("arn");
        SetOutput("authorizer_credentials");
        SetOutput("authorizer_result_ttl_in_seconds");
        SetOutput("authorizer_uri");
        SetOutput("id");
        SetOutput("identity_source");
        SetOutput("identity_validation_expression");
        SetOutput("name");
        SetOutput("provider_arns");
        SetOutput("region");
        SetOutput("rest_api_id");
        SetOutput("type");
    }

    /// <summary>
    /// The authorizer_credentials attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerCredentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_credentials");
        set => SetProperty("authorizer_credentials", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> AuthorizerResultTtlInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("authorizer_result_ttl_in_seconds");
        set => SetProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_uri");
        set => SetProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_source attribute.
    /// </summary>
    public TerraformProperty<string> IdentitySource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_source");
        set => SetProperty("identity_source", value);
    }

    /// <summary>
    /// The identity_validation_expression attribute.
    /// </summary>
    public TerraformProperty<string> IdentityValidationExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_validation_expression");
        set => SetProperty("identity_validation_expression", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The provider_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ProviderArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("provider_arns");
        set => SetProperty("provider_arns", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
