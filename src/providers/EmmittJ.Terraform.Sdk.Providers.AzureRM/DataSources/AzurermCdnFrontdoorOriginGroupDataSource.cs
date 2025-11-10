using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_origin_group.
/// </summary>
public class AzurermCdnFrontdoorOriginGroupDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorOriginGroupDataSource(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_frontdoor_profile_id");
        SetOutput("health_probe");
        SetOutput("load_balancing");
        SetOutput("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        SetOutput("session_affinity_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("profile_name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_name");
        set => SetProperty("profile_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorProfileId => this["cdn_frontdoor_profile_id"];

    /// <summary>
    /// The health_probe attribute.
    /// </summary>
    public TerraformExpression HealthProbe => this["health_probe"];

    /// <summary>
    /// The load_balancing attribute.
    /// </summary>
    public TerraformExpression LoadBalancing => this["load_balancing"];

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformExpression RestoreTrafficTimeToHealedOrNewEndpointInMinutes => this["restore_traffic_time_to_healed_or_new_endpoint_in_minutes"];

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformExpression SessionAffinityEnabled => this["session_affinity_enabled"];

}
