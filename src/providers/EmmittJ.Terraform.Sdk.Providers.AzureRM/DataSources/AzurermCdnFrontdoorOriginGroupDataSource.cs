using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_origin_group.
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorOriginGroupDataSource(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CdnFrontdoorProfileId { get; }

    /// <summary>
    /// The health_probe attribute.
    /// </summary>
    [TerraformProperty("health_probe")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthProbe { get; }

    /// <summary>
    /// The load_balancing attribute.
    /// </summary>
    [TerraformProperty("load_balancing")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LoadBalancing { get; }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("session_affinity_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SessionAffinityEnabled { get; }

}
