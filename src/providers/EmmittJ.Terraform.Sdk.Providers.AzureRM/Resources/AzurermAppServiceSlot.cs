using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for auth_settings in .
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
    [TerraformArgument("additional_login_params")]
    public TerraformMap<string>? AdditionalLoginParams
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_login_params").ResolveNodes(ctx));
        set => SetArgument("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    [TerraformArgument("allowed_external_redirect_urls")]
    public TerraformList<string>? AllowedExternalRedirectUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_external_redirect_urls").ResolveNodes(ctx));
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    [TerraformArgument("default_provider")]
    public TerraformValue<string>? DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformArgument("issuer")]
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [TerraformArgument("runtime_version")]
    public TerraformValue<string>? RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    [TerraformArgument("token_refresh_extension_hours")]
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => new TerraformReference<double>(this, "token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    [TerraformArgument("token_store_enabled")]
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => new TerraformReference<bool>(this, "token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    [TerraformArgument("unauthenticated_client_action")]
    public TerraformValue<string>? UnauthenticatedClientAction
    {
        get => new TerraformReference<string>(this, "unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

}

/// <summary>
/// Block type for connection_string in .
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
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for logs in .
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
    [TerraformArgument("detailed_error_messages_enabled")]
    public TerraformValue<bool>? DetailedErrorMessagesEnabled
    {
        get => new TerraformReference<bool>(this, "detailed_error_messages_enabled");
        set => SetArgument("detailed_error_messages_enabled", value);
    }

    /// <summary>
    /// The failed_request_tracing_enabled attribute.
    /// </summary>
    [TerraformArgument("failed_request_tracing_enabled")]
    public TerraformValue<bool>? FailedRequestTracingEnabled
    {
        get => new TerraformReference<bool>(this, "failed_request_tracing_enabled");
        set => SetArgument("failed_request_tracing_enabled", value);
    }

}

/// <summary>
/// Block type for site_config in .
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
    [TerraformArgument("acr_use_managed_identity_credentials")]
    public TerraformValue<bool>? AcrUseManagedIdentityCredentials
    {
        get => new TerraformReference<bool>(this, "acr_use_managed_identity_credentials");
        set => SetArgument("acr_use_managed_identity_credentials", value);
    }

    /// <summary>
    /// The acr_user_managed_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("acr_user_managed_identity_client_id")]
    public TerraformValue<string>? AcrUserManagedIdentityClientId
    {
        get => new TerraformReference<string>(this, "acr_user_managed_identity_client_id");
        set => SetArgument("acr_user_managed_identity_client_id", value);
    }

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformArgument("always_on")]
    public TerraformValue<bool>? AlwaysOn
    {
        get => new TerraformReference<bool>(this, "always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    [TerraformArgument("app_command_line")]
    public TerraformValue<string>? AppCommandLine
    {
        get => new TerraformReference<string>(this, "app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformArgument("auto_swap_slot_name")]
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => new TerraformReference<string>(this, "auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    [TerraformArgument("default_documents")]
    public TerraformList<string>? DefaultDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "default_documents").ResolveNodes(ctx));
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformArgument("dotnet_framework_version")]
    public TerraformValue<string>? DotnetFrameworkVersion
    {
        get => new TerraformReference<string>(this, "dotnet_framework_version");
        set => SetArgument("dotnet_framework_version", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformArgument("ftps_state")]
    public TerraformValue<string> FtpsState
    {
        get => new TerraformReference<string>(this, "ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformArgument("health_check_path")]
    public TerraformValue<string>? HealthCheckPath
    {
        get => new TerraformReference<string>(this, "health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformArgument("http2_enabled")]
    public TerraformValue<bool>? Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    [TerraformArgument("ip_restriction")]
    public TerraformList<object> IpRestriction
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ip_restriction").ResolveNodes(ctx));
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    [TerraformArgument("java_container")]
    public TerraformValue<string>? JavaContainer
    {
        get => new TerraformReference<string>(this, "java_container");
        set => SetArgument("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    [TerraformArgument("java_container_version")]
    public TerraformValue<string>? JavaContainerVersion
    {
        get => new TerraformReference<string>(this, "java_container_version");
        set => SetArgument("java_container_version", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    [TerraformArgument("java_version")]
    public TerraformValue<string>? JavaVersion
    {
        get => new TerraformReference<string>(this, "java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformArgument("linux_fx_version")]
    public TerraformValue<string> LinuxFxVersion
    {
        get => new TerraformReference<string>(this, "linux_fx_version");
        set => SetArgument("linux_fx_version", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    [TerraformArgument("local_mysql_enabled")]
    public TerraformValue<bool> LocalMysqlEnabled
    {
        get => new TerraformReference<bool>(this, "local_mysql_enabled");
        set => SetArgument("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    [TerraformArgument("managed_pipeline_mode")]
    public TerraformValue<string> ManagedPipelineMode
    {
        get => new TerraformReference<string>(this, "managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformArgument("min_tls_version")]
    public TerraformValue<string> MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformArgument("number_of_workers")]
    public TerraformValue<double> NumberOfWorkers
    {
        get => new TerraformReference<double>(this, "number_of_workers");
        set => SetArgument("number_of_workers", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    [TerraformArgument("php_version")]
    public TerraformValue<string>? PhpVersion
    {
        get => new TerraformReference<string>(this, "php_version");
        set => SetArgument("php_version", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    [TerraformArgument("python_version")]
    public TerraformValue<string>? PythonVersion
    {
        get => new TerraformReference<string>(this, "python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformArgument("remote_debugging_enabled")]
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    [TerraformArgument("remote_debugging_version")]
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => new TerraformReference<string>(this, "remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    [TerraformArgument("scm_ip_restriction")]
    public TerraformList<object> ScmIpRestriction
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "scm_ip_restriction").ResolveNodes(ctx));
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformArgument("scm_type")]
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
        set => SetArgument("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformArgument("scm_use_main_ip_restriction")]
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => new TerraformReference<bool>(this, "scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    [TerraformArgument("use_32_bit_worker_process")]
    public TerraformValue<bool>? Use32BitWorkerProcess
    {
        get => new TerraformReference<bool>(this, "use_32_bit_worker_process");
        set => SetArgument("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    [TerraformArgument("vnet_route_all_enabled")]
    public TerraformValue<bool> VnetRouteAllEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformArgument("websockets_enabled")]
    public TerraformValue<bool> WebsocketsEnabled
    {
        get => new TerraformReference<bool>(this, "websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    [TerraformArgument("windows_fx_version")]
    public TerraformValue<string> WindowsFxVersion
    {
        get => new TerraformReference<string>(this, "windows_fx_version");
        set => SetArgument("windows_fx_version", value);
    }

}

/// <summary>
/// Block type for storage_account in .
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
    [TerraformArgument("access_key")]
    public required TerraformValue<string> AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformArgument("mount_path")]
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformArgument("share_name")]
    public required TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_slot resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppServiceSlot : TerraformResource
{
    public AzurermAppServiceSlot(string name) : base("azurerm_app_service_slot", name)
    {
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    [TerraformArgument("app_service_name")]
    public required TerraformValue<string> AppServiceName
    {
        get => new TerraformReference<string>(this, "app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    [TerraformArgument("app_service_plan_id")]
    public required TerraformValue<string> AppServicePlanId
    {
        get => new TerraformReference<string>(this, "app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformArgument("app_settings")]
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformArgument("client_affinity_enabled")]
    public TerraformValue<bool> ClientAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "client_affinity_enabled");
        set => SetArgument("client_affinity_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_reference_identity_id")]
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformArgument("auth_settings")]
    public TerraformList<AzurermAppServiceSlotAuthSettingsBlock> AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformSet<AzurermAppServiceSlotConnectionStringBlock> ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermAppServiceSlotIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformArgument("logs")]
    public TerraformList<AzurermAppServiceSlotLogsBlock> Logs { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformArgument("site_config")]
    public TerraformList<AzurermAppServiceSlotSiteConfigBlock> SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("storage_account")]
    public TerraformSet<AzurermAppServiceSlotStorageAccountBlock> StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceSlotTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    [TerraformArgument("default_site_hostname")]
    public TerraformValue<string> DefaultSiteHostname
    {
        get => new TerraformReference<string>(this, "default_site_hostname");
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformArgument("site_credential")]
    public TerraformList<object> SiteCredential
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "site_credential").ResolveNodes(ctx));
    }

}
