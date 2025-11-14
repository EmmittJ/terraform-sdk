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
public class AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_cdn_frontdoor_origin_group.
/// </summary>
public class AzurermCdnFrontdoorOriginGroupDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorOriginGroupDataSource(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
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
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformArgument("profile_name")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformArgument("cdn_frontdoor_profile_id")]
    public TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
    }

    /// <summary>
    /// The health_probe attribute.
    /// </summary>
    [TerraformArgument("health_probe")]
    public TerraformList<object> HealthProbe
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "health_probe").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancing attribute.
    /// </summary>
    [TerraformArgument("load_balancing")]
    public TerraformList<object> LoadBalancing
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "load_balancing").ResolveNodes(ctx));
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformArgument("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    public TerraformValue<double> RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => new TerraformReference<double>(this, "restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformArgument("session_affinity_enabled")]
    public TerraformValue<bool> SessionAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "session_affinity_enabled");
    }

}
