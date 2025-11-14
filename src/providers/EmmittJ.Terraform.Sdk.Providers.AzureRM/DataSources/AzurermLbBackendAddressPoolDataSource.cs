using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_lb_backend_address_pool.
/// </summary>
public class AzurermLbBackendAddressPoolDataSource : TerraformDataSource
{
    public AzurermLbBackendAddressPoolDataSource(string name) : base("azurerm_lb_backend_address_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformArgument("loadbalancer_id")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => new TerraformReference<string>(this, "loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLbBackendAddressPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_address attribute.
    /// </summary>
    [TerraformArgument("backend_address")]
    public TerraformList<object> BackendAddress
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "backend_address").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    [TerraformArgument("backend_ip_configurations")]
    public TerraformList<object> BackendIpConfigurations
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "backend_ip_configurations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    [TerraformArgument("inbound_nat_rules")]
    public TerraformList<string> InboundNatRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inbound_nat_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    [TerraformArgument("load_balancing_rules")]
    public TerraformList<string> LoadBalancingRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "load_balancing_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    [TerraformArgument("outbound_rules")]
    public TerraformList<string> OutboundRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_rules").ResolveNodes(ctx));
    }

}
