using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppCheckRecaptchaEnterpriseConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_firebase_app_check_recaptcha_enterprise_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckRecaptchaEnterpriseConfig : TerraformResource
{
    public GoogleFirebaseAppCheckRecaptchaEnterpriseConfig(string name) : base("google_firebase_app_check_recaptcha_enterprise_config", name)
    {
    }

    /// <summary>
    /// The ID of an
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The score-based site key created in reCAPTCHA Enterprise used to invoke reCAPTCHA and generate the reCAPTCHA tokens for your application.
    /// 
    /// **Important**: This is not the siteSecret (as it is in reCAPTCHA v3), but rather your score-based reCAPTCHA Enterprise site key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteKey is required")]
    [TerraformProperty("site_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SiteKey { get; set; }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA Enterprise artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("token_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TokenTtl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleFirebaseAppCheckRecaptchaEnterpriseConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The relative resource name of the reCAPTCHA Enterprise configuration object
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
