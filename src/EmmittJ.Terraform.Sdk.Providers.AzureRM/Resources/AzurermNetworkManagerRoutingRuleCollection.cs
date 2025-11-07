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
    public TerraformLiteralProperty<bool>? BgpRoutePropagationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bgp_route_propagation_enabled");
        set => this.WithProperty("bgp_route_propagation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? NetworkGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_group_ids");
        set => this.WithProperty("network_group_ids", value);
    }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoutingConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_configuration_id");
        set => this.WithProperty("routing_configuration_id", value);
    }

}
