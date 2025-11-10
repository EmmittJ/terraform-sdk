using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_firebase_app_check_recaptcha_v3_config resource.
/// </summary>
public class GoogleFirebaseAppCheckRecaptchaV3Config : TerraformResource
{
    public GoogleFirebaseAppCheckRecaptchaV3Config(string name) : base("google_firebase_app_check_recaptcha_v3_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("site_secret_set");
        SetOutput("app_id");
        SetOutput("id");
        SetOutput("project");
        SetOutput("site_secret");
        SetOutput("token_ttl");
    }

    /// <summary>
    /// The ID of an
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_id");
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The site secret used to identify your service for reCAPTCHA v3 verification.
    /// For security reasons, this field will never be populated in any response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteSecret is required")]
    public required TerraformProperty<string> SiteSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("site_secret");
        set => SetProperty("site_secret", value);
    }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA V3 artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string> TokenTtl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_ttl");
        set => SetProperty("token_ttl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppCheckRecaptchaV3ConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The relative resource name of the reCAPTCHA V3 configuration object
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Whether the siteSecret was previously set. Since we will never return the siteSecret field, this field is the only way to find out whether it was previously set.
    /// </summary>
    public TerraformExpression SiteSecretSet => this["site_secret_set"];

}
