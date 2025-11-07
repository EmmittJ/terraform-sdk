using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("cdn_frontdoor_profile_id");
        this.DeclareOutput("health_probe");
        this.DeclareOutput("load_balancing");
        this.DeclareOutput("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        this.DeclareOutput("session_affinity_enabled");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileName
    {
        get => GetProperty<TerraformProperty<string>>("profile_name");
        set => this.WithProperty("profile_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
