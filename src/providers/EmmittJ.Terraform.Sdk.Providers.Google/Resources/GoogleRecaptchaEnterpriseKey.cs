using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for android_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock
{
    /// <summary>
    /// If set to true, it means allowed_package_names will not be enforced.
    /// </summary>
    [TerraformPropertyName("allow_all_package_names")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAllPackageNames { get; set; }

    /// <summary>
    /// Android package names of apps allowed to use the key. Example: &#39;com.companyname.appname&#39;
    /// </summary>
    [TerraformPropertyName("allowed_package_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedPackageNames { get; set; }

}

/// <summary>
/// Block type for ios_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyIosSettingsBlock
{
    /// <summary>
    /// If set to true, it means allowed_bundle_ids will not be enforced.
    /// </summary>
    [TerraformPropertyName("allow_all_bundle_ids")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAllBundleIds { get; set; }

    /// <summary>
    /// iOS bundle ids of apps allowed to use the key. Example: &#39;com.companyname.productname.appname&#39;
    /// </summary>
    [TerraformPropertyName("allowed_bundle_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedBundleIds { get; set; }

}

/// <summary>
/// Block type for testing_options in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTestingOptionsBlock
{
    /// <summary>
    /// For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if UNSOLVABLE_CHALLENGE. Possible values: TESTING_CHALLENGE_UNSPECIFIED, NOCAPTCHA, UNSOLVABLE_CHALLENGE
    /// </summary>
    [TerraformPropertyName("testing_challenge")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TestingChallenge { get; set; } = default!;

    /// <summary>
    /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
    /// </summary>
    [TerraformPropertyName("testing_score")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TestingScore { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTimeoutsBlock
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
/// Block type for waf_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWafSettingsBlock
{
    /// <summary>
    /// Supported WAF features. For more information, see https://cloud.google.com/recaptcha-enterprise/docs/usecase#comparison_of_features. Possible values: CHALLENGE_PAGE, SESSION_TOKEN, ACTION_TOKEN, EXPRESS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafFeature is required")]
    [TerraformPropertyName("waf_feature")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WafFeature { get; set; }

    /// <summary>
    /// The WAF service that uses this key. Possible values: CA, FASTLY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafService is required")]
    [TerraformPropertyName("waf_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WafService { get; set; }

}

/// <summary>
/// Block type for web_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWebSettingsBlock
{
    /// <summary>
    /// If set to true, it means allowed_domains will not be enforced.
    /// </summary>
    [TerraformPropertyName("allow_all_domains")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAllDomains { get; set; }

    /// <summary>
    /// If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
    /// </summary>
    [TerraformPropertyName("allow_amp_traffic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAmpTraffic { get; set; }

    /// <summary>
    /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: &#39;example.com&#39; or &#39;subdomain.example.com&#39;
    /// </summary>
    [TerraformPropertyName("allowed_domains")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedDomains { get; set; }

    /// <summary>
    /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY
    /// </summary>
    [TerraformPropertyName("challenge_security_preference")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ChallengeSecurityPreference { get; set; } = default!;

    /// <summary>
    /// Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    [TerraformPropertyName("integration_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntegrationType { get; set; }

}

/// <summary>
/// Manages a google_recaptcha_enterprise_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleRecaptchaEnterpriseKey : TerraformResource
{
    public GoogleRecaptchaEnterpriseKey(string name) : base("google_recaptcha_enterprise_key", name)
    {
    }

    /// <summary>
    /// Human-readable display name of this key. Modifiable by user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// See [Creating and managing labels](https://cloud.google.com/recaptcha-enterprise/docs/labels).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for android_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidSettings block(s) allowed")]
    [TerraformPropertyName("android_settings")]
    public TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>>? AndroidSettings { get; set; }

    /// <summary>
    /// Block for ios_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosSettings block(s) allowed")]
    [TerraformPropertyName("ios_settings")]
    public TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>>? IosSettings { get; set; }

    /// <summary>
    /// Block for testing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestingOptions block(s) allowed")]
    [TerraformPropertyName("testing_options")]
    public TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>>? TestingOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleRecaptchaEnterpriseKeyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for waf_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafSettings block(s) allowed")]
    [TerraformPropertyName("waf_settings")]
    public TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>>? WafSettings { get; set; }

    /// <summary>
    /// Block for web_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSettings block(s) allowed")]
    [TerraformPropertyName("web_settings")]
    public TerraformList<TerraformBlock<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>>? WebSettings { get; set; }

    /// <summary>
    /// The timestamp corresponding to the creation of this Key.
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
    /// The resource id for the Key, which is the same as the Site Key itself.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
