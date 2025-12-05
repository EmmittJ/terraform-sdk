using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for sku in AzurermExpressRouteCircuit.
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformValue<string> Family
    {
        get => GetRequiredArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetRequiredArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermExpressRouteCircuit.
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_express_route_circuit Terraform resource.
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
public partial class AzurermExpressRouteCircuit(string name) : TerraformResource("azurerm_express_route_circuit", name)
{
    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    public TerraformValue<bool>? AllowClassicOperations
    {
        get => GetArgument<TerraformValue<bool>>("allow_classic_operations");
        set => SetArgument("allow_classic_operations", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationKey
    {
        get => GetArgument<TerraformValue<string>>("authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public TerraformValue<double>? BandwidthInGbps
    {
        get => GetArgument<TerraformValue<double>>("bandwidth_in_gbps");
        set => SetArgument("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    public TerraformValue<double>? BandwidthInMbps
    {
        get => GetArgument<TerraformValue<double>>("bandwidth_in_mbps");
        set => SetArgument("bandwidth_in_mbps", value);
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    public TerraformValue<string>? ExpressRoutePortId
    {
        get => GetArgument<TerraformValue<string>>("express_route_port_id");
        set => SetArgument("express_route_port_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    public TerraformValue<string>? PeeringLocation
    {
        get => GetArgument<TerraformValue<string>>("peering_location");
        set => SetArgument("peering_location", value);
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RateLimitingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rate_limiting_enabled");
        set => SetArgument("rate_limiting_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceProviderName
    {
        get => GetArgument<TerraformValue<string>>("service_provider_name");
        set => SetArgument("service_provider_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformValue<string> ServiceKey
        => CreateReference("service_key");

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    public TerraformValue<string> ServiceProviderProvisioningState
        => CreateReference("service_provider_provisioning_state");

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermExpressRouteCircuitSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermExpressRouteCircuitSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
