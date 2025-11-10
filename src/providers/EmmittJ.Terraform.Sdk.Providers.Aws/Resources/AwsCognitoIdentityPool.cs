using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_identity_providers in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolCognitoIdentityProvidersBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProviderName
    {
        set => SetProperty("provider_name", value);
    }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    public TerraformProperty<bool>? ServerSideTokenCheck
    {
        set => SetProperty("server_side_token_check", value);
    }

}

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
        SetOutput("arn");
        SetOutput("allow_classic_flow");
        SetOutput("allow_unauthenticated_identities");
        SetOutput("developer_provider_name");
        SetOutput("id");
        SetOutput("identity_pool_name");
        SetOutput("openid_connect_provider_arns");
        SetOutput("region");
        SetOutput("saml_provider_arns");
        SetOutput("supported_login_providers");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    public TerraformProperty<bool> AllowClassicFlow
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_classic_flow");
        set => SetProperty("allow_classic_flow", value);
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformProperty<bool> AllowUnauthenticatedIdentities
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_unauthenticated_identities");
        set => SetProperty("allow_unauthenticated_identities", value);
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformProperty<string> DeveloperProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("developer_provider_name");
        set => SetProperty("developer_provider_name", value);
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
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> OpenidConnectProviderArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("openid_connect_provider_arns");
        set => SetProperty("openid_connect_provider_arns", value);
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
    /// The saml_provider_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>> SamlProviderArns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("saml_provider_arns");
        set => SetProperty("saml_provider_arns", value);
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> SupportedLoginProviders
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("supported_login_providers");
        set => SetProperty("supported_login_providers", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cognito_identity_providers.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>? CognitoIdentityProviders
    {
        set => SetProperty("cognito_identity_providers", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
