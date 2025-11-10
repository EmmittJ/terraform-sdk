using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The ingress settings for version or service. Default value: &amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ingress_traffic_allowed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IngressTrafficAllowed { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_service_network_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineServiceNetworkSettings : TerraformResource
{
    public GoogleAppEngineServiceNetworkSettings(string name) : base("google_app_engine_service_network_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// Block for network_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSettings block(s) allowed")]
    [TerraformPropertyName("network_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock>>? NetworkSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAppEngineServiceNetworkSettingsTimeoutsBlock>? Timeouts { get; set; } = new();

}
