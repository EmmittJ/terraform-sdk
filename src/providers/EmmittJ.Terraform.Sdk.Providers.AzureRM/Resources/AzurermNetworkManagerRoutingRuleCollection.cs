using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("bgp_route_propagation_enabled");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network_group_ids");
        SetOutput("routing_configuration_id");
    }

    /// <summary>
    /// The bgp_route_propagation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BgpRoutePropagationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bgp_route_propagation_enabled");
        set => SetProperty("bgp_route_propagation_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    public List<TerraformProperty<string>> NetworkGroupIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_group_ids");
        set => SetProperty("network_group_ids", value);
    }

    /// <summary>
    /// The routing_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfigurationId is required")]
    public required TerraformProperty<string> RoutingConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_configuration_id");
        set => SetProperty("routing_configuration_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerRoutingRuleCollectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
