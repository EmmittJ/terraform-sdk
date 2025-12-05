using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connector_profile_config in AwsAppflowConnectorProfile.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connector_profile_config";

    /// <summary>
    /// ConnectorProfileCredentials block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileCredentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileCredentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileCredentials block(s) allowed")]
    public required TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock> ConnectorProfileCredentials
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock>>("connector_profile_credentials");
        set => SetArgument("connector_profile_credentials", value);
    }

    /// <summary>
    /// ConnectorProfileProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileProperties block(s) allowed")]
    public required TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock> ConnectorProfileProperties
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock>>("connector_profile_properties");
        set => SetArgument("connector_profile_properties", value);
    }

}

/// <summary>
/// Block type for connector_profile_credentials in AwsAppflowConnectorProfileConnectorProfileConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connector_profile_credentials";

    /// <summary>
    /// Amplitude block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amplitude block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockAmplitudeBlock>? Amplitude
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockAmplitudeBlock>>("amplitude");
        set => SetArgument("amplitude", value);
    }

    /// <summary>
    /// CustomConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomConnector block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock>? CustomConnector
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock>>("custom_connector");
        set => SetArgument("custom_connector", value);
    }

    /// <summary>
    /// Datadog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datadog block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDatadogBlock>? Datadog
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDatadogBlock>>("datadog");
        set => SetArgument("datadog", value);
    }

    /// <summary>
    /// Dynatrace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dynatrace block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDynatraceBlock>? Dynatrace
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDynatraceBlock>>("dynatrace");
        set => SetArgument("dynatrace", value);
    }

    /// <summary>
    /// GoogleAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleAnalytics block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlock>? GoogleAnalytics
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlock>>("google_analytics");
        set => SetArgument("google_analytics", value);
    }

    /// <summary>
    /// Honeycode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Honeycode block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlock>? Honeycode
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlock>>("honeycode");
        set => SetArgument("honeycode", value);
    }

    /// <summary>
    /// InforNexus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InforNexus block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockInforNexusBlock>? InforNexus
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockInforNexusBlock>>("infor_nexus");
        set => SetArgument("infor_nexus", value);
    }

    /// <summary>
    /// Marketo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketo block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlock>? Marketo
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlock>>("marketo");
        set => SetArgument("marketo", value);
    }

    /// <summary>
    /// Redshift block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redshift block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockRedshiftBlock>? Redshift
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockRedshiftBlock>>("redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// Salesforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Salesforce block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlock>? Salesforce
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlock>>("salesforce");
        set => SetArgument("salesforce", value);
    }

    /// <summary>
    /// SapoData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SapoData block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlock>? SapoData
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlock>>("sapo_data");
        set => SetArgument("sapo_data", value);
    }

    /// <summary>
    /// ServiceNow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceNow block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockServiceNowBlock>? ServiceNow
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockServiceNowBlock>>("service_now");
        set => SetArgument("service_now", value);
    }

    /// <summary>
    /// Singular block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Singular block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSingularBlock>? Singular
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSingularBlock>>("singular");
        set => SetArgument("singular", value);
    }

    /// <summary>
    /// Slack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Slack block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlock>? Slack
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlock>>("slack");
        set => SetArgument("slack", value);
    }

    /// <summary>
    /// Snowflake block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Snowflake block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSnowflakeBlock>? Snowflake
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSnowflakeBlock>>("snowflake");
        set => SetArgument("snowflake", value);
    }

    /// <summary>
    /// Trendmicro block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trendmicro block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockTrendmicroBlock>? Trendmicro
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockTrendmicroBlock>>("trendmicro");
        set => SetArgument("trendmicro", value);
    }

    /// <summary>
    /// Veeva block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Veeva block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockVeevaBlock>? Veeva
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockVeevaBlock>>("veeva");
        set => SetArgument("veeva", value);
    }

    /// <summary>
    /// Zendesk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zendesk block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlock>? Zendesk
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlock>>("zendesk");
        set => SetArgument("zendesk", value);
    }

}

/// <summary>
/// Block type for amplitude in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockAmplitudeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amplitude";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretKey is required")]
    public required TerraformValue<string> SecretKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_key");
        set => SetArgument("secret_key", value);
    }

}

