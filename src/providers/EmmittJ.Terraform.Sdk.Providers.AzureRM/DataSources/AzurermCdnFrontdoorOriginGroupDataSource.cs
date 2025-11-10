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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("cdn_frontdoor_profile_id");
        this.WithOutput("health_probe");
        this.WithOutput("load_balancing");
        this.WithOutput("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        this.WithOutput("session_affinity_enabled");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("profile_name");
        set => this.WithProperty("profile_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorOriginGroupDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
