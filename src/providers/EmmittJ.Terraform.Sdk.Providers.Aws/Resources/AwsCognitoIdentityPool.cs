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
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ProviderName
    {
        get => GetArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The server_side_token_check attribute.
    /// </summary>
    public TerraformValue<bool>? ServerSideTokenCheck
    {
        get => GetArgument<TerraformValue<bool>>("server_side_token_check");
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
        get => GetArgument<TerraformValue<bool>>("allow_classic_flow");
        set => SetArgument("allow_classic_flow", value);
    }

    /// <summary>
    /// The allow_unauthenticated_identities attribute.
    /// </summary>
    public TerraformValue<bool>? AllowUnauthenticatedIdentities
    {
        get => GetArgument<TerraformValue<bool>>("allow_unauthenticated_identities");
        set => SetArgument("allow_unauthenticated_identities", value);
    }

    /// <summary>
    /// The developer_provider_name attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperProviderName
    {
        get => GetArgument<TerraformValue<string>>("developer_provider_name");
        set => SetArgument("developer_provider_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolName is required")]
    public required TerraformValue<string> IdentityPoolName
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_pool_name");
        set => SetArgument("identity_pool_name", value);
    }

    /// <summary>
    /// The openid_connect_provider_arns attribute.
    /// </summary>
    public TerraformSet<string>? OpenidConnectProviderArns
    {
        get => GetArgument<TerraformSet<string>>("openid_connect_provider_arns");
        set => SetArgument("openid_connect_provider_arns", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The saml_provider_arns attribute.
    /// </summary>
    public TerraformList<string>? SamlProviderArns
    {
        get => GetArgument<TerraformList<string>>("saml_provider_arns");
        set => SetArgument("saml_provider_arns", value);
    }

    /// <summary>
    /// The supported_login_providers attribute.
    /// </summary>
    public TerraformMap<string>? SupportedLoginProviders
    {
        get => GetArgument<TerraformMap<string>>("supported_login_providers");
        set => SetArgument("supported_login_providers", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// CognitoIdentityProviders block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>? CognitoIdentityProviders
    {
        get => GetArgument<TerraformSet<AwsCognitoIdentityPoolCognitoIdentityProvidersBlock>>("cognito_identity_providers");
        set => SetArgument("cognito_identity_providers", value);
    }

}