/// <summary>
/// Block type for custom_connector in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_connector";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// ApiKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKey block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockApiKeyBlock>? ApiKey
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockApiKeyBlock>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// Basic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockBasicBlock>? Basic
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockBasicBlock>>("basic");
        set => SetArgument("basic", value);
    }

    /// <summary>
    /// Custom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Custom block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockCustomBlock>? Custom
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockCustomBlock>>("custom");
        set => SetArgument("custom", value);
    }

    /// <summary>
    /// Oauth2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2 block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2Block>? Oauth2
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2Block>>("oauth2");
        set => SetArgument("oauth2", value);
    }

}

/// <summary>
/// Block type for api_key in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockApiKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The api_secret_key attribute.
    /// </summary>
    public TerraformValue<string>? ApiSecretKey
    {
        get => GetArgument<TerraformValue<string>>("api_secret_key");
        set => SetArgument("api_secret_key", value);
    }

}

/// <summary>
/// Block type for basic in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockBasicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for custom in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockCustomBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom";

    /// <summary>
    /// The credentials_map attribute.
    /// </summary>
    public TerraformMap<string>? CredentialsMap
    {
        get => GetArgument<TerraformMap<string>>("credentials_map");
        set => SetArgument("credentials_map", value);
    }

    /// <summary>
    /// The custom_authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomAuthenticationType is required")]
    public required TerraformValue<string> CustomAuthenticationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_authentication_type");
        set => SetArgument("custom_authentication_type", value);
    }

}

/// <summary>
/// Block type for oauth2 in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
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
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2BlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2BlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2Block.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockCustomConnectorBlockOauth2BlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for datadog in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDatadogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datadog";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The application_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationKey is required")]
    public required TerraformValue<string> ApplicationKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_key");
        set => SetArgument("application_key", value);
    }

}

/// <summary>
/// Block type for dynatrace in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockDynatraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynatrace";

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiToken is required")]
    public required TerraformValue<string> ApiToken
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_token");
        set => SetArgument("api_token", value);
    }

}

/// <summary>
/// Block type for google_analytics in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_analytics";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockGoogleAnalyticsBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for honeycode in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "honeycode";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockHoneycodeBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for infor_nexus in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockInforNexusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infor_nexus";

    /// <summary>
    /// The access_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformValue<string> AccessKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_key_id");
        set => SetArgument("access_key_id", value);
    }

    /// <summary>
    /// The datakey attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Datakey is required")]
    public required TerraformValue<string> Datakey
    {
        get => GetRequiredArgument<TerraformValue<string>>("datakey");
        set => SetArgument("datakey", value);
    }

    /// <summary>
    /// The secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretAccessKey is required")]
    public required TerraformValue<string> SecretAccessKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_access_key");
        set => SetArgument("secret_access_key", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_id");
        set => SetArgument("user_id", value);
    }

}

/// <summary>
/// Block type for marketo in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "marketo";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockMarketoBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for redshift in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockRedshiftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for salesforce in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? ClientCredentialsArn
    {
        get => GetArgument<TerraformValue<string>>("client_credentials_arn");
        set => SetArgument("client_credentials_arn", value);
    }

    /// <summary>
    /// The jwt_token attribute.
    /// </summary>
    public TerraformValue<string>? JwtToken
    {
        get => GetArgument<TerraformValue<string>>("jwt_token");
        set => SetArgument("jwt_token", value);
    }

    /// <summary>
    /// The oauth2_grant_type attribute.
    /// </summary>
    public TerraformValue<string>? Oauth2GrantType
    {
        get => GetArgument<TerraformValue<string>>("oauth2_grant_type");
        set => SetArgument("oauth2_grant_type", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSalesforceBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for sapo_data in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sapo_data";

    /// <summary>
    /// BasicAuthCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuthCredentials block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockBasicAuthCredentialsBlock>? BasicAuthCredentials
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockBasicAuthCredentialsBlock>>("basic_auth_credentials");
        set => SetArgument("basic_auth_credentials", value);
    }

    /// <summary>
    /// OauthCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthCredentials block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlock>? OauthCredentials
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlock>>("oauth_credentials");
        set => SetArgument("oauth_credentials", value);
    }

}

