using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_identity_pool.
/// </summary>
public class AwsCognitoIdentityPoolDataSource : TerraformDataSource
{
    public AwsCognitoIdentityPoolDataSource(string name) : base("aws_cognito_identity_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allow_classic_flow");
        SetOutput("allow_unauthenticated_identities");
        SetOutput("arn");
        SetOutput("cognito_identity_providers");
        SetOutput("developer_provider_name");
        SetOutput("openid_connect_provider_arns");
        SetOutput("saml_provider_arns");
        SetOutput("supported_login_providers");
        SetOutput("id");
        SetOutput("identity_pool_name");
        SetOutput("region");
        SetOutput("tags");
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
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    public required TerraformProperty<string> IdentityPoolName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_pool_name");
        set => SetProperty("identity_pool_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    public TerraformExpression AllowClassicFlow => this["allow_classic_flow"];

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformExpression AllowUnauthenticatedIdentities => this["allow_unauthenticated_identities"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cognito_identity_providers attribute.
    /// </summary>
    public TerraformExpression CognitoIdentityProviders => this["cognito_identity_providers"];

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformExpression DeveloperProviderName => this["developer_provider_name"];

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public TerraformExpression OpenidConnectProviderArns => this["openid_connect_provider_arns"];

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    public TerraformExpression SamlProviderArns => this["saml_provider_arns"];

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public TerraformExpression SupportedLoginProviders => this["supported_login_providers"];

}
