using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_linux_web_app resource.
/// </summary>
public class AzurermLinuxWebApp : TerraformResource
{
    public AzurermLinuxWebApp(string name) : base("azurerm_linux_web_app", name)
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
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public bool? ClientAffinityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_affinity_enabled")?.Value;
        set => this.WithProperty("client_affinity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
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
    /// The client_certificate_mode attribute.
    /// </summary>
    public string? ClientCertificateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_mode")?.Value;
        set => this.WithProperty("client_certificate_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
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
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public string? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_reference_identity_id")?.Value;
        set => this.WithProperty("key_vault_reference_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vnet_image_pull_enabled attribute.
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
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    public string? ZipDeployFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zip_deploy_file")?.Value;
        set => this.WithProperty("zip_deploy_file", value == null ? null : new TerraformLiteralProperty<string>(value));
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
