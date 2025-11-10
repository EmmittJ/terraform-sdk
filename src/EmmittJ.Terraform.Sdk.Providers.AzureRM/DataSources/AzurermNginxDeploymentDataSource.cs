using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxDeploymentDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_nginx_deployment.
/// </summary>
public class AzurermNginxDeploymentDataSource : TerraformDataSource
{
    public AzurermNginxDeploymentDataSource(string name) : base("azurerm_nginx_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("auto_scale_profile");
        this.DeclareOutput("automatic_upgrade_channel");
        this.DeclareOutput("capacity");
        this.DeclareOutput("dataplane_api_endpoint");
        this.DeclareOutput("diagnose_support_enabled");
        this.DeclareOutput("email");
        this.DeclareOutput("frontend_private");
        this.DeclareOutput("frontend_public");
        this.DeclareOutput("identity");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("location");
        this.DeclareOutput("logging_storage_account");
        this.DeclareOutput("managed_resource_group");
        this.DeclareOutput("network_interface");
        this.DeclareOutput("nginx_version");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("web_application_firewall");
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
    public AzurermNginxDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNginxDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The auto_scale_profile attribute.
    /// </summary>
    public TerraformExpression AutoScaleProfile => this["auto_scale_profile"];

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public TerraformExpression AutomaticUpgradeChannel => this["automatic_upgrade_channel"];

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformExpression Capacity => this["capacity"];

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformExpression DataplaneApiEndpoint => this["dataplane_api_endpoint"];

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public TerraformExpression DiagnoseSupportEnabled => this["diagnose_support_enabled"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The frontend_private attribute.
    /// </summary>
    public TerraformExpression FrontendPrivate => this["frontend_private"];

    /// <summary>
    /// The frontend_public attribute.
    /// </summary>
    public TerraformExpression FrontendPublic => this["frontend_public"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The logging_storage_account attribute.
    /// </summary>
    public TerraformExpression LoggingStorageAccount => this["logging_storage_account"];

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    public TerraformExpression ManagedResourceGroup => this["managed_resource_group"];

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformExpression NetworkInterface => this["network_interface"];

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformExpression NginxVersion => this["nginx_version"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The web_application_firewall attribute.
    /// </summary>
    public TerraformExpression WebApplicationFirewall => this["web_application_firewall"];

}
