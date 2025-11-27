using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in GoogleApihubPluginInstance.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// This should map to one of the action id specified
    /// in actions_config in the plugin.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    public required TerraformValue<string> ActionId
    {
        get => new TerraformReference<string>(this, "action_id");
        set => SetArgument("action_id", value);
    }

    /// <summary>
    /// The execution status for the plugin instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> HubInstanceAction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hub_instance_action").ResolveNodes(ctx));
    }

    /// <summary>
    /// The schedule for this plugin instance action. This can only be set if the
    /// plugin supports API_HUB_SCHEDULE_TRIGGER mode for this action.
    /// </summary>
    public TerraformValue<string> ScheduleCronExpression
    {
        get => new TerraformReference<string>(this, "schedule_cron_expression");
        set => SetArgument("schedule_cron_expression", value);
    }

    /// <summary>
    /// The time zone for the schedule cron expression. If not provided, UTC will
    /// be used.
    /// </summary>
    public TerraformValue<string> ScheduleTimeZone
    {
        get => new TerraformReference<string>(this, "schedule_time_zone");
        set => SetArgument("schedule_time_zone", value);
    }

    /// <summary>
    /// The current state of the plugin action in the plugin instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// ENABLING
    /// DISABLING
    /// ERROR
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// CurationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CurationConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceActionsBlockCurationConfigBlock>? CurationConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceActionsBlockCurationConfigBlock>>("curation_config");
        set => SetArgument("curation_config", value);
    }

}

/// <summary>
/// Block type for curation_config in GoogleApihubPluginInstanceActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceActionsBlockCurationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "curation_config";

    /// <summary>
    /// Possible values:
    /// CURATION_TYPE_UNSPECIFIED
    /// DEFAULT_CURATION_FOR_API_METADATA
    /// CUSTOM_CURATION_FOR_API_METADATA
    /// </summary>
    public TerraformValue<string> CurationType
    {
        get => new TerraformReference<string>(this, "curation_type");
        set => SetArgument("curation_type", value);
    }

    /// <summary>
    /// CustomCuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomCuration block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceActionsBlockCurationConfigBlockCustomCurationBlock>? CustomCuration
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceActionsBlockCurationConfigBlockCustomCurationBlock>>("custom_curation");
        set => SetArgument("custom_curation", value);
    }

}

/// <summary>
/// Block type for custom_curation in GoogleApihubPluginInstanceActionsBlockCurationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceActionsBlockCurationConfigBlockCustomCurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_curation";

    /// <summary>
    /// The unique name of the curation resource. This will be the name of the
    /// curation resource in the format:
    /// &#39;projects/{project}/locations/{location}/curations/{curation}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Curation is required")]
    public required TerraformValue<string> Curation
    {
        get => new TerraformReference<string>(this, "curation");
        set => SetArgument("curation", value);
    }

}


/// <summary>
/// Block type for auth_config in GoogleApihubPluginInstance.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_config";

    /// <summary>
    /// Possible values:
    /// AUTH_TYPE_UNSPECIFIED
    /// NO_AUTH
    /// GOOGLE_SERVICE_ACCOUNT
    /// USER_PASSWORD
    /// API_KEY
    /// OAUTH2_CLIENT_CREDENTIALS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => new TerraformReference<string>(this, "auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// ApiKeyConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKeyConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlock>? ApiKeyConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlock>>("api_key_config");
        set => SetArgument("api_key_config", value);
    }

    /// <summary>
    /// GoogleServiceAccountConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleServiceAccountConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlockGoogleServiceAccountConfigBlock>? GoogleServiceAccountConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockGoogleServiceAccountConfigBlock>>("google_service_account_config");
        set => SetArgument("google_service_account_config", value);
    }

    /// <summary>
    /// Oauth2ClientCredentialsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oauth2ClientCredentialsConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlock>? Oauth2ClientCredentialsConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlock>>("oauth2_client_credentials_config");
        set => SetArgument("oauth2_client_credentials_config", value);
    }

    /// <summary>
    /// UserPasswordConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPasswordConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlock>? UserPasswordConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlock>>("user_password_config");
        set => SetArgument("user_password_config", value);
    }

}