/// <summary>
/// Block type for basic_auth_credentials in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockBasicAuthCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_auth_credentials";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for oauth_credentials in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_credentials";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string>? RefreshToken
    {
        get => GetArgument<TerraformValue<string>>("refresh_token");
        set => SetArgument("refresh_token", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSapoDataBlockOauthCredentialsBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for service_now in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockServiceNowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_now";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for singular in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSingularBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "singular";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

}

/// <summary>
/// Block type for slack in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slack";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSlackBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for snowflake in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockSnowflakeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for trendmicro in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockTrendmicroBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trendmicro";

    /// <summary>
    /// The api_secret_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiSecretKey is required")]
    public required TerraformValue<string> ApiSecretKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_secret_key");
        set => SetArgument("api_secret_key", value);
    }

}

/// <summary>
/// Block type for veeva in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockVeevaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "veeva";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for zendesk in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zendesk";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// OauthRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthRequest block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlockOauthRequestBlock>? OauthRequest
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlockOauthRequestBlock>>("oauth_request");
        set => SetArgument("oauth_request", value);
    }

}

/// <summary>
/// Block type for oauth_request in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfileCredentialsBlockZendeskBlockOauthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_request";

    /// <summary>
    /// The auth_code attribute.
    /// </summary>
    public TerraformValue<string>? AuthCode
    {
        get => GetArgument<TerraformValue<string>>("auth_code");
        set => SetArgument("auth_code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    public TerraformValue<string>? RedirectUri
    {
        get => GetArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}

/// <summary>
/// Block type for connector_profile_properties in AwsAppflowConnectorProfileConnectorProfileConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connector_profile_properties";

    /// <summary>
    /// Amplitude block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amplitude block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockAmplitudeBlock>? Amplitude
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockAmplitudeBlock>>("amplitude");
        set => SetArgument("amplitude", value);
    }

    /// <summary>
    /// CustomConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomConnector block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlock>? CustomConnector
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlock>>("custom_connector");
        set => SetArgument("custom_connector", value);
    }

    /// <summary>
    /// Datadog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datadog block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDatadogBlock>? Datadog
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDatadogBlock>>("datadog");
        set => SetArgument("datadog", value);
    }

    /// <summary>
    /// Dynatrace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dynatrace block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDynatraceBlock>? Dynatrace
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDynatraceBlock>>("dynatrace");
        set => SetArgument("dynatrace", value);
    }

    /// <summary>
    /// GoogleAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleAnalytics block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockGoogleAnalyticsBlock>? GoogleAnalytics
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockGoogleAnalyticsBlock>>("google_analytics");
        set => SetArgument("google_analytics", value);
    }

    /// <summary>
    /// Honeycode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Honeycode block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockHoneycodeBlock>? Honeycode
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockHoneycodeBlock>>("honeycode");
        set => SetArgument("honeycode", value);
    }

    /// <summary>
    /// InforNexus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InforNexus block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockInforNexusBlock>? InforNexus
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockInforNexusBlock>>("infor_nexus");
        set => SetArgument("infor_nexus", value);
    }

    /// <summary>
    /// Marketo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketo block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockMarketoBlock>? Marketo
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockMarketoBlock>>("marketo");
        set => SetArgument("marketo", value);
    }

    /// <summary>
    /// Redshift block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redshift block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockRedshiftBlock>? Redshift
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockRedshiftBlock>>("redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// Salesforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Salesforce block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSalesforceBlock>? Salesforce
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSalesforceBlock>>("salesforce");
        set => SetArgument("salesforce", value);
    }

    /// <summary>
    /// SapoData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SapoData block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlock>? SapoData
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlock>>("sapo_data");
        set => SetArgument("sapo_data", value);
    }

    /// <summary>
    /// ServiceNow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceNow block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockServiceNowBlock>? ServiceNow
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockServiceNowBlock>>("service_now");
        set => SetArgument("service_now", value);
    }

    /// <summary>
    /// Singular block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Singular block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSingularBlock>? Singular
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSingularBlock>>("singular");
        set => SetArgument("singular", value);
    }

    /// <summary>
    /// Slack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Slack block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSlackBlock>? Slack
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSlackBlock>>("slack");
        set => SetArgument("slack", value);
    }

    /// <summary>
    /// Snowflake block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Snowflake block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSnowflakeBlock>? Snowflake
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSnowflakeBlock>>("snowflake");
        set => SetArgument("snowflake", value);
    }

    /// <summary>
    /// Trendmicro block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trendmicro block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockTrendmicroBlock>? Trendmicro
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockTrendmicroBlock>>("trendmicro");
        set => SetArgument("trendmicro", value);
    }

    /// <summary>
    /// Veeva block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Veeva block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockVeevaBlock>? Veeva
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockVeevaBlock>>("veeva");
        set => SetArgument("veeva", value);
    }

    /// <summary>
    /// Zendesk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zendesk block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockZendeskBlock>? Zendesk
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockZendeskBlock>>("zendesk");
        set => SetArgument("zendesk", value);
    }

}

