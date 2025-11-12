using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock() : TerraformBlock("network_settings")
{
    /// <summary>
    /// The ingress settings for version or service. Default value: &amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB&amp;quot;]
    /// </summary>
    [TerraformProperty("ingress_traffic_allowed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IngressTrafficAllowed { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineServiceNetworkSettingsTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_service_network_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineServiceNetworkSettings : TerraformResource
{
    public GoogleAppEngineServiceNetworkSettings(string name) : base("google_app_engine_service_network_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// Block for network_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSettings block(s) allowed")]
    [TerraformProperty("network_settings")]
    public required TerraformList<GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock> NetworkSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleAppEngineServiceNetworkSettingsTimeoutsBlock Timeouts { get; set; } = new();

}
