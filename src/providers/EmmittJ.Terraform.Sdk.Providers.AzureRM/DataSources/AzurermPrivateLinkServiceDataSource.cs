using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_private_link_service.
/// </summary>
public class AzurermPrivateLinkServiceDataSource : TerraformDataSource
{
    public AzurermPrivateLinkServiceDataSource(string name) : base("azurerm_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alias");
        SetOutput("auto_approval_subscription_ids");
        SetOutput("enable_proxy_protocol");
        SetOutput("load_balancer_frontend_ip_configuration_ids");
        SetOutput("location");
        SetOutput("nat_ip_configuration");
        SetOutput("tags");
        SetOutput("visibility_subscription_ids");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateLinkServiceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public TerraformExpression AutoApprovalSubscriptionIds => this["auto_approval_subscription_ids"];

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformExpression EnableProxyProtocol => this["enable_proxy_protocol"];

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public TerraformExpression LoadBalancerFrontendIpConfigurationIds => this["load_balancer_frontend_ip_configuration_ids"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The nat_ip_configuration attribute.
    /// </summary>
    public TerraformExpression NatIpConfiguration => this["nat_ip_configuration"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public TerraformExpression VisibilitySubscriptionIds => this["visibility_subscription_ids"];

}
