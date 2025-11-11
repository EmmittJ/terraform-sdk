using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for android_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// If set to true, it means allowed_package_names will not be enforced.
    /// </summary>
    [TerraformProperty("allow_all_package_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAllPackageNames { get; set; }

    /// <summary>
    /// Android package names of apps allowed to use the key. Example: &#39;com.companyname.appname&#39;
    /// </summary>
    [TerraformProperty("allowed_package_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedPackageNames { get; set; }

}

/// <summary>
/// Block type for ios_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyIosSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// If set to true, it means allowed_bundle_ids will not be enforced.
    /// </summary>
    [TerraformProperty("allow_all_bundle_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAllBundleIds { get; set; }

    /// <summary>
    /// iOS bundle ids of apps allowed to use the key. Example: &#39;com.companyname.productname.appname&#39;
    /// </summary>
    [TerraformProperty("allowed_bundle_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedBundleIds { get; set; }

}

/// <summary>
/// Block type for testing_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyTestingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if UNSOLVABLE_CHALLENGE. Possible values: TESTING_CHALLENGE_UNSPECIFIED, NOCAPTCHA, UNSOLVABLE_CHALLENGE
    /// </summary>
    [TerraformProperty("testing_challenge")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TestingChallenge { get; set; }

    /// <summary>
    /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
    /// </summary>
    [TerraformProperty("testing_score")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TestingScore { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyTimeoutsBlock : TerraformBlockBase
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
/// Block type for waf_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyWafSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Supported WAF features. For more information, see https://cloud.google.com/recaptcha-enterprise/docs/usecase#comparison_of_features. Possible values: CHALLENGE_PAGE, SESSION_TOKEN, ACTION_TOKEN, EXPRESS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafFeature is required")]
    [TerraformProperty("waf_feature")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WafFeature { get; set; }

    /// <summary>
    /// The WAF service that uses this key. Possible values: CA, FASTLY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafService is required")]
    [TerraformProperty("waf_service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WafService { get; set; }

}

/// <summary>
/// Block type for web_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleRecaptchaEnterpriseKeyWebSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// If set to true, it means allowed_domains will not be enforced.
    /// </summary>
    [TerraformProperty("allow_all_domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAllDomains { get; set; }

    /// <summary>
    /// If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
    /// </summary>
    [TerraformProperty("allow_amp_traffic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowAmpTraffic { get; set; }

    /// <summary>
    /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: &#39;example.com&#39; or &#39;subdomain.example.com&#39;
    /// </summary>
    [TerraformProperty("allowed_domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedDomains { get; set; }

    /// <summary>
    /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY
    /// </summary>
    [TerraformProperty("challenge_security_preference")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ChallengeSecurityPreference { get; set; }

    /// <summary>
    /// Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    [TerraformProperty("integration_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntegrationType { get; set; }

}

/// <summary>
/// Manages a google_recaptcha_enterprise_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleRecaptchaEnterpriseKey : TerraformResource
{
    public GoogleRecaptchaEnterpriseKey(string name) : base("google_recaptcha_enterprise_key", name)
    {
    }

    /// <summary>
    /// Human-readable display name of this key. Modifiable by user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// See [Creating and managing labels](https://cloud.google.com/recaptcha-enterprise/docs/labels).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for android_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidSettings block(s) allowed")]
    [TerraformProperty("android_settings")]
    public partial TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>>? AndroidSettings { get; set; }

    /// <summary>
    /// Block for ios_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosSettings block(s) allowed")]
    [TerraformProperty("ios_settings")]
    public partial TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>>? IosSettings { get; set; }

    /// <summary>
    /// Block for testing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestingOptions block(s) allowed")]
    [TerraformProperty("testing_options")]
    public partial TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>>? TestingOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleRecaptchaEnterpriseKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for waf_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafSettings block(s) allowed")]
    [TerraformProperty("waf_settings")]
    public partial TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>>? WafSettings { get; set; }

    /// <summary>
    /// Block for web_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSettings block(s) allowed")]
    [TerraformProperty("web_settings")]
    public partial TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>>? WebSettings { get; set; }

    /// <summary>
    /// The timestamp corresponding to the creation of this Key.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource id for the Key, which is the same as the Site Key itself.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
