using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings";

    /// <summary>
    /// The additional_login_params attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalLoginParams
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_login_params").ResolveNodes(ctx));
        set => SetArgument("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    public TerraformList<string>? AllowedExternalRedirectUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_external_redirect_urls").ResolveNodes(ctx));
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    public TerraformValue<string>? DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => new TerraformReference<double>(this, "token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => new TerraformReference<bool>(this, "token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    public TerraformValue<string>? UnauthenticatedClientAction
    {
        get => new TerraformReference<string>(this, "unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermAppServiceAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// The allowed_audiences attribute.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_audiences").ResolveNodes(ctx));
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for facebook in AzurermAppServiceAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlockFacebookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "facebook";

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The app_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSecret is required")]
    public required TerraformValue<string> AppSecret
    {
        get => new TerraformReference<string>(this, "app_secret");
        set => SetArgument("app_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for google in AzurermAppServiceAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlockGoogleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for microsoft in AzurermAppServiceAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlockMicrosoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for twitter in AzurermAppServiceAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlockTwitterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "twitter";

    /// <summary>
    /// The consumer_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerKey is required")]
    public required TerraformValue<string> ConsumerKey
    {
        get => new TerraformReference<string>(this, "consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The consumer_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerSecret is required")]
    public required TerraformValue<string> ConsumerSecret
    {
        get => new TerraformReference<string>(this, "consumer_secret");
        set => SetArgument("consumer_secret", value);
    }

}


/// <summary>
/// Block type for backup in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    public required TerraformValue<string> StorageAccountUrl
    {
        get => new TerraformReference<string>(this, "storage_account_url");
        set => SetArgument("storage_account_url", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AzurermAppServiceBackupBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermAppServiceBackupBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermAppServiceBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceBackupBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The frequency_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyInterval is required")]
    public required TerraformValue<double> FrequencyInterval
    {
        get => new TerraformReference<double>(this, "frequency_interval");
        set => SetArgument("frequency_interval", value);
    }

    /// <summary>
    /// The frequency_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyUnit is required")]
    public required TerraformValue<string> FrequencyUnit
    {
        get => new TerraformReference<string>(this, "frequency_unit");
        set => SetArgument("frequency_unit", value);
    }

    /// <summary>
    /// The keep_at_least_one_backup attribute.
    /// </summary>
    public TerraformValue<bool>? KeepAtLeastOneBackup
    {
        get => new TerraformReference<bool>(this, "keep_at_least_one_backup");
        set => SetArgument("keep_at_least_one_backup", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "retention_period_in_days");
        set => SetArgument("retention_period_in_days", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermAppService.
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_string";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The detailed_error_messages_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DetailedErrorMessagesEnabled
    {
        get => new TerraformReference<bool>(this, "detailed_error_messages_enabled");
        set => SetArgument("detailed_error_messages_enabled", value);
    }

    /// <summary>
    /// The failed_request_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FailedRequestTracingEnabled
    {
        get => new TerraformReference<bool>(this, "failed_request_tracing_enabled");
        set => SetArgument("failed_request_tracing_enabled", value);
    }

    /// <summary>
    /// ApplicationLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationLogs block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlockApplicationLogsBlock>? ApplicationLogs
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlockApplicationLogsBlock>>("application_logs");
        set => SetArgument("application_logs", value);
    }

    /// <summary>
    /// HttpLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpLogs block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlockHttpLogsBlock>? HttpLogs
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlockHttpLogsBlock>>("http_logs");
        set => SetArgument("http_logs", value);
    }

}

/// <summary>
/// Block type for application_logs in AzurermAppServiceLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlockApplicationLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_logs";

    /// <summary>
    /// The file_system_level attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemLevel
    {
        get => new TerraformReference<string>(this, "file_system_level");
        set => SetArgument("file_system_level", value);
    }

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlockApplicationLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlockApplicationLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermAppServiceLogsBlockApplicationLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlockApplicationLogsBlockAzureBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage";

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    public required TerraformValue<string> Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => new TerraformReference<string>(this, "sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for http_logs in AzurermAppServiceLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlockHttpLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_logs";

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlockHttpLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlockHttpLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

    /// <summary>
    /// FileSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystem block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlockHttpLogsBlockFileSystemBlock>? FileSystem
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlockHttpLogsBlockFileSystemBlock>>("file_system");
        set => SetArgument("file_system", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermAppServiceLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlockHttpLogsBlockAzureBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage";

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => new TerraformReference<string>(this, "sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for file_system in AzurermAppServiceLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlockHttpLogsBlockFileSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system";

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The retention_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInMb is required")]
    public required TerraformValue<double> RetentionInMb
    {
        get => new TerraformReference<double>(this, "retention_in_mb");
        set => SetArgument("retention_in_mb", value);
    }

}


/// <summary>
/// Block type for site_config in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_config";

    /// <summary>
    /// The acr_use_managed_identity_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? AcrUseManagedIdentityCredentials
    {
        get => new TerraformReference<bool>(this, "acr_use_managed_identity_credentials");
        set => SetArgument("acr_use_managed_identity_credentials", value);
    }

    /// <summary>
    /// The acr_user_managed_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? AcrUserManagedIdentityClientId
    {
        get => new TerraformReference<string>(this, "acr_user_managed_identity_client_id");
        set => SetArgument("acr_user_managed_identity_client_id", value);
    }

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformValue<bool>? AlwaysOn
    {
        get => new TerraformReference<bool>(this, "always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => new TerraformReference<string>(this, "app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => new TerraformReference<string>(this, "auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    public TerraformList<string>? DefaultDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "default_documents").ResolveNodes(ctx));
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformValue<string>? DotnetFrameworkVersion
    {
        get => new TerraformReference<string>(this, "dotnet_framework_version");
        set => SetArgument("dotnet_framework_version", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformValue<string> FtpsState
    {
        get => new TerraformReference<string>(this, "ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => new TerraformReference<string>(this, "health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpRestriction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_restriction").ResolveNodes(ctx));
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    public TerraformValue<string>? JavaContainer
    {
        get => new TerraformReference<string>(this, "java_container");
        set => SetArgument("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaContainerVersion
    {
        get => new TerraformReference<string>(this, "java_container_version");
        set => SetArgument("java_container_version", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaVersion
    {
        get => new TerraformReference<string>(this, "java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformValue<string> LinuxFxVersion
    {
        get => new TerraformReference<string>(this, "linux_fx_version");
        set => SetArgument("linux_fx_version", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalMysqlEnabled
    {
        get => new TerraformReference<bool>(this, "local_mysql_enabled");
        set => SetArgument("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    public TerraformValue<string> ManagedPipelineMode
    {
        get => new TerraformReference<string>(this, "managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string> MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformValue<double> NumberOfWorkers
    {
        get => new TerraformReference<double>(this, "number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    public TerraformValue<string>? PhpVersion
    {
        get => new TerraformReference<string>(this, "php_version");
        set => SetArgument("php_version", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformValue<string>? PythonVersion
    {
        get => new TerraformReference<string>(this, "python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => new TerraformReference<string>(this, "remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScmIpRestriction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scm_ip_restriction").ResolveNodes(ctx));
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
        set => SetArgument("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => new TerraformReference<bool>(this, "scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformValue<bool>? Use32BitWorkerProcess
    {
        get => new TerraformReference<bool>(this, "use_32_bit_worker_process");
        set => SetArgument("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    public TerraformValue<bool> VnetRouteAllEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformValue<bool> WebsocketsEnabled
    {
        get => new TerraformReference<bool>(this, "websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    public TerraformValue<string> WindowsFxVersion
    {
        get => new TerraformReference<string>(this, "windows_fx_version");
        set => SetArgument("windows_fx_version", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermAppServiceSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermAppServiceSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

}

/// <summary>
/// Block type for cors in AzurermAppServiceSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSiteConfigBlockCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The support_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? SupportCredentials
    {
        get => new TerraformReference<bool>(this, "support_credentials");
        set => SetArgument("support_credentials", value);
    }

}


/// <summary>
/// Block type for source_control in AzurermAppService.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_control";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string> Branch
    {
        get => new TerraformReference<string>(this, "branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    public TerraformValue<bool> ManualIntegration
    {
        get => new TerraformReference<bool>(this, "manual_integration");
        set => SetArgument("manual_integration", value);
    }

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    public TerraformValue<string> RepoUrl
    {
        get => new TerraformReference<string>(this, "repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RollbackEnabled
    {
        get => new TerraformReference<bool>(this, "rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    public TerraformValue<bool> UseMercurial
    {
        get => new TerraformReference<bool>(this, "use_mercurial");
        set => SetArgument("use_mercurial", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermAppService.
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    public required TerraformValue<string> AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppService.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_app_service Terraform resource.
/// Manages a azurerm_app_service resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppService(string name) : TerraformResource("azurerm_app_service", name)
{
    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformValue<string> AppServicePlanId
    {
        get => new TerraformReference<string>(this, "app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "client_affinity_enabled");
        set => SetArgument("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertEnabled
    {
        get => new TerraformReference<bool>(this, "client_cert_enabled");
        set => SetArgument("client_cert_enabled", value);
    }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformValue<string> ClientCertMode
    {
        get => new TerraformReference<string>(this, "client_cert_mode");
        set => SetArgument("client_cert_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultSiteHostname
    {
        get => new TerraformReference<string>(this, "default_site_hostname");
    }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "outbound_ip_addresses");
    }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "possible_outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "possible_outbound_ip_addresses");
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "site_credential").ResolveNodes(ctx));
    }

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermAppServiceAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermAppServiceAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermAppServiceBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermAppServiceBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermAppServiceConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermAppServiceConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermAppServiceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermAppServiceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AzurermAppServiceLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermAppServiceLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public TerraformList<AzurermAppServiceSiteConfigBlock>? SiteConfig
    {
        get => GetArgument<TerraformList<AzurermAppServiceSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// SourceControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    public TerraformList<AzurermAppServiceSourceControlBlock>? SourceControl
    {
        get => GetArgument<TerraformList<AzurermAppServiceSourceControlBlock>>("source_control");
        set => SetArgument("source_control", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermAppServiceStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformSet<AzurermAppServiceStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
