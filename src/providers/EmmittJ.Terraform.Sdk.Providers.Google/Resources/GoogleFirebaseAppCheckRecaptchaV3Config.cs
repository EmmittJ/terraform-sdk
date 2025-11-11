using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_firebase_app_check_recaptcha_v3_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckRecaptchaV3Config : TerraformResource
{
    public GoogleFirebaseAppCheckRecaptchaV3Config(string name) : base("google_firebase_app_check_recaptcha_v3_config", name)
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
    /// The site secret used to identify your service for reCAPTCHA v3 verification.
    /// For security reasons, this field will never be populated in any response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteSecret is required")]
    [TerraformProperty("site_secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SiteSecret { get; set; }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA V3 artifacts will be valid.
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
    public TerraformBlock<GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The relative resource name of the reCAPTCHA V3 configuration object
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Whether the siteSecret was previously set. Since we will never return the siteSecret field, this field is the only way to find out whether it was previously set.
    /// </summary>
    [TerraformProperty("site_secret_set")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SiteSecretSet { get; }

}
