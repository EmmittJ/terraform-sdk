using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermExpressRouteCircuitDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_express_route_circuit Terraform data source.
/// Retrieves information about a azurerm_express_route_circuit.
/// </summary>
public partial class AzurermExpressRouteCircuitDataSource(string name) : TerraformDataSource("azurerm_express_route_circuit", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The peerings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Peerings
        => AsReference("peerings");

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformValue<string> ServiceKey
        => AsReference("service_key");

    /// <summary>
    /// The service_provider_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceProviderProperties
        => AsReference("service_provider_properties");

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    public TerraformValue<string> ServiceProviderProvisioningState
        => AsReference("service_provider_provisioning_state");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
        => AsReference("sku");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
