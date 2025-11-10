using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock : ITerraformBlock
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
/// Manages a google_firebase_app_check_recaptcha_v3_config resource.
/// </summary>
public class GoogleFirebaseAppCheckRecaptchaV3Config : TerraformResource
{
    public GoogleFirebaseAppCheckRecaptchaV3Config(string name) : base("google_firebase_app_check_recaptcha_v3_config", name)
    {
    }

    /// <summary>
    /// The ID of an
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The site secret used to identify your service for reCAPTCHA v3 verification.
    /// For security reasons, this field will never be populated in any response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteSecret is required")]
    [TerraformPropertyName("site_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SiteSecret { get; set; }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA V3 artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("token_ttl")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TokenTtl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token_ttl");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The relative resource name of the reCAPTCHA V3 configuration object
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Whether the siteSecret was previously set. Since we will never return the siteSecret field, this field is the only way to find out whether it was previously set.
    /// </summary>
    [TerraformPropertyName("site_secret_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SiteSecretSet => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "site_secret_set");

}
