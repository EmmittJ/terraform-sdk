using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsFunctionAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_windows_function_app.
/// </summary>
public class AzurermWindowsFunctionAppDataSource : TerraformDataSource
{
    public AzurermWindowsFunctionAppDataSource(string name) : base("azurerm_windows_function_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_settings");
        this.WithOutput("auth_settings");
        this.WithOutput("auth_settings_v2");
        this.WithOutput("backup");
        this.WithOutput("builtin_logging_enabled");
        this.WithOutput("client_certificate_enabled");
        this.WithOutput("client_certificate_exclusion_paths");
        this.WithOutput("client_certificate_mode");
        this.WithOutput("connection_string");
        this.WithOutput("content_share_force_disabled");
        this.WithOutput("custom_domain_verification_id");
        this.WithOutput("daily_memory_time_quota");
        this.WithOutput("default_hostname");
        this.WithOutput("enabled");
        this.WithOutput("ftp_publish_basic_authentication_enabled");
        this.WithOutput("functions_extension_version");
        this.WithOutput("hosting_environment_id");
        this.WithOutput("https_only");
        this.WithOutput("identity");
        this.WithOutput("kind");
        this.WithOutput("location");
        this.WithOutput("outbound_ip_address_list");
        this.WithOutput("outbound_ip_addresses");
        this.WithOutput("possible_outbound_ip_address_list");
        this.WithOutput("possible_outbound_ip_addresses");
        this.WithOutput("public_network_access_enabled");
        this.WithOutput("service_plan_id");
        this.WithOutput("site_config");
        this.WithOutput("site_credential");
        this.WithOutput("sticky_settings");
        this.WithOutput("storage_account_access_key");
        this.WithOutput("storage_account_name");
        this.WithOutput("storage_key_vault_secret_id");
        this.WithOutput("storage_uses_managed_identity");
        this.WithOutput("tags");
        this.WithOutput("virtual_network_backup_restore_enabled");
        this.WithOutput("virtual_network_subnet_id");
        this.WithOutput("webdeploy_publish_basic_authentication_enabled");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWindowsFunctionAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWindowsFunctionAppDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
