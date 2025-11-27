using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseAppCheckRecaptchaEnterpriseConfig.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppCheckRecaptchaEnterpriseConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_check_recaptcha_enterprise_config Terraform resource.
/// Manages a google_firebase_app_check_recaptcha_enterprise_config resource.
/// </summary>
public partial class GoogleFirebaseAppCheckRecaptchaEnterpriseConfig(string name) : TerraformResource("google_firebase_app_check_recaptcha_enterprise_config", name)
{
    /// <summary>
    /// The ID of an
    /// [Web App](https://firebase.google.com/docs/reference/firebase-management/rest/v1beta1/projects.webApps#WebApp.FIELDS.app_id).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The score-based site key created in reCAPTCHA Enterprise used to invoke reCAPTCHA and generate the reCAPTCHA tokens for your application.
    /// 
    /// **Important**: This is not the siteSecret (as it is in reCAPTCHA v3), but rather your score-based reCAPTCHA Enterprise site key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteKey is required")]
    public required TerraformValue<string> SiteKey
    {
        get => new TerraformReference<string>(this, "site_key");
        set => SetArgument("site_key", value);
    }

    /// <summary>
    /// Specifies the duration for which App Check tokens exchanged from reCAPTCHA Enterprise artifacts will be valid.
    /// If unset, a default value of 1 hour is assumed. Must be between 30 minutes and 7 days, inclusive.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> TokenTtl
    {
        get => new TerraformReference<string>(this, "token_ttl");
        set => SetArgument("token_ttl", value);
    }

    /// <summary>
    /// The relative resource name of the reCAPTCHA Enterprise configuration object
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppCheckRecaptchaEnterpriseConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppCheckRecaptchaEnterpriseConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
