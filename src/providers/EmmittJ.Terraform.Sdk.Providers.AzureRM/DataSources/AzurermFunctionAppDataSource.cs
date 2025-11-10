using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_function_app.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermFunctionAppDataSource : TerraformDataSource
{
    public AzurermFunctionAppDataSource(string name) : base("azurerm_function_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_service_plan_id");
        this.WithOutput("app_settings");
        this.WithOutput("client_cert_mode");
        this.WithOutput("connection_string");
        this.WithOutput("custom_domain_verification_id");
        this.WithOutput("default_hostname");
        this.WithOutput("enabled");
        this.WithOutput("identity");
        this.WithOutput("location");
        this.WithOutput("os_type");
        this.WithOutput("outbound_ip_addresses");
        this.WithOutput("possible_outbound_ip_addresses");
        this.WithOutput("site_config");
        this.WithOutput("site_credential");
        this.WithOutput("source_control");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFunctionAppDataSourceTimeoutsBlock>("timeouts");
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
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformExpression ClientCertMode => this["client_cert_mode"];

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
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

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

}
