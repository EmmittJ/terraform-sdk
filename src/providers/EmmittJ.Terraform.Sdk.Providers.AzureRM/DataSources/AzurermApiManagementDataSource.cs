using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_api_management.
/// </summary>
public class AzurermApiManagementDataSource : TerraformDataSource
{
    public AzurermApiManagementDataSource(string name) : base("azurerm_api_management", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("additional_location");
        this.WithOutput("developer_portal_url");
        this.WithOutput("gateway_regional_url");
        this.WithOutput("gateway_url");
        this.WithOutput("hostname_configuration");
        this.WithOutput("identity");
        this.WithOutput("location");
        this.WithOutput("management_api_url");
        this.WithOutput("notification_sender_email");
        this.WithOutput("portal_url");
        this.WithOutput("private_ip_addresses");
        this.WithOutput("public_ip_address_id");
        this.WithOutput("public_ip_addresses");
        this.WithOutput("publisher_email");
        this.WithOutput("publisher_name");
        this.WithOutput("scm_url");
        this.WithOutput("sku_name");
        this.WithOutput("tenant_access");
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
    public AzurermApiManagementDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The additional_location attribute.
    /// </summary>
    public TerraformExpression AdditionalLocation => this["additional_location"];

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformExpression DeveloperPortalUrl => this["developer_portal_url"];

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformExpression GatewayRegionalUrl => this["gateway_regional_url"];

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformExpression GatewayUrl => this["gateway_url"];

    /// <summary>
    /// The hostname_configuration attribute.
    /// </summary>
    public TerraformExpression HostnameConfiguration => this["hostname_configuration"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformExpression ManagementApiUrl => this["management_api_url"];

    /// <summary>
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformExpression NotificationSenderEmail => this["notification_sender_email"];

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformExpression PortalUrl => this["portal_url"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformExpression PublicIpAddressId => this["public_ip_address_id"];

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PublicIpAddresses => this["public_ip_addresses"];

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    public TerraformExpression PublisherEmail => this["publisher_email"];

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    public TerraformExpression PublisherName => this["publisher_name"];

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformExpression ScmUrl => this["scm_url"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tenant_access attribute.
    /// </summary>
    public TerraformExpression TenantAccess => this["tenant_access"];

}
