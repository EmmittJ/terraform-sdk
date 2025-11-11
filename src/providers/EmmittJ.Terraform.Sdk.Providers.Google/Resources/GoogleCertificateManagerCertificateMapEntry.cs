using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateMapEntryTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_certificate_manager_certificate_map_entry resource.
/// </summary>
public class GoogleCertificateManagerCertificateMapEntry : TerraformResource
{
    public GoogleCertificateManagerCertificateMapEntry(string name) : base("google_certificate_manager_certificate_map_entry", name)
    {
    }

    /// <summary>
    /// A set of Certificates defines for the given hostname.
    /// There can be defined up to fifteen certificates in each Certificate Map Entry.
    /// Each certificate must match pattern projects/*/locations/*/certificates/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificates is required")]
    [TerraformPropertyName("certificates")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Certificates { get; set; }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A Hostname (FQDN, e.g. example.com) or a wildcard hostname expression (*.example.com)
    /// for a set of hostnames with common suffix. Used as Server Name Indication (SNI) for
    /// selecting a proper certificate.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Set of labels associated with a Certificate Map Entry.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// A map entry that is inputted into the certificate map
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Map is required")]
    [TerraformPropertyName("map")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Map { get; set; }

    /// <summary>
    /// A predefined matcher for particular cases, other than SNI selection
    /// </summary>
    [TerraformPropertyName("matcher")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Matcher { get; set; }

    /// <summary>
    /// A user-defined name of the Certificate Map Entry. Certificate Map Entry
    /// names must be unique globally and match pattern
    /// &#39;projects/*/locations/*/certificateMaps/*/certificateMapEntries/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCertificateManagerCertificateMapEntryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// A serving state of this Certificate Map Entry.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Update timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
