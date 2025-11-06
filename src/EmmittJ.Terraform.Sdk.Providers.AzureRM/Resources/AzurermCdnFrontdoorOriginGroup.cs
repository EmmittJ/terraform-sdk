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
    public string? CdnFrontdoorProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_profile_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")?.Value;
        set => this.WithProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public bool? SessionAffinityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("session_affinity_enabled")?.Value;
        set => this.WithProperty("session_affinity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
