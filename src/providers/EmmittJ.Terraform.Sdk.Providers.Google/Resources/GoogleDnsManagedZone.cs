using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneCloudLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If set, enable query logging for this ManagedZone. False by default, making logging opt-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableLogging is required")]
    [TerraformPropertyName("enable_logging")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableLogging { get; set; }

}

/// <summary>
/// Block type for dnssec_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneDnssecConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Identifies what kind of resource this is
    /// </summary>
    [TerraformPropertyName("kind")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Kind { get; set; }

    /// <summary>
    /// Specifies the mechanism used to provide authenticated denial-of-existence responses.
    /// non_existence can only be updated when the state is &#39;off&#39;. Possible values: [&amp;quot;nsec&amp;quot;, &amp;quot;nsec3&amp;quot;]
    /// </summary>
    [TerraformPropertyName("non_existence")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NonExistence { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "non_existence");

    /// <summary>
    /// Specifies whether DNSSEC is enabled, and what mode it is in Possible values: [&amp;quot;off&amp;quot;, &amp;quot;on&amp;quot;, &amp;quot;transfer&amp;quot;]
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

}

/// <summary>
/// Block type for forwarding_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZoneForwardingConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for peering_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePeeringConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for private_visibility_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsManagedZonePrivateVisibilityConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsManagedZoneTimeoutsBlock : ITerraformBlock
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
/// Manages a google_dns_managed_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsManagedZone : TerraformResource
{
    public GoogleDnsManagedZone(string name) : base("google_dns_managed_zone", name)
    {
    }

    /// <summary>
    /// A textual description field. Defaults to &#39;Managed by Terraform&#39;.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The DNS name of this managed zone, for instance &amp;quot;example.com.&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    [TerraformPropertyName("dns_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DnsName { get; set; }

    /// <summary>
    /// Set this true to delete all records in the zone.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A set of key/value label pairs to assign to this ManagedZone.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// User assigned name for this resource.
    /// Must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The zone&#39;s visibility: public zones are exposed to the Internet,
    /// while private zones are visible only to Virtual Private Cloud resources. Default value: &amp;quot;public&amp;quot; Possible values: [&amp;quot;private&amp;quot;, &amp;quot;public&amp;quot;]
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Visibility { get; set; }

    /// <summary>
    /// Block for cloud_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudLoggingConfig block(s) allowed")]
    [TerraformPropertyName("cloud_logging_config")]
    public TerraformList<TerraformBlock<GoogleDnsManagedZoneCloudLoggingConfigBlock>>? CloudLoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for dnssec_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnssecConfig block(s) allowed")]
    [TerraformPropertyName("dnssec_config")]
    public TerraformList<TerraformBlock<GoogleDnsManagedZoneDnssecConfigBlock>>? DnssecConfig { get; set; } = new();

    /// <summary>
    /// Block for forwarding_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardingConfig block(s) allowed")]
    [TerraformPropertyName("forwarding_config")]
    public TerraformList<TerraformBlock<GoogleDnsManagedZoneForwardingConfigBlock>>? ForwardingConfig { get; set; } = new();

    /// <summary>
    /// Block for peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeeringConfig block(s) allowed")]
    [TerraformPropertyName("peering_config")]
    public TerraformList<TerraformBlock<GoogleDnsManagedZonePeeringConfigBlock>>? PeeringConfig { get; set; } = new();

    /// <summary>
    /// Block for private_visibility_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateVisibilityConfig block(s) allowed")]
    [TerraformPropertyName("private_visibility_config")]
    public TerraformList<TerraformBlock<GoogleDnsManagedZonePrivateVisibilityConfigBlock>>? PrivateVisibilityConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDnsManagedZoneTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Unique identifier for the resource; defined by the server.
    /// </summary>
    [TerraformPropertyName("managed_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ManagedZoneId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "managed_zone_id");

    /// <summary>
    /// Delegate your managed_zone to these virtual name servers;
    /// defined by the server
    /// </summary>
    [TerraformPropertyName("name_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NameServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "name_servers");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
