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
    public bool? AllowClassicFlow
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_classic_flow")?.Value;
        set => this.WithProperty("allow_classic_flow", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public bool? AllowUnauthenticatedIdentities
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_unauthenticated_identities")?.Value;
        set => this.WithProperty("allow_unauthenticated_identities", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public string? DeveloperProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_provider_name")?.Value;
        set => this.WithProperty("developer_provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public HashSet<string>? OpenidConnectProviderArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("openid_connect_provider_arns")?.Value;
        set => this.WithProperty("openid_connect_provider_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The saml_provider_arns attribute.
    /// </summary>
    public List<string>? SamlProviderArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("saml_provider_arns")?.Value;
        set => this.WithProperty("saml_provider_arns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public Dictionary<string, string>? SupportedLoginProviders
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("supported_login_providers")?.Value;
        set => this.WithProperty("supported_login_providers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
