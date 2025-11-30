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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The peerings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Peerings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "peerings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformValue<string> ServiceKey
    {
        get => new TerraformReference<string>(this, "service_key");
    }

    /// <summary>
    /// The service_provider_properties attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceProviderProperties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_provider_properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    public TerraformValue<string> ServiceProviderProvisioningState
    {
        get => new TerraformReference<string>(this, "service_provider_provisioning_state");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
