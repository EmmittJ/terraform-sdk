using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProvider.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_provider_config";

    /// <summary>
    /// CustomOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlock>? CustomOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlock>>("custom_oauth2_provider_config");
        set => SetArgument("custom_oauth2_provider_config", value);
    }

    /// <summary>
    /// GithubOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGithubOauth2ProviderConfigBlock>? GithubOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGithubOauth2ProviderConfigBlock>>("github_oauth2_provider_config");
        set => SetArgument("github_oauth2_provider_config", value);
    }

    /// <summary>
    /// GoogleOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGoogleOauth2ProviderConfigBlock>? GoogleOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGoogleOauth2ProviderConfigBlock>>("google_oauth2_provider_config");
        set => SetArgument("google_oauth2_provider_config", value);
    }

    /// <summary>
    /// MicrosoftOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockMicrosoftOauth2ProviderConfigBlock>? MicrosoftOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockMicrosoftOauth2ProviderConfigBlock>>("microsoft_oauth2_provider_config");
        set => SetArgument("microsoft_oauth2_provider_config", value);
    }

    /// <summary>
    /// SalesforceOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSalesforceOauth2ProviderConfigBlock>? SalesforceOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSalesforceOauth2ProviderConfigBlock>>("salesforce_oauth2_provider_config");
        set => SetArgument("salesforce_oauth2_provider_config", value);
    }

    /// <summary>
    /// SlackOauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSlackOauth2ProviderConfigBlock>? SlackOauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSlackOauth2ProviderConfigBlock>>("slack_oauth2_provider_config");
        set => SetArgument("slack_oauth2_provider_config", value);
    }

}

/// <summary>
/// Block type for custom_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// OauthDiscovery block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlock>? OauthDiscovery
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlock>>("oauth_discovery");
        set => SetArgument("oauth_discovery", value);
    }

}

/// <summary>
/// Block type for oauth_discovery in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_discovery";

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    public TerraformValue<string>? DiscoveryUrl
    {
        get => GetArgument<TerraformValue<string>>("discovery_url");
        set => SetArgument("discovery_url", value);
    }

    /// <summary>
    /// AuthorizationServerMetadata block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlockAuthorizationServerMetadataBlock>? AuthorizationServerMetadata
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlockAuthorizationServerMetadataBlock>>("authorization_server_metadata");
        set => SetArgument("authorization_server_metadata", value);
    }

}

/// <summary>
/// Block type for authorization_server_metadata in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockCustomOauth2ProviderConfigBlockOauthDiscoveryBlockAuthorizationServerMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization_server_metadata";

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => GetArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The response_types attribute.
    /// </summary>
    public TerraformSet<string>? ResponseTypes
    {
        get => GetArgument<TerraformSet<string>>("response_types");
        set => SetArgument("response_types", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

}

/// <summary>
/// Block type for github_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGithubOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// The oauth_discovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OauthDiscovery
        => AsReference("oauth_discovery");

}

/// <summary>
/// Block type for google_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockGoogleOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// The oauth_discovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OauthDiscovery
        => AsReference("oauth_discovery");

}

/// <summary>
/// Block type for microsoft_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockMicrosoftOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// The oauth_discovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OauthDiscovery
        => AsReference("oauth_discovery");

}

/// <summary>
/// Block type for salesforce_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSalesforceOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// The oauth_discovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OauthDiscovery
        => AsReference("oauth_discovery");

}

/// <summary>
/// Block type for slack_oauth2_provider_config in AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlockSlackOauth2ProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slack_oauth2_provider_config";

    /// <summary>
    /// The client_credentials_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ClientCredentialsWoVersion
    {
        get => GetArgument<TerraformValue<double>>("client_credentials_wo_version");
        set => SetArgument("client_credentials_wo_version", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_id_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientIdWo
    {
        get => GetArgument<TerraformValue<string>>("client_id_wo");
        set => SetArgument("client_id_wo", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The client_secret_wo attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecretWo
    {
        get => GetArgument<TerraformValue<string>>("client_secret_wo");
        set => SetArgument("client_secret_wo", value);
    }

    /// <summary>
    /// The oauth_discovery attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OauthDiscovery
        => AsReference("oauth_discovery");

}


/// <summary>
/// Represents a aws_bedrockagentcore_oauth2_credential_provider Terraform resource.
/// Manages a aws_bedrockagentcore_oauth2_credential_provider resource.
/// </summary>
public partial class AwsBedrockagentcoreOauth2CredentialProvider(string name) : TerraformResource("aws_bedrockagentcore_oauth2_credential_provider", name)
{
    /// <summary>
    /// The credential_provider_vendor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialProviderVendor is required")]
    public required TerraformValue<string> CredentialProviderVendor
    {
        get => GetArgument<TerraformValue<string>>("credential_provider_vendor");
        set => SetArgument("credential_provider_vendor", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The client_secret_arn attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClientSecretArn
        => AsReference("client_secret_arn");

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    public TerraformValue<string> CredentialProviderArn
        => AsReference("credential_provider_arn");

    /// <summary>
    /// Oauth2ProviderConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>? Oauth2ProviderConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>>("oauth2_provider_config");
        set => SetArgument("oauth2_provider_config", value);
    }

}
