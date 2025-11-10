using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock : ITerraformBlock
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
/// Manages a google_network_security_tls_inspection_policy resource.
/// </summary>
public class GoogleNetworkSecurityTlsInspectionPolicy : TerraformResource
{
    public GoogleNetworkSecurityTlsInspectionPolicy(string name) : base("google_network_security_tls_inspection_policy", name)
    {
    }

    /// <summary>
    /// A CA pool resource used to issue interception certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    [TerraformPropertyName("ca_pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CaPool { get; set; }

    /// <summary>
    /// List of custom TLS cipher suites selected. This field is valid only if the selected tls_feature_profile is CUSTOM. The compute.SslPoliciesService.ListAvailableFeatures method returns the set of features that can be specified in this list. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    [TerraformPropertyName("custom_tls_features")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? CustomTlsFeatures { get; set; }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// If FALSE (the default), use our default set of public CAs in addition to any CAs specified in trustConfig. These public CAs are currently based on the Mozilla Root Program and are subject to change over time. If TRUE, do not accept our default set of public CAs. Only CAs specified in trustConfig will be accepted.
    /// </summary>
    [TerraformPropertyName("exclude_public_ca_set")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExcludePublicCaSet { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the tls inspection policy.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Minimum TLS version that the firewall should use when negotiating connections with both clients and servers. If this is not set, then the default value is to allow the broadest set of clients and servers (TLS 1.0 or higher). Setting this to more restrictive values may improve security, but may also prevent the firewall from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot;, &amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;, &amp;quot;TLS_1_3&amp;quot;]
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinTlsVersion { get; set; }

    /// <summary>
    /// Short name of the TlsInspectionPolicy resource to be created.
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
    /// The selected Profile. If this is not set, then the default value is to allow the broadest set of clients and servers (\&amp;quot;PROFILE_COMPATIBLE\&amp;quot;). Setting this to more restrictive values may improve security, but may also prevent the TLS inspection proxy from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;PROFILE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;PROFILE_COMPATIBLE&amp;quot;, &amp;quot;PROFILE_MODERN&amp;quot;, &amp;quot;PROFILE_RESTRICTED&amp;quot;, &amp;quot;PROFILE_CUSTOM&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tls_feature_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TlsFeatureProfile { get; set; }

    /// <summary>
    /// A TrustConfig resource used when making a connection to the TLS server. This is a relative resource path following the form \&amp;quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}\&amp;quot;. This is necessary to intercept TLS connections to servers with certificates signed by a private CA or self-signed certificates. Trust config and the TLS inspection policy must be in the same region. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    [TerraformPropertyName("trust_config")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrustConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
