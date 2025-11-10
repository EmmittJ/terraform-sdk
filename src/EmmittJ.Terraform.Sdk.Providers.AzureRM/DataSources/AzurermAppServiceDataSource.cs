using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_app_service.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermAppServiceDataSource : TerraformDataSource
{
    public AzurermAppServiceDataSource(string name) : base("azurerm_app_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_plan_id");
        this.DeclareOutput("app_settings");
        this.DeclareOutput("client_affinity_enabled");
        this.DeclareOutput("client_cert_enabled");
        this.DeclareOutput("connection_string");
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_site_hostname");
        this.DeclareOutput("enabled");
        this.DeclareOutput("https_only");
        this.DeclareOutput("location");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_config");
        this.DeclareOutput("site_credential");
        this.DeclareOutput("source_control");
        this.DeclareOutput("tags");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformExpression AppServicePlanId => this["app_service_plan_id"];

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformExpression AppSettings => this["app_settings"];

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformExpression ClientAffinityEnabled => this["client_affinity_enabled"];

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    public TerraformExpression ClientCertEnabled => this["client_cert_enabled"];

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformExpression ConnectionString => this["connection_string"];

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultSiteHostname => this["default_site_hostname"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformExpression HttpsOnly => this["https_only"];

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
    /// The site_config attribute.
    /// </summary>
    public TerraformExpression SiteConfig => this["site_config"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

    /// <summary>
    /// The source_control attribute.
    /// </summary>
    public TerraformExpression SourceControl => this["source_control"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
