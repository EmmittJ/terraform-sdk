using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_windows_function_app_slot resource.
/// </summary>
public class AzurermWindowsFunctionAppSlot : TerraformResource
{
    public AzurermWindowsFunctionAppSlot(string name) : base("azurerm_windows_function_app_slot", name)
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
    public TerraformProperty<Dictionary<string, string>>? AppSettings
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    public TerraformProperty<bool>? BuiltinLoggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("builtin_logging_enabled");
        set => this.WithProperty("builtin_logging_enabled", value);
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    public TerraformProperty<bool>? ClientCertificateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_certificate_enabled");
        set => this.WithProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformProperty<string>? ClientCertificateExclusionPaths
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_exclusion_paths");
        set => this.WithProperty("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => this.WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    public TerraformProperty<bool>? ContentShareForceDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("content_share_force_disabled");
        set => this.WithProperty("content_share_force_disabled", value);
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    public TerraformProperty<double>? DailyMemoryTimeQuota
    {
        get => GetProperty<TerraformProperty<double>>("daily_memory_time_quota");
        set => this.WithProperty("daily_memory_time_quota", value);
    }

    /// <summary>
    /// Is the Windows Function App Slot enabled.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ftp_publish_basic_authentication_enabled");
        set => this.WithProperty("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The ID of the Windows Function App this Slot is a member of.
    /// </summary>
    public TerraformProperty<string>? FunctionAppId
    {
        get => GetProperty<TerraformProperty<string>>("function_app_id");
        set => this.WithProperty("function_app_id", value);
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    public TerraformProperty<string>? FunctionsExtensionVersion
    {
        get => GetProperty<TerraformProperty<string>>("functions_extension_version");
        set => this.WithProperty("functions_extension_version", value);
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    public TerraformProperty<string>? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => this.WithProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// Specifies the name of the Windows Function App Slot.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("service_plan_id");
        set => this.WithProperty("service_plan_id", value);
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    public TerraformProperty<string>? StorageKeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("storage_key_vault_secret_id");
        set => this.WithProperty("storage_key_vault_secret_id", value);
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    public TerraformProperty<bool>? StorageUsesManagedIdentity
    {
        get => GetProperty<TerraformProperty<bool>>("storage_uses_managed_identity");
        set => this.WithProperty("storage_uses_managed_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualNetworkBackupRestoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("virtual_network_backup_restore_enabled");
        set => this.WithProperty("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_subnet_id");
        set => this.WithProperty("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? VnetImagePullEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_image_pull_enabled");
        set => this.WithProperty("vnet_image_pull_enabled", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => this.WithProperty("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default hostname of the Windows Function App Slot.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The Kind value for this Windows Function App Slot.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// A list of outbound IP addresses. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;,&amp;quot;52.143.43.17&amp;quot;]`.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}
