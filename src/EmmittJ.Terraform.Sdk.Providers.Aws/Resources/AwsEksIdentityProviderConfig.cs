using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oidc in .
/// Nesting mode: list
/// </summary>
public class AwsEksIdentityProviderConfigOidcBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The groups_claim attribute.
    /// </summary>
    public TerraformProperty<string>? GroupsClaim
    {
        get => GetProperty<TerraformProperty<string>>("groups_claim");
        set => WithProperty("groups_claim", value);
    }

    /// <summary>
    /// The groups_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? GroupsPrefix
    {
        get => GetProperty<TerraformProperty<string>>("groups_prefix");
        set => WithProperty("groups_prefix", value);
    }

    /// <summary>
    /// The identity_provider_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderConfigName is required")]
    public required TerraformProperty<string> IdentityProviderConfigName
    {
        get => GetProperty<TerraformProperty<string>>("identity_provider_config_name");
        set => WithProperty("identity_provider_config_name", value);
    }

    /// <summary>
    /// The issuer_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    public required TerraformProperty<string> IssuerUrl
    {
        get => GetProperty<TerraformProperty<string>>("issuer_url");
        set => WithProperty("issuer_url", value);
    }

    /// <summary>
    /// The required_claims attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RequiredClaims
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("required_claims");
        set => WithProperty("required_claims", value);
    }

    /// <summary>
    /// The username_claim attribute.
    /// </summary>
    public TerraformProperty<string>? UsernameClaim
    {
        get => GetProperty<TerraformProperty<string>>("username_claim");
        set => WithProperty("username_claim", value);
    }

    /// <summary>
    /// The username_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? UsernamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("username_prefix");
        set => WithProperty("username_prefix", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksIdentityProviderConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_eks_identity_provider_config resource.
/// </summary>
public class AwsEksIdentityProviderConfig : TerraformResource
{
    public AwsEksIdentityProviderConfig(string name) : base("aws_eks_identity_provider_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for oidc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Oidc block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oidc block(s) allowed")]
    public List<AwsEksIdentityProviderConfigOidcBlock>? Oidc
    {
        get => GetProperty<List<AwsEksIdentityProviderConfigOidcBlock>>("oidc");
        set => this.WithProperty("oidc", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEksIdentityProviderConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEksIdentityProviderConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
