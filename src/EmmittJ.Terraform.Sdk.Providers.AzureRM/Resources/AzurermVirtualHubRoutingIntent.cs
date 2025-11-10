using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualHubRoutingIntentRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public List<TerraformProperty<string>>? Destinations
    {
        get => GetProperty<List<TerraformProperty<string>>>("destinations");
        set => WithProperty("destinations", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The next_hop attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHop is required")]
    public required TerraformProperty<string> NextHop
    {
        get => GetProperty<TerraformProperty<string>>("next_hop");
        set => WithProperty("next_hop", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubRoutingIntentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_hub_routing_intent resource.
/// </summary>
public class AzurermVirtualHubRoutingIntent : TerraformResource
{
    public AzurermVirtualHubRoutingIntent(string name) : base("azurerm_virtual_hub_routing_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// Block for routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingPolicy block(s) required")]
    public List<AzurermVirtualHubRoutingIntentRoutingPolicyBlock>? RoutingPolicy
    {
        get => GetProperty<List<AzurermVirtualHubRoutingIntentRoutingPolicyBlock>>("routing_policy");
        set => this.WithProperty("routing_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubRoutingIntentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualHubRoutingIntentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
