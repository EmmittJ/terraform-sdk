using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_network_security_tls_inspection_policy resource.
/// </summary>
public partial class GoogleNetworkSecurityTlsInspectionPolicy : TerraformResource
{
    public GoogleNetworkSecurityTlsInspectionPolicy(string name) : base("google_network_security_tls_inspection_policy", name)
    {
    }

    /// <summary>
    /// A CA pool resource used to issue interception certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaPool is required")]
    [TerraformProperty("ca_pool")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CaPool { get; set; }

    /// <summary>
    /// List of custom TLS cipher suites selected. This field is valid only if the selected tls_feature_profile is CUSTOM. The compute.SslPoliciesService.ListAvailableFeatures method returns the set of features that can be specified in this list. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    [TerraformProperty("custom_tls_features")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? CustomTlsFeatures { get; set; }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If FALSE (the default), use our default set of public CAs in addition to any CAs specified in trustConfig. These public CAs are currently based on the Mozilla Root Program and are subject to change over time. If TRUE, do not accept our default set of public CAs. Only CAs specified in trustConfig will be accepted.
    /// </summary>
    [TerraformProperty("exclude_public_ca_set")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExcludePublicCaSet { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the tls inspection policy.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Minimum TLS version that the firewall should use when negotiating connections with both clients and servers. If this is not set, then the default value is to allow the broadest set of clients and servers (TLS 1.0 or higher). Setting this to more restrictive values may improve security, but may also prevent the firewall from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TLS_VERSION_UNSPECIFIED&amp;quot;, &amp;quot;TLS_1_0&amp;quot;, &amp;quot;TLS_1_1&amp;quot;, &amp;quot;TLS_1_2&amp;quot;, &amp;quot;TLS_1_3&amp;quot;]
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinTlsVersion { get; set; }

    /// <summary>
    /// Short name of the TlsInspectionPolicy resource to be created.
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
    /// The selected Profile. If this is not set, then the default value is to allow the broadest set of clients and servers (\&amp;quot;PROFILE_COMPATIBLE\&amp;quot;). Setting this to more restrictive values may improve security, but may also prevent the TLS inspection proxy from connecting to some clients or servers. Note that Secure Web Proxy does not yet honor this field. Default value: &amp;quot;PROFILE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;PROFILE_COMPATIBLE&amp;quot;, &amp;quot;PROFILE_MODERN&amp;quot;, &amp;quot;PROFILE_RESTRICTED&amp;quot;, &amp;quot;PROFILE_CUSTOM&amp;quot;]
    /// </summary>
    [TerraformProperty("tls_feature_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsFeatureProfile { get; set; }

    /// <summary>
    /// A TrustConfig resource used when making a connection to the TLS server. This is a relative resource path following the form \&amp;quot;projects/{project}/locations/{location}/trustConfigs/{trust_config}\&amp;quot;. This is necessary to intercept TLS connections to servers with certificates signed by a private CA or self-signed certificates. Trust config and the TLS inspection policy must be in the same region. Note that Secure Web Proxy does not yet honor this field.
    /// </summary>
    [TerraformProperty("trust_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrustConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetworkSecurityTlsInspectionPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
