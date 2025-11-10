using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for android_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, it means allowed_package_names will not be enforced.
    /// </summary>
    public TerraformProperty<bool>? AllowAllPackageNames
    {
        set => SetProperty("allow_all_package_names", value);
    }

    /// <summary>
    /// Android package names of apps allowed to use the key. Example: &#39;com.companyname.appname&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedPackageNames
    {
        set => SetProperty("allowed_package_names", value);
    }

}

/// <summary>
/// Block type for ios_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyIosSettingsBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, it means allowed_bundle_ids will not be enforced.
    /// </summary>
    public TerraformProperty<bool>? AllowAllBundleIds
    {
        set => SetProperty("allow_all_bundle_ids", value);
    }

    /// <summary>
    /// iOS bundle ids of apps allowed to use the key. Example: &#39;com.companyname.productname.appname&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedBundleIds
    {
        set => SetProperty("allowed_bundle_ids", value);
    }

}

/// <summary>
/// Block type for testing_options in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTestingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if UNSOLVABLE_CHALLENGE. Possible values: TESTING_CHALLENGE_UNSPECIFIED, NOCAPTCHA, UNSOLVABLE_CHALLENGE
    /// </summary>
    public TerraformProperty<string>? TestingChallenge
    {
        set => SetProperty("testing_challenge", value);
    }

    /// <summary>
    /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
    /// </summary>
    public TerraformProperty<double>? TestingScore
    {
        set => SetProperty("testing_score", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTimeoutsBlock : TerraformBlock
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
/// Block type for waf_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWafSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Supported WAF features. For more information, see https://cloud.google.com/recaptcha-enterprise/docs/usecase#comparison_of_features. Possible values: CHALLENGE_PAGE, SESSION_TOKEN, ACTION_TOKEN, EXPRESS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafFeature is required")]
    public required TerraformProperty<string> WafFeature
    {
        set => SetProperty("waf_feature", value);
    }

    /// <summary>
    /// The WAF service that uses this key. Possible values: CA, FASTLY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafService is required")]
    public required TerraformProperty<string> WafService
    {
        set => SetProperty("waf_service", value);
    }

}

/// <summary>
/// Block type for web_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWebSettingsBlock : TerraformBlock
{
    /// <summary>
    /// If set to true, it means allowed_domains will not be enforced.
    /// </summary>
    public TerraformProperty<bool>? AllowAllDomains
    {
        set => SetProperty("allow_all_domains", value);
    }

    /// <summary>
    /// If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
    /// </summary>
    public TerraformProperty<bool>? AllowAmpTraffic
    {
        set => SetProperty("allow_amp_traffic", value);
    }

    /// <summary>
    /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: &#39;example.com&#39; or &#39;subdomain.example.com&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedDomains
    {
        set => SetProperty("allowed_domains", value);
    }

    /// <summary>
    /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY
    /// </summary>
    public TerraformProperty<string>? ChallengeSecurityPreference
    {
        set => SetProperty("challenge_security_preference", value);
    }

    /// <summary>
    /// Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformProperty<string> IntegrationType
    {
        set => SetProperty("integration_type", value);
    }

}

/// <summary>
/// Manages a google_recaptcha_enterprise_key resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleRecaptchaEnterpriseKey : TerraformResource
{
    public GoogleRecaptchaEnterpriseKey(string name) : base("google_recaptcha_enterprise_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("project");
    }

    /// <summary>
    /// Human-readable display name of this key. Modifiable by user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// See [Creating and managing labels](https://cloud.google.com/recaptcha-enterprise/docs/labels).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for android_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>? AndroidSettings
    {
        set => SetProperty("android_settings", value);
    }

    /// <summary>
    /// Block for ios_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>? IosSettings
    {
        set => SetProperty("ios_settings", value);
    }

    /// <summary>
    /// Block for testing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestingOptions block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>? TestingOptions
    {
        set => SetProperty("testing_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleRecaptchaEnterpriseKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for waf_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>? WafSettings
    {
        set => SetProperty("waf_settings", value);
    }

    /// <summary>
    /// Block for web_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>? WebSettings
    {
        set => SetProperty("web_settings", value);
    }

    /// <summary>
    /// The timestamp corresponding to the creation of this Key.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource id for the Key, which is the same as the Site Key itself.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
