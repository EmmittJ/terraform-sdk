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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => GetArgument<TerraformValue<string>>("loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The backend_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendAddress
        => AsReference("backend_address");

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackendIpConfigurations
        => AsReference("backend_ip_configurations");

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    public TerraformList<string> InboundNatRules
        => AsReference("inbound_nat_rules");

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    public TerraformList<string> LoadBalancingRules
        => AsReference("load_balancing_rules");

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    public TerraformList<string> OutboundRules
        => AsReference("outbound_rules");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbBackendAddressPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbBackendAddressPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
