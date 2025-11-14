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
/// Block type for sku in .
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
    [TerraformArgument("family")]
    public required TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformArgument("tier")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRouteCircuit : TerraformResource
{
    public AzurermExpressRouteCircuit(string name) : base("azurerm_express_route_circuit", name)
    {
    }

    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    [TerraformArgument("allow_classic_operations")]
    public TerraformValue<bool>? AllowClassicOperations
    {
        get => new TerraformReference<bool>(this, "allow_classic_operations");
        set => SetArgument("allow_classic_operations", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformArgument("authorization_key")]
    public TerraformValue<string>? AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [TerraformArgument("bandwidth_in_gbps")]
    public TerraformValue<double>? BandwidthInGbps
    {
        get => new TerraformReference<double>(this, "bandwidth_in_gbps");
        set => SetArgument("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    [TerraformArgument("bandwidth_in_mbps")]
    public TerraformValue<double>? BandwidthInMbps
    {
        get => new TerraformReference<double>(this, "bandwidth_in_mbps");
        set => SetArgument("bandwidth_in_mbps", value);
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    [TerraformArgument("express_route_port_id")]
    public TerraformValue<string>? ExpressRoutePortId
    {
        get => new TerraformReference<string>(this, "express_route_port_id");
        set => SetArgument("express_route_port_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The peering_location attribute.
    /// </summary>
    [TerraformArgument("peering_location")]
    public TerraformValue<string>? PeeringLocation
    {
        get => new TerraformReference<string>(this, "peering_location");
        set => SetArgument("peering_location", value);
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    [TerraformArgument("rate_limiting_enabled")]
    public TerraformValue<bool>? RateLimitingEnabled
    {
        get => new TerraformReference<bool>(this, "rate_limiting_enabled");
        set => SetArgument("rate_limiting_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    [TerraformArgument("service_provider_name")]
    public TerraformValue<string>? ServiceProviderName
    {
        get => new TerraformReference<string>(this, "service_provider_name");
        set => SetArgument("service_provider_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermExpressRouteCircuitSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermExpressRouteCircuitTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformArgument("service_key")]
    public TerraformValue<string> ServiceKey
    {
        get => new TerraformReference<string>(this, "service_key");
    }

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    [TerraformArgument("service_provider_provisioning_state")]
    public TerraformValue<string> ServiceProviderProvisioningState
    {
        get => new TerraformReference<string>(this, "service_provider_provisioning_state");
    }

}