/// <summary>
/// Block type for amplitude in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockAmplitudeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amplitude";

}

/// <summary>
/// Block type for custom_connector in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_connector";

    /// <summary>
    /// The profile_properties attribute.
    /// </summary>
    public TerraformMap<string>? ProfileProperties
    {
        get => GetArgument<TerraformMap<string>>("profile_properties");
        set => SetArgument("profile_properties", value);
    }

    /// <summary>
    /// Oauth2Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2Properties block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlockOauth2PropertiesBlock>? Oauth2Properties
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlockOauth2PropertiesBlock>>("oauth2_properties");
        set => SetArgument("oauth2_properties", value);
    }

}

/// <summary>
/// Block type for oauth2_properties in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockCustomConnectorBlockOauth2PropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_properties";

    /// <summary>
    /// The oauth2_grant_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2GrantType is required")]
    public required TerraformValue<string> Oauth2GrantType
    {
        get => GetRequiredArgument<TerraformValue<string>>("oauth2_grant_type");
        set => SetArgument("oauth2_grant_type", value);
    }

    /// <summary>
    /// The token_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenUrl is required")]
    public required TerraformValue<string> TokenUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("token_url");
        set => SetArgument("token_url", value);
    }

    /// <summary>
    /// The token_url_custom_properties attribute.
    /// </summary>
    public TerraformMap<string>? TokenUrlCustomProperties
    {
        get => GetArgument<TerraformMap<string>>("token_url_custom_properties");
        set => SetArgument("token_url_custom_properties", value);
    }

}

/// <summary>
/// Block type for datadog in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDatadogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datadog";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for dynatrace in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockDynatraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynatrace";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for google_analytics in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockGoogleAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_analytics";

}

/// <summary>
/// Block type for honeycode in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockHoneycodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "honeycode";

}

/// <summary>
/// Block type for infor_nexus in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockInforNexusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infor_nexus";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for marketo in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockMarketoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "marketo";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for redshift in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockRedshiftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The data_api_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? DataApiRoleArn
    {
        get => GetArgument<TerraformValue<string>>("data_api_role_arn");
        set => SetArgument("data_api_role_arn", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_url attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseUrl
    {
        get => GetArgument<TerraformValue<string>>("database_url");
        set => SetArgument("database_url", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for salesforce in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSalesforceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    public TerraformValue<string>? InstanceUrl
    {
        get => GetArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

    /// <summary>
    /// The is_sandbox_environment attribute.
    /// </summary>
    public TerraformValue<bool>? IsSandboxEnvironment
    {
        get => GetArgument<TerraformValue<bool>>("is_sandbox_environment");
        set => SetArgument("is_sandbox_environment", value);
    }

    /// <summary>
    /// The use_privatelink_for_metadata_and_authorization attribute.
    /// </summary>
    public TerraformValue<bool>? UsePrivatelinkForMetadataAndAuthorization
    {
        get => GetArgument<TerraformValue<bool>>("use_privatelink_for_metadata_and_authorization");
        set => SetArgument("use_privatelink_for_metadata_and_authorization", value);
    }

}

/// <summary>
/// Block type for sapo_data in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sapo_data";

    /// <summary>
    /// The application_host_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationHostUrl is required")]
    public required TerraformValue<string> ApplicationHostUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_host_url");
        set => SetArgument("application_host_url", value);
    }

    /// <summary>
    /// The application_service_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationServicePath is required")]
    public required TerraformValue<string> ApplicationServicePath
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_service_path");
        set => SetArgument("application_service_path", value);
    }

    /// <summary>
    /// The client_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientNumber is required")]
    public required TerraformValue<string> ClientNumber
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_number");
        set => SetArgument("client_number", value);
    }

    /// <summary>
    /// The logon_language attribute.
    /// </summary>
    public TerraformValue<string>? LogonLanguage
    {
        get => GetArgument<TerraformValue<string>>("logon_language");
        set => SetArgument("logon_language", value);
    }

    /// <summary>
    /// The port_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortNumber is required")]
    public required TerraformValue<double> PortNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("port_number");
        set => SetArgument("port_number", value);
    }

    /// <summary>
    /// The private_link_service_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkServiceName
    {
        get => GetArgument<TerraformValue<string>>("private_link_service_name");
        set => SetArgument("private_link_service_name", value);
    }

    /// <summary>
    /// OauthProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthProperties block(s) allowed")]
    public TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlockOauthPropertiesBlock>? OauthProperties
    {
        get => GetArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlockOauthPropertiesBlock>>("oauth_properties");
        set => SetArgument("oauth_properties", value);
    }

}

