using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_windows_web_app.
/// </summary>
public class AzurermWindowsWebAppDataSource : TerraformDataSource
{
    public AzurermWindowsWebAppDataSource(string name) : base("azurerm_windows_web_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_settings");
        this.DeclareOutput("auth_settings");
        this.DeclareOutput("auth_settings_v2");
        this.DeclareOutput("backup");
        this.DeclareOutput("client_affinity_enabled");
        this.DeclareOutput("client_certificate_enabled");
        this.DeclareOutput("client_certificate_exclusion_paths");
        this.DeclareOutput("client_certificate_mode");
        this.DeclareOutput("connection_string");
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("enabled");
        this.DeclareOutput("ftp_publish_basic_authentication_enabled");
        this.DeclareOutput("hosting_environment_id");
        this.DeclareOutput("https_only");
        this.DeclareOutput("identity");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("logs");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("service_plan_id");
        this.DeclareOutput("site_config");
        this.DeclareOutput("site_credential");
        this.DeclareOutput("sticky_settings");
        this.DeclareOutput("storage_account");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_network_backup_restore_enabled");
        this.DeclareOutput("virtual_network_subnet_id");
        this.DeclareOutput("webdeploy_publish_basic_authentication_enabled");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformExpression ClientAffinityEnabled => this["client_affinity_enabled"];

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
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

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
    /// The logs attribute.
    /// </summary>
    public TerraformExpression Logs => this["logs"];

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
    /// The storage_account attribute.
    /// </summary>
    public TerraformExpression StorageAccount => this["storage_account"];

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
