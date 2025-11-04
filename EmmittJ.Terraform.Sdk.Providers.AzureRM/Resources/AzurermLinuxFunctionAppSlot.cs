using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_linux_function_app_slot resource.
/// </summary>
public class AzurermLinuxFunctionAppSlot : TerraformResource
{
    public AzurermLinuxFunctionAppSlot(string name) : base("azurerm_linux_function_app_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("hosting_environment_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    public bool? BuiltinLoggingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("builtin_logging_enabled")?.Value;
        set => this.WithProperty("builtin_logging_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    public bool? ClientCertificateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_certificate_enabled")?.Value;
        set => this.WithProperty("client_certificate_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public string? ClientCertificateExclusionPaths
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_exclusion_paths")?.Value;
        set => this.WithProperty("client_certificate_exclusion_paths", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    public string? ClientCertificateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_mode")?.Value;
        set => this.WithProperty("client_certificate_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    public bool? ContentShareForceDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("content_share_force_disabled")?.Value;
        set => this.WithProperty("content_share_force_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    public double? DailyMemoryTimeQuota
    {
        get => GetProperty<TerraformLiteralProperty<double>>("daily_memory_time_quota")?.Value;
        set => this.WithProperty("daily_memory_time_quota", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Is the Linux Function App Slot enabled.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public bool? FtpPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ftp_publish_basic_authentication_enabled")?.Value;
        set => this.WithProperty("ftp_publish_basic_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ID of the Linux Function App this Slot is a member of.
    /// </summary>
    public string? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id")?.Value;
        set => this.WithProperty("function_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    public string? FunctionsExtensionVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("functions_extension_version")?.Value;
        set => this.WithProperty("functions_extension_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    public string? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_reference_identity_id")?.Value;
        set => this.WithProperty("key_vault_reference_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the name of the Function App Slot.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public string? ServicePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_plan_id")?.Value;
        set => this.WithProperty("service_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    public string? StorageAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_access_key")?.Value;
        set => this.WithProperty("storage_account_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    public string? StorageKeyVaultSecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_key_vault_secret_id")?.Value;
        set => this.WithProperty("storage_key_vault_secret_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    public bool? StorageUsesManagedIdentity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_uses_managed_identity")?.Value;
        set => this.WithProperty("storage_uses_managed_identity", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public bool? VirtualNetworkBackupRestoreEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("virtual_network_backup_restore_enabled")?.Value;
        set => this.WithProperty("virtual_network_backup_restore_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public string? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_subnet_id")?.Value;
        set => this.WithProperty("virtual_network_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    public bool? VnetImagePullEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vnet_image_pull_enabled")?.Value;
        set => this.WithProperty("vnet_image_pull_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public bool? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("webdeploy_publish_basic_authentication_enabled")?.Value;
        set => this.WithProperty("webdeploy_publish_basic_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

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
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}
