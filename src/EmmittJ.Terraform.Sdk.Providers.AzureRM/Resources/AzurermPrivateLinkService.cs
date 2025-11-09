using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_link_service resource.
/// </summary>
public class AzurermPrivateLinkService : TerraformResource
{
    public AzurermPrivateLinkService(string name) : base("azurerm_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
    }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AutoApprovalSubscriptionIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("auto_approval_subscription_ids");
        set => this.WithProperty("auto_approval_subscription_ids", value);
    }

    /// <summary>
    /// The destination_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("destination_ip_address");
        set => this.WithProperty("destination_ip_address", value);
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableProxyProtocol
    {
        get => GetProperty<TerraformProperty<bool>>("enable_proxy_protocol");
        set => this.WithProperty("enable_proxy_protocol", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
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
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? LoadBalancerFrontendIpConfigurationIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("load_balancer_frontend_ip_configuration_ids");
        set => this.WithProperty("load_balancer_frontend_ip_configuration_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VisibilitySubscriptionIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("visibility_subscription_ids");
        set => this.WithProperty("visibility_subscription_ids", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

}
