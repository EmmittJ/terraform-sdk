using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSslPolicyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_compute_region_ssl_policy resource.
/// </summary>
public class GoogleComputeRegionSslPolicy : TerraformResource
{
    public GoogleComputeRegionSslPolicy(string name) : base("google_compute_region_ssl_policy", name)
    {
    }

    /// <summary>
    /// A list of features enabled when the selected profile is CUSTOM. The
    /// method returns the set of features that can be specified in this
    /// list. This field must be empty if the profile is not CUSTOM.
    /// 
    /// See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport)
    /// for which ciphers are available to use. **Note**: this argument
    /// *must* be present when using the &#39;CUSTOM&#39; profile. This argument
    /// *must not* be present when using any other profile.
    /// </summary>
    [TerraformPropertyName("custom_features")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CustomFeatures { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The minimum version of SSL protocol that can be used by the clients
    /// to establish a connection with the load balancer. Default value: &amp;quot;TLS_1_0&amp;quot; Possible values: [&amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;]
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinTlsVersion { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Profile specifies the set of SSL features that can be used by the
    /// load balancer when negotiating SSL with clients. If using &#39;CUSTOM&#39;,
    /// the set of SSL features to enable must be specified in the
    /// &#39;customFeatures&#39; field.
    /// 
    /// See the [official documentation](https://cloud.google.com/compute/docs/load-balancing/ssl-policies#profilefeaturesupport)
    /// for information on what cipher suites each profile provides. If
    /// &#39;CUSTOM&#39; is used, the &#39;custom_features&#39; attribute **must be set**. Default value: &amp;quot;COMPATIBLE&amp;quot; Possible values: [&amp;quot;COMPATIBLE&amp;quot;, &amp;quot;MODERN&amp;quot;, &amp;quot;RESTRICTED&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Profile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region where the regional SSL policy resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionSslPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The list of features enabled in the SSL policy.
    /// </summary>
    [TerraformPropertyName("enabled_features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> EnabledFeatures => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "enabled_features");

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