/// <summary>
/// Block type for api_key_config in GoogleApihubPluginInstanceAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key_config";

    /// <summary>
    /// The location of the API key.
    /// The default value is QUERY.
    /// Possible values:
    /// HTTP_ELEMENT_LOCATION_UNSPECIFIED
    /// QUERY
    /// HEADER
    /// PATH
    /// BODY
    /// COOKIE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpElementLocation is required")]
    public required TerraformValue<string> HttpElementLocation
    {
        get => new TerraformReference<string>(this, "http_element_location");
        set => SetArgument("http_element_location", value);
    }

    /// <summary>
    /// The parameter name of the API key.
    /// E.g. If the API request is &amp;quot;https://example.com/act?api_key=&amp;quot;,
    /// &amp;quot;api_key&amp;quot; would be the parameter name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ApiKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApiKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiKey block(s) allowed")]
    public required TerraformList<GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlockApiKeyBlock> ApiKey
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlockApiKeyBlock>>("api_key");
        set => SetArgument("api_key", value);
    }

}

/// <summary>
/// Block type for api_key in GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockApiKeyConfigBlockApiKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for google_service_account_config in GoogleApihubPluginInstanceAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockGoogleServiceAccountConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_service_account_config";

    /// <summary>
    /// The service account to be used for authenticating request.
    /// 
    /// The &#39;iam.serviceAccounts.getAccessToken&#39; permission should be granted on
    /// this service account to the impersonator service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for oauth2_client_credentials_config in GoogleApihubPluginInstanceAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_client_credentials_config";

    /// <summary>
    /// The client identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// ClientSecret block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientSecret block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientSecret block(s) allowed")]
    public required TerraformList<GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlockClientSecretBlock> ClientSecret
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlockClientSecretBlock>>("client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for client_secret in GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockOauth2ClientCredentialsConfigBlockClientSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_secret";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for user_password_config in GoogleApihubPluginInstanceAuthConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_password_config";

    /// <summary>
    /// Username.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// Password block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password block(s) allowed")]
    public required TerraformList<GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlockPasswordBlock> Password
    {
        get => GetRequiredArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlockPasswordBlock>>("password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for password in GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlockUserPasswordConfigBlockPasswordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password";

    /// <summary>
    /// The resource name of the secret version in the format,
    /// format as: &#39;projects/*/secrets/*/versions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApihubPluginInstance.
/// Nesting mode: single
/// </summary>
public class GoogleApihubPluginInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apihub_plugin_instance Terraform resource.
/// Manages a google_apihub_plugin_instance resource.
/// </summary>
public partial class GoogleApihubPluginInstance(string name) : TerraformResource("google_apihub_plugin_instance", name)
{
    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    public TerraformValue<bool>? Disable
    {
        get => new TerraformReference<bool>(this, "disable");
        set => SetArgument("disable", value);
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    public required TerraformValue<string> Plugin
    {
        get => new TerraformReference<string>(this, "plugin");
        set => SetArgument("plugin", value);
    }

    /// <summary>
    /// The ID to use for the plugin instance, which will become the final
    /// component of the plugin instance&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified id is already used by another plugin instance in the plugin
    /// resource.
    /// * If not provided, a system generated id will be used.
    /// 
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z[0-9]-_/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PluginInstanceId is required")]
    public required TerraformValue<string> PluginInstanceId
    {
        get => new TerraformReference<string>(this, "plugin_instance_id");
        set => SetArgument("plugin_instance_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timestamp indicating when the plugin instance was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Error message describing the failure, if any, during Create, Delete or
    /// ApplyConfig operation corresponding to the plugin instance.This field will
    /// only be populated if the plugin instance is in the ERROR or FAILED state.
    /// </summary>
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// Identifier. The unique name of the plugin instance resource.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The current state of the plugin instance (e.g., enabled, disabled,
    /// provisioning).
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// APPLYING_CONFIG
    /// ERROR
    /// FAILED
    /// DELETING
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timestamp indicating when the plugin instance was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Actions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApihubPluginInstanceActionsBlock>? Actions
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// AuthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlock>? AuthConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginInstanceAuthConfigBlock>>("auth_config");
        set => SetArgument("auth_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApihubPluginInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApihubPluginInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
