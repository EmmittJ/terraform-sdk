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
        get => GetProperty<TerraformProperty<bool>>("allow_all_package_names");
        set => WithProperty("allow_all_package_names", value);
    }

    /// <summary>
    /// Android package names of apps allowed to use the key. Example: &#39;com.companyname.appname&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedPackageNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_package_names");
        set => WithProperty("allowed_package_names", value);
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
        get => GetProperty<TerraformProperty<bool>>("allow_all_bundle_ids");
        set => WithProperty("allow_all_bundle_ids", value);
    }

    /// <summary>
    /// iOS bundle ids of apps allowed to use the key. Example: &#39;com.companyname.productname.appname&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedBundleIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_bundle_ids");
        set => WithProperty("allowed_bundle_ids", value);
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
        get => GetProperty<TerraformProperty<string>>("testing_challenge");
        set => WithProperty("testing_challenge", value);
    }

    /// <summary>
    /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
    /// </summary>
    public TerraformProperty<double>? TestingScore
    {
        get => GetProperty<TerraformProperty<double>>("testing_score");
        set => WithProperty("testing_score", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("waf_feature");
        set => WithProperty("waf_feature", value);
    }

    /// <summary>
    /// The WAF service that uses this key. Possible values: CA, FASTLY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafService is required")]
    public required TerraformProperty<string> WafService
    {
        get => GetRequiredProperty<TerraformProperty<string>>("waf_service");
        set => WithProperty("waf_service", value);
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
        get => GetProperty<TerraformProperty<bool>>("allow_all_domains");
        set => WithProperty("allow_all_domains", value);
    }

    /// <summary>
    /// If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
    /// </summary>
    public TerraformProperty<bool>? AllowAmpTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_amp_traffic");
        set => WithProperty("allow_amp_traffic", value);
    }

    /// <summary>
    /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: &#39;example.com&#39; or &#39;subdomain.example.com&#39;
    /// </summary>
    public List<TerraformProperty<string>>? AllowedDomains
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_domains");
        set => WithProperty("allowed_domains", value);
    }

    /// <summary>
    /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY
    /// </summary>
    public TerraformProperty<string>? ChallengeSecurityPreference
    {
        get => GetProperty<TerraformProperty<string>>("challenge_security_preference");
        set => WithProperty("challenge_security_preference", value);
    }

    /// <summary>
    /// Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformProperty<string> IntegrationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("integration_type");
        set => WithProperty("integration_type", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Human-readable display name of this key. Modifiable by user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// See [Creating and managing labels](https://cloud.google.com/recaptcha-enterprise/docs/labels).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for android_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>? AndroidSettings
    {
        get => GetProperty<List<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>>("android_settings");
        set => this.WithProperty("android_settings", value);
    }

    /// <summary>
    /// Block for ios_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>? IosSettings
    {
        get => GetProperty<List<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>>("ios_settings");
        set => this.WithProperty("ios_settings", value);
    }

    /// <summary>
    /// Block for testing_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestingOptions block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>? TestingOptions
    {
        get => GetProperty<List<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>>("testing_options");
        set => this.WithProperty("testing_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleRecaptchaEnterpriseKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleRecaptchaEnterpriseKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for waf_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>? WafSettings
    {
        get => GetProperty<List<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>>("waf_settings");
        set => this.WithProperty("waf_settings", value);
    }

    /// <summary>
    /// Block for web_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSettings block(s) allowed")]
    public List<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>? WebSettings
    {
        get => GetProperty<List<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>>("web_settings");
        set => this.WithProperty("web_settings", value);
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
