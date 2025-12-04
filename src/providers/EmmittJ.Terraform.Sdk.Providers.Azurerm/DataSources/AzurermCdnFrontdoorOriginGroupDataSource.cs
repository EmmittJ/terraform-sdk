using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorOriginGroupDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_origin_group Terraform data source.
/// Retrieves information about a azurerm_cdn_frontdoor_origin_group.
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupDataSource(string name) : TerraformDataSource("azurerm_cdn_frontdoor_origin_group", name)
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
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformValue<string> ProfileName
    {
        get => GetArgument<TerraformValue<string>>("profile_name");
        set => SetArgument("profile_name", value);
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
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    public TerraformValue<string> CdnFrontdoorProfileId
        => AsReference("cdn_frontdoor_profile_id");

    /// <summary>
    /// The health_probe attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthProbe
        => AsReference("health_probe");

    /// <summary>
    /// The load_balancing attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoadBalancing
        => AsReference("load_balancing");

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> RestoreTrafficTimeToHealedOrNewEndpointInMinutes
        => AsReference("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SessionAffinityEnabled
        => AsReference("session_affinity_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
