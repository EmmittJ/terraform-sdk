using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("name");
        this.DeclareOutput("site_secret_set");
    }

    /// <summary>
    /// The ID of an
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id).
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The site secret used to identify your service for reCAPTCHA v3 verification.
    /// For security reasons, this field will never be populated in any response.
    /// </summary>
    public string? SiteSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("site_secret")?.Value;
        set => this.WithProperty("site_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA V3 artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public string? TokenTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_ttl")?.Value;
        set => this.WithProperty("token_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
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
