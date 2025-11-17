using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLbBackendAddressPoolDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_lb_backend_address_pool Terraform data source.
/// Retrieves information about a azurerm_lb_backend_address_pool.
/// </summary>
public partial class AzurermLbBackendAddressPoolDataSource(string name) : TerraformDataSource("azurerm_lb_backend_address_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => new TerraformReference<string>(this, "loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The backend_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendAddress
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backend_address").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendIpConfigurations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backend_ip_configurations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    public TerraformList<string> InboundNatRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inbound_nat_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    public TerraformList<string> LoadBalancingRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "load_balancing_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    public TerraformList<string> OutboundRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbBackendAddressPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbBackendAddressPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
