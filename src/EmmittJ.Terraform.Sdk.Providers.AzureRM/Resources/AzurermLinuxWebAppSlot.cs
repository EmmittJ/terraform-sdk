using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_linux_web_app_slot resource.
/// </summary>
public class AzurermLinuxWebAppSlot : TerraformResource
{
    public AzurermLinuxWebAppSlot(string name) : base("azurerm_linux_web_app_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_metadata");
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
    /// The app_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_id");
        set => this.WithProperty("app_service_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMapProperty<string>? AppSettings
    {
        get => GetProperty<TerraformMapProperty<string>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientAffinityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_affinity_enabled");
        set => this.WithProperty("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
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
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => this.WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
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
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => this.WithProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The name attribute.
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
    /// The vnet_image_pull_enabled attribute.
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
    /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.
    /// </summary>
    public TerraformProperty<string>? ZipDeployFile
    {
        get => GetProperty<TerraformProperty<string>>("zip_deploy_file");
        set => this.WithProperty("zip_deploy_file", value);
    }

    /// <summary>
    /// The app_metadata attribute.
    /// </summary>
    public TerraformExpression AppMetadata => this["app_metadata"];

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
