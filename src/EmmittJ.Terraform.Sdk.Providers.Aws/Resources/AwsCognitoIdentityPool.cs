using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool resource.
/// </summary>
public class AwsCognitoIdentityPool : TerraformResource
{
    public AwsCognitoIdentityPool(string name) : base("aws_cognito_identity_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowClassicFlow
    {
        get => GetProperty<TerraformProperty<bool>>("allow_classic_flow");
        set => this.WithProperty("allow_classic_flow", value);
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowUnauthenticatedIdentities
    {
        get => GetProperty<TerraformProperty<bool>>("allow_unauthenticated_identities");
        set => this.WithProperty("allow_unauthenticated_identities", value);
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeveloperProviderName
    {
        get => GetProperty<TerraformProperty<string>>("developer_provider_name");
        set => this.WithProperty("developer_provider_name", value);
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
    /// The identity_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityPoolName
    {
        get => GetProperty<TerraformProperty<string>>("identity_pool_name");
        set => this.WithProperty("identity_pool_name", value);
    }

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? OpenidConnectProviderArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("openid_connect_provider_arns");
        set => this.WithProperty("openid_connect_provider_arns", value);
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
    /// The saml_provider_arns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SamlProviderArns
    {
        get => GetProperty<TerraformProperty<List<string>>>("saml_provider_arns");
        set => this.WithProperty("saml_provider_arns", value);
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? SupportedLoginProviders
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("supported_login_providers");
        set => this.WithProperty("supported_login_providers", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
