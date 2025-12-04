using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermAppServiceSlot.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformMap<string>>("additional_login_params");
        set => SetArgument("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    public TerraformList<string>? AllowedExternalRedirectUrls
    {
        get => GetArgument<TerraformList<string>>("allowed_external_redirect_urls");
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    public TerraformValue<string>? DefaultProvider
    {
        get => GetArgument<TerraformValue<string>>("default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => GetArgument<TerraformValue<double>>("token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    public TerraformValue<string>? UnauthenticatedClientAction
    {
        get => GetArgument<TerraformValue<string>>("unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermAppServiceSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
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

}

/// <summary>
/// Block type for facebook in AzurermAppServiceSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlockFacebookBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The app_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSecret is required")]
    public required TerraformValue<string> AppSecret
    {
        get => GetArgument<TerraformValue<string>>("app_secret");
        set => SetArgument("app_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for google in AzurermAppServiceSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlockGoogleBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for microsoft in AzurermAppServiceSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlockMicrosoftBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for twitter in AzurermAppServiceSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotAuthSettingsBlockTwitterBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The consumer_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerSecret is required")]
    public required TerraformValue<string> ConsumerSecret
    {
        get => GetArgument<TerraformValue<string>>("consumer_secret");
        set => SetArgument("consumer_secret", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermAppServiceSlot.
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceSlotConnectionStringBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermAppServiceSlot.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs in AzurermAppServiceSlot.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("detailed_error_messages_enabled");
        set => SetArgument("detailed_error_messages_enabled", value);
    }

    /// <summary>
    /// The failed_request_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FailedRequestTracingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("failed_request_tracing_enabled");
        set => SetArgument("failed_request_tracing_enabled", value);
    }

    /// <summary>
    /// ApplicationLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationLogs block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlockApplicationLogsBlock>? ApplicationLogs
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlockApplicationLogsBlock>>("application_logs");
        set => SetArgument("application_logs", value);
    }

    /// <summary>
    /// HttpLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpLogs block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlock>? HttpLogs
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlock>>("http_logs");
        set => SetArgument("http_logs", value);
    }

}

/// <summary>
/// Block type for application_logs in AzurermAppServiceSlotLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlockApplicationLogsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("file_system_level");
        set => SetArgument("file_system_level", value);
    }

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermAppServiceSlotLogsBlockApplicationLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => GetArgument<TerraformValue<string>>("sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for http_logs in AzurermAppServiceSlotLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlockHttpLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_logs";

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

    /// <summary>
    /// FileSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystem block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlockFileSystemBlock>? FileSystem
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlockHttpLogsBlockFileSystemBlock>>("file_system");
        set => SetArgument("file_system", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermAppServiceSlotLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => GetArgument<TerraformValue<string>>("sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for file_system in AzurermAppServiceSlotLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotLogsBlockHttpLogsBlockFileSystemBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The retention_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInMb is required")]
    public required TerraformValue<double> RetentionInMb
    {
        get => GetArgument<TerraformValue<double>>("retention_in_mb");
        set => SetArgument("retention_in_mb", value);
    }

}


/// <summary>
/// Block type for site_config in AzurermAppServiceSlot.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotSiteConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("acr_use_managed_identity_credentials");
        set => SetArgument("acr_use_managed_identity_credentials", value);
    }

    /// <summary>
    /// The acr_user_managed_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? AcrUserManagedIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("acr_user_managed_identity_client_id");
        set => SetArgument("acr_user_managed_identity_client_id", value);
    }

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformValue<bool>? AlwaysOn
    {
        get => GetArgument<TerraformValue<bool>>("always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => GetArgument<TerraformValue<string>>("app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => GetArgument<TerraformValue<string>>("auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    public TerraformList<string>? DefaultDocuments
    {
        get => GetArgument<TerraformList<string>>("default_documents");
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformValue<string>? DotnetFrameworkVersion
    {
        get => GetArgument<TerraformValue<string>>("dotnet_framework_version");
        set => SetArgument("dotnet_framework_version", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformValue<string>? FtpsState
    {
        get => GetArgument<TerraformValue<string>>("ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => GetArgument<TerraformValue<string>>("health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? IpRestriction
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("ip_restriction");
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    public TerraformValue<string>? JavaContainer
    {
        get => GetArgument<TerraformValue<string>>("java_container");
        set => SetArgument("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaContainerVersion
    {
        get => GetArgument<TerraformValue<string>>("java_container_version");
        set => SetArgument("java_container_version", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaVersion
    {
        get => GetArgument<TerraformValue<string>>("java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformValue<string>? LinuxFxVersion
    {
        get => GetArgument<TerraformValue<string>>("linux_fx_version");
        set => SetArgument("linux_fx_version", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalMysqlEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_mysql_enabled");
        set => SetArgument("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => GetArgument<TerraformValue<string>>("managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfWorkers
    {
        get => GetArgument<TerraformValue<double>>("number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    public TerraformValue<string>? PhpVersion
    {
        get => GetArgument<TerraformValue<string>>("php_version");
        set => SetArgument("php_version", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformValue<string>? PythonVersion
    {
        get => GetArgument<TerraformValue<string>>("python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    public TerraformValue<string>? RemoteDebuggingVersion
    {
        get => GetArgument<TerraformValue<string>>("remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? ScmIpRestriction
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("scm_ip_restriction");
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformValue<string>? ScmType
    {
        get => GetArgument<TerraformValue<string>>("scm_type");
        set => SetArgument("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => GetArgument<TerraformValue<bool>>("scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformValue<bool>? Use32BitWorkerProcess
    {
        get => GetArgument<TerraformValue<bool>>("use_32_bit_worker_process");
        set => SetArgument("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VnetRouteAllEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    public TerraformValue<string>? WindowsFxVersion
    {
        get => GetArgument<TerraformValue<string>>("windows_fx_version");
        set => SetArgument("windows_fx_version", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

}

/// <summary>
/// Block type for cors in AzurermAppServiceSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSlotSiteConfigBlockCorsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The support_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? SupportCredentials
    {
        get => GetArgument<TerraformValue<bool>>("support_credentials");
        set => SetArgument("support_credentials", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermAppServiceSlot.
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceSlotStorageAccountBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
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
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => GetArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppServiceSlot.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSlotTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_slot Terraform resource.
/// Manages a azurerm_app_service_slot resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServiceSlot(string name) : TerraformResource("azurerm_app_service_slot", name)
{
    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformValue<string> AppServiceName
    {
        get => GetArgument<TerraformValue<string>>("app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformValue<string> AppServicePlanId
    {
        get => GetArgument<TerraformValue<string>>("app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => GetArgument<TerraformMap<string>>("app_settings");
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientAffinityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_affinity_enabled");
        set => SetArgument("client_affinity_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => GetArgument<TerraformValue<bool>>("https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultReferenceIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultSiteHostname
        => AsReference("default_site_hostname");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => AsReference("site_credential");

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermAppServiceSlotConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermAppServiceSlotConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public TerraformList<AzurermAppServiceSlotSiteConfigBlock>? SiteConfig
    {
        get => GetArgument<TerraformList<AzurermAppServiceSlotSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermAppServiceSlotStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformSet<AzurermAppServiceSlotStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
