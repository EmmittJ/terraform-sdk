using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_security_policy.
/// </summary>
public class GoogleComputeSecurityPolicyDataSource : TerraformDataSource
{
    public GoogleComputeSecurityPolicyDataSource(string name) : base("google_compute_security_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the security policy.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SelfLink { get; set; }

    /// <summary>
    /// Adaptive Protection Config of this security policy.
    /// </summary>
    [TerraformPropertyName("adaptive_protection_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdaptiveProtectionConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "adaptive_protection_config");

    /// <summary>
    /// Advanced Options Config of this security policy.
    /// </summary>
    [TerraformPropertyName("advanced_options_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdvancedOptionsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "advanced_options_config");

    /// <summary>
    /// An optional description of this security policy. Max size is 2048.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Fingerprint of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// reCAPTCHA configuration options to be applied for the security policy.
    /// </summary>
    [TerraformPropertyName("recaptcha_options_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RecaptchaOptionsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "recaptcha_options_config");

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &amp;quot;*&amp;quot;). If no rules are provided when creating a security policy, a default rule with action &amp;quot;allow&amp;quot; will be added.
    /// </summary>
    [TerraformPropertyName("rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Rule => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "rule");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
