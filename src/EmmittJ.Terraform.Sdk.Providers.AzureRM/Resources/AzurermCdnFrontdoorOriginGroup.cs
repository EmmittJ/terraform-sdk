using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
public class AzurermCdnFrontdoorOriginGroup : TerraformResource
{
    public AzurermCdnFrontdoorOriginGroup(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorProfileId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_profile_id");
        set => this.WithProperty("cdn_frontdoor_profile_id", value);
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
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        set => this.WithProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionAffinityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("session_affinity_enabled");
        set => this.WithProperty("session_affinity_enabled", value);
    }

}
