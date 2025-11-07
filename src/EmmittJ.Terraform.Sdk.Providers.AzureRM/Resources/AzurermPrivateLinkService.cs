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
    public TerraformLiteralProperty<HashSet<string>>? AutoApprovalSubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("auto_approval_subscription_ids");
        set => this.WithProperty("auto_approval_subscription_ids", value);
    }

    /// <summary>
    /// The destination_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_ip_address");
        set => this.WithProperty("destination_ip_address", value);
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableProxyProtocol
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_proxy_protocol");
        set => this.WithProperty("enable_proxy_protocol", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LoadBalancerFrontendIpConfigurationIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("load_balancer_frontend_ip_configuration_ids");
        set => this.WithProperty("load_balancer_frontend_ip_configuration_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VisibilitySubscriptionIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("visibility_subscription_ids");
        set => this.WithProperty("visibility_subscription_ids", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

}
