using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CdnFrontdoorProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cdn_frontdoor_profile_id");

    /// <summary>
    /// The health_probe attribute.
    /// </summary>
    [TerraformPropertyName("health_probe")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HealthProbe => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "health_probe");

    /// <summary>
    /// The load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LoadBalancing => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "load_balancing");

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RestoreTrafficTimeToHealedOrNewEndpointInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "restore_traffic_time_to_healed_or_new_endpoint_in_minutes");

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SessionAffinityEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "session_affinity_enabled");

}