/// <summary>
/// Block type for oauth_properties in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSapoDataBlockOauthPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_properties";

    /// <summary>
    /// The auth_code_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthCodeUrl is required")]
    public required TerraformValue<string> AuthCodeUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_code_url");
        set => SetArgument("auth_code_url", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthScopes is required")]
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

    /// <summary>
    /// The token_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenUrl is required")]
    public required TerraformValue<string> TokenUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("token_url");
        set => SetArgument("token_url", value);
    }

}

/// <summary>
/// Block type for service_now in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockServiceNowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_now";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for singular in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSingularBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "singular";

}

/// <summary>
/// Block type for slack in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSlackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slack";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for snowflake in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockSnowflakeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake";

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformValue<string>? AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The private_link_service_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateLinkServiceName
    {
        get => GetArgument<TerraformValue<string>>("private_link_service_name");
        set => SetArgument("private_link_service_name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    public required TerraformValue<string> Stage
    {
        get => GetRequiredArgument<TerraformValue<string>>("stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// The warehouse attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Warehouse is required")]
    public required TerraformValue<string> Warehouse
    {
        get => GetRequiredArgument<TerraformValue<string>>("warehouse");
        set => SetArgument("warehouse", value);
    }

}

/// <summary>
/// Block type for trendmicro in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockTrendmicroBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trendmicro";

}

/// <summary>
/// Block type for veeva in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockVeevaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "veeva";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}

/// <summary>
/// Block type for zendesk in AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowConnectorProfileConnectorProfileConfigBlockConnectorProfilePropertiesBlockZendeskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zendesk";

    /// <summary>
    /// The instance_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceUrl is required")]
    public required TerraformValue<string> InstanceUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_url");
        set => SetArgument("instance_url", value);
    }

}


/// <summary>
/// Represents a aws_appflow_connector_profile Terraform resource.
/// Manages a aws_appflow_connector_profile resource.
/// </summary>
public partial class AwsAppflowConnectorProfile(string name) : TerraformResource("aws_appflow_connector_profile", name)
{
    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionMode is required")]
    public required TerraformValue<string> ConnectionMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_mode");
        set => SetArgument("connection_mode", value);
    }

    /// <summary>
    /// The connector_label attribute.
    /// </summary>
    public TerraformValue<string>? ConnectorLabel
    {
        get => GetArgument<TerraformValue<string>>("connector_label");
        set => SetArgument("connector_label", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformValue<string> ConnectorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("connector_type");
        set => SetArgument("connector_type", value);
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
    /// The kms_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsArn
    {
        get => GetArgument<TerraformValue<string>>("kms_arn") ?? CreateReference("kms_arn");
        set => SetArgument("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformValue<string> CredentialsArn
        => CreateReference("credentials_arn");

    /// <summary>
    /// ConnectorProfileConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectorProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorProfileConfig block(s) allowed")]
    public required TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlock> ConnectorProfileConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowConnectorProfileConnectorProfileConfigBlock>>("connector_profile_config");
        set => SetArgument("connector_profile_config", value);
    }

}
