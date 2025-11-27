using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_identity_providers in AwsCognitoIdentityPool.
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolCognitoIdentityProvidersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_identity_providers";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    public TerraformValue<bool>? ServerSideTokenCheck
    {
        get => new TerraformReference<bool>(this, "server_side_token_check");
        set => SetArgument("server_side_token_check", value);
    }

}


/// <summary>
/// Represents a aws_cognito_identity_pool Terraform resource.
/// Manages a aws_cognito_identity_pool resource.
/// </summary>
public partial class AwsCognitoIdentityPool(string name) : TerraformResource("aws_cognito_identity_pool", name)
{
    /// <summary>
    /// The allow_classic_flow attribute.
    /// </summary>
    public TerraformValue<bool>? AllowClassicFlow
    {
        get => new TerraformReference<bool>(this, "allow_classic_flow");
        set => SetArgument("allow_classic_flow", value);
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformValue<bool>? AllowUnauthenticatedIdentities
    {
        get => new TerraformReference<bool>(this, "allow_unauthenticated_identities");
        set => SetArgument("allow_unauthenticated_identities", value);
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperProviderName
    {
        get => new TerraformReference<string>(this, "developer_provider_name");
        set => SetArgument("developer_provider_name", value);
    }

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
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public TerraformSet<string>? OpenidConnectProviderArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "openid_connect_provider_arns").ResolveNodes(ctx));
        set => SetArgument("openid_connect_provider_arns", value);
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
    /// The saml_provider_arns attribute.
    /// </summary>
    public TerraformList<string>? SamlProviderArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "saml_provider_arns").ResolveNodes(ctx));
        set => SetArgument("saml_provider_arns", value);
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public TerraformMap<string>? SupportedLoginProviders
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "supported_login_providers").ResolveNodes(ctx));
        set => SetArgument("supported_login_providers", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CognitoIdentityProviders block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>? CognitoIdentityProviders
    {
        get => GetArgument<TerraformSet<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>>("cognito_identity_providers");
        set => SetArgument("cognito_identity_providers", value);
    }

}
