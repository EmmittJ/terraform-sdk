using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_routing_rule_collection resource.
/// </summary>
public class AzurermNetworkManagerRoutingRuleCollection : TerraformResource
{
    public AzurermNetworkManagerRoutingRuleCollection(string name) : base("azurerm_network_manager_routing_rule_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bgp_route_propagation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BgpRoutePropagationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bgp_route_propagation_enabled");
        set => this.WithProperty("bgp_route_propagation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The network_group_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NetworkGroupIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("network_group_ids");
        set => this.WithProperty("network_group_ids", value);
    }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("routing_configuration_id");
        set => this.WithProperty("routing_configuration_id", value);
    }

}
