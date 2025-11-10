using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxFunctionAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_linux_function_app.
/// </summary>
public class AzurermLinuxFunctionAppDataSource : TerraformDataSource
{
    public AzurermLinuxFunctionAppDataSource(string name) : base("azurerm_linux_function_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_settings");
        SetOutput("auth_settings");
        SetOutput("auth_settings_v2");
        SetOutput("availability");
        SetOutput("backup");
        SetOutput("builtin_logging_enabled");
        SetOutput("client_certificate_enabled");
        SetOutput("client_certificate_exclusion_paths");
        SetOutput("client_certificate_mode");
        SetOutput("connection_string");
        SetOutput("content_share_force_disabled");
        SetOutput("custom_domain_verification_id");
        SetOutput("daily_memory_time_quota");
        SetOutput("default_hostname");
        SetOutput("enabled");
        SetOutput("ftp_publish_basic_authentication_enabled");
        SetOutput("functions_extension_version");
        SetOutput("hosting_environment_id");
        SetOutput("https_only");
        SetOutput("identity");
        SetOutput("kind");
        SetOutput("location");
        SetOutput("outbound_ip_address_list");
        SetOutput("outbound_ip_addresses");
        SetOutput("possible_outbound_ip_address_list");
        SetOutput("possible_outbound_ip_addresses");
        SetOutput("public_network_access_enabled");
        SetOutput("service_plan_id");
        SetOutput("site_config");
        SetOutput("site_credential");
        SetOutput("sticky_settings");
        SetOutput("storage_account_access_key");
        SetOutput("storage_account_name");
        SetOutput("storage_key_vault_secret_id");
        SetOutput("storage_uses_managed_identity");
        SetOutput("tags");
        SetOutput("usage");
        SetOutput("virtual_network_backup_restore_enabled");
        SetOutput("virtual_network_subnet_id");
        SetOutput("webdeploy_publish_basic_authentication_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLinuxFunctionAppDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformExpression AppSettings => this["app_settings"];

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    public TerraformExpression AuthSettings => this["auth_settings"];

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    public TerraformExpression AuthSettingsV2 => this["auth_settings_v2"];

    /// <summary>
    /// The availability attribute.
    /// </summary>
    public TerraformExpression Availability => this["availability"];

    /// <summary>
    /// The backup attribute.
    /// </summary>
    public TerraformExpression Backup => this["backup"];

    /// <summary>
    /// The builtin_logging_enabled attribute.
    /// </summary>
    public TerraformExpression BuiltinLoggingEnabled => this["builtin_logging_enabled"];

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformExpression ClientCertificateEnabled => this["client_certificate_enabled"];

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformExpression ClientCertificateExclusionPaths => this["client_certificate_exclusion_paths"];

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformExpression ClientCertificateMode => this["client_certificate_mode"];

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformExpression ConnectionString => this["connection_string"];

    /// <summary>
    /// The content_share_force_disabled attribute.
    /// </summary>
    public TerraformExpression ContentShareForceDisabled => this["content_share_force_disabled"];

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformExpression DailyMemoryTimeQuota => this["daily_memory_time_quota"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression FtpPublishBasicAuthenticationEnabled => this["ftp_publish_basic_authentication_enabled"];

    /// <summary>
    /// The functions_extension_version attribute.
    /// </summary>
    public TerraformExpression FunctionsExtensionVersion => this["functions_extension_version"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformExpression HttpsOnly => this["https_only"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformExpression ServicePlanId => this["service_plan_id"];

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformExpression SiteConfig => this["site_config"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    public TerraformExpression StickySettings => this["sticky_settings"];

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformExpression StorageAccountAccessKey => this["storage_account_access_key"];

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformExpression StorageAccountName => this["storage_account_name"];

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String used to connect to the storage account for this Function App.
    /// </summary>
    public TerraformExpression StorageKeyVaultSecretId => this["storage_key_vault_secret_id"];

    /// <summary>
    /// The storage_uses_managed_identity attribute.
    /// </summary>
    public TerraformExpression StorageUsesManagedIdentity => this["storage_uses_managed_identity"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The usage attribute.
    /// </summary>
    public TerraformExpression Usage => this["usage"];

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkBackupRestoreEnabled => this["virtual_network_backup_restore_enabled"];

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkSubnetId => this["virtual_network_subnet_id"];

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression WebdeployPublishBasicAuthenticationEnabled => this["webdeploy_publish_basic_authentication_enabled"];

}
