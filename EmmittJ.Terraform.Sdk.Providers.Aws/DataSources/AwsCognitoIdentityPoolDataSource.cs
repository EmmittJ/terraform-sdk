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
        this.DeclareOutput("allow_classic_flow");
        this.DeclareOutput("allow_unauthenticated_identities");
        this.DeclareOutput("arn");
        this.DeclareOutput("cognito_identity_providers");
        this.DeclareOutput("developer_provider_name");
        this.DeclareOutput("openid_connect_provider_arns");
        this.DeclareOutput("saml_provider_arns");
        this.DeclareOutput("supported_login_providers");
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
    /// The identity_pool_name attribute.
    /// </summary>
    public string? IdentityPoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_pool_name")?.Value;
        set => this.WithProperty("identity_pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
