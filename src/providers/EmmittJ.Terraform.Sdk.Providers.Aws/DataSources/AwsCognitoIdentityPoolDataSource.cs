using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_identity_pool Terraform data source.
/// Retrieves information about a aws_cognito_identity_pool.
/// </summary>
public partial class AwsCognitoIdentityPoolDataSource(string name) : TerraformDataSource("aws_cognito_identity_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    public required TerraformValue<string> IdentityPoolName
    {
        get => new TerraformReference<string>(this, "identity_pool_name");
        set => SetArgument("identity_pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    public TerraformValue<bool> AllowClassicFlow
    {
        get => new TerraformReference<bool>(this, "allow_classic_flow");
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformValue<bool> AllowUnauthenticatedIdentities
    {
        get => new TerraformReference<bool>(this, "allow_unauthenticated_identities");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cognito_identity_providers attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> CognitoIdentityProviders
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "cognito_identity_providers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformValue<string> DeveloperProviderName
    {
        get => new TerraformReference<string>(this, "developer_provider_name");
    }

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public TerraformSet<string> OpenidConnectProviderArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "openid_connect_provider_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    public TerraformList<string> SamlProviderArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "saml_provider_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public TerraformMap<string> SupportedLoginProviders
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "supported_login_providers").ResolveNodes(ctx));
    }

}
