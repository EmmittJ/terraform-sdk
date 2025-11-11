using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsManagedZoneCloudLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// If set, enable query logging for this ManagedZone. False by default, making logging opt-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableLogging is required")]
    [TerraformProperty("enable_logging")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> EnableLogging { get; set; }

}

/// <summary>
/// Block type for dnssec_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsManagedZoneDnssecConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Identifies what kind of resource this is
    /// </summary>
    [TerraformProperty("kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is &#39;off&#39;. Possible values: [&amp;quot;nsec&amp;quot;, &amp;quot;nsec3&amp;quot;]
    /// </summary>
    [TerraformProperty("non_existence")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NonExistence { get; set; }

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in Possible values: [&amp;quot;off&amp;quot;, &amp;quot;on&amp;quot;, &amp;quot;transfer&amp;quot;]
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

}

/// <summary>
/// Block type for forwarding_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsManagedZoneForwardingConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for peering_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsManagedZonePeeringConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for private_visibility_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsManagedZonePrivateVisibilityConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDnsManagedZoneTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_dns_managed_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDnsManagedZone : TerraformResource
{
    public GoogleDnsManagedZone(string name) : base("google_dns_managed_zone", name)
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The DNS name of this managed zone, for instance &amp;quot;example.com.&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    [TerraformProperty("dns_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DnsName { get; set; }

    /// <summary>
    /// Set this true to delete all records in the zone.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to this ManagedZone.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// User assigned name for this resource.
    /// Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The zone&#39;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources. Default value: &amp;quot;public&amp;quot; Possible values: [&amp;quot;private&amp;quot;, &amp;quot;public&amp;quot;]
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Visibility { get; set; }

    /// <summary>
    /// Block for cloud_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudLoggingConfig block(s) allowed")]
    [TerraformProperty("cloud_logging_config")]
    public partial TerraformList<TerraformBlock<GoogleDnsManagedZoneCloudLoggingConfigBlock>>? CloudLoggingConfig { get; set; }

    /// <summary>
    /// Block for dnssec_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnssecConfig block(s) allowed")]
    [TerraformProperty("dnssec_config")]
    public partial TerraformList<TerraformBlock<GoogleDnsManagedZoneDnssecConfigBlock>>? DnssecConfig { get; set; }

    /// <summary>
    /// Block for forwarding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardingConfig block(s) allowed")]
    [TerraformProperty("forwarding_config")]
    public partial TerraformList<TerraformBlock<GoogleDnsManagedZoneForwardingConfigBlock>>? ForwardingConfig { get; set; }

    /// <summary>
    /// Block for peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    [TerraformProperty("peering_config")]
    public partial TerraformList<TerraformBlock<GoogleDnsManagedZonePeeringConfigBlock>>? PeeringConfig { get; set; }

    /// <summary>
    /// Block for private_visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateVisibilityConfig block(s) allowed")]
    [TerraformProperty("private_visibility_config")]
    public partial TerraformList<TerraformBlock<GoogleDnsManagedZonePrivateVisibilityConfigBlock>>? PrivateVisibilityConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDnsManagedZoneTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Unique identifier for the resource; defined by the server.
    /// </summary>
    [TerraformProperty("managed_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ManagedZoneId { get; }

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> NameServers { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
