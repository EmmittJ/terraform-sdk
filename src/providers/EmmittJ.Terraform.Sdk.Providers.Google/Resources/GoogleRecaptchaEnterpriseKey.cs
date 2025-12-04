using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for android_settings in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "android_settings";

    /// <summary>
    /// If set to true, it means allowed_package_names will not be enforced.
    /// </summary>
    public TerraformValue<bool>? AllowAllPackageNames
    {
        get => GetArgument<TerraformValue<bool>>("allow_all_package_names");
        set => SetArgument("allow_all_package_names", value);
    }

    /// <summary>
    /// Android package names of apps allowed to use the key. Example: &#39;com.companyname.appname&#39;
    /// </summary>
    public TerraformList<string>? AllowedPackageNames
    {
        get => GetArgument<TerraformList<string>>("allowed_package_names");
        set => SetArgument("allowed_package_names", value);
    }

}


/// <summary>
/// Block type for ios_settings in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyIosSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ios_settings";

    /// <summary>
    /// If set to true, it means allowed_bundle_ids will not be enforced.
    /// </summary>
    public TerraformValue<bool>? AllowAllBundleIds
    {
        get => GetArgument<TerraformValue<bool>>("allow_all_bundle_ids");
        set => SetArgument("allow_all_bundle_ids", value);
    }

    /// <summary>
    /// iOS bundle ids of apps allowed to use the key. Example: &#39;com.companyname.productname.appname&#39;
    /// </summary>
    public TerraformList<string>? AllowedBundleIds
    {
        get => GetArgument<TerraformList<string>>("allowed_bundle_ids");
        set => SetArgument("allowed_bundle_ids", value);
    }

}


/// <summary>
/// Block type for testing_options in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTestingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "testing_options";

    /// <summary>
    /// For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if UNSOLVABLE_CHALLENGE. Possible values: TESTING_CHALLENGE_UNSPECIFIED, NOCAPTCHA, UNSOLVABLE_CHALLENGE
    /// </summary>
    public TerraformValue<string>? TestingChallenge
    {
        get => GetArgument<TerraformValue<string>>("testing_challenge");
        set => SetArgument("testing_challenge", value);
    }

    /// <summary>
    /// All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.
    /// </summary>
    public TerraformValue<double>? TestingScore
    {
        get => GetArgument<TerraformValue<double>>("testing_score");
        set => SetArgument("testing_score", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: single
/// </summary>
public class GoogleRecaptchaEnterpriseKeyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for waf_settings in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWafSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "waf_settings";

    /// <summary>
    /// Supported WAF features. For more information, see https://cloud.google.com/recaptcha-enterprise/docs/usecase#comparison_of_features. Possible values: CHALLENGE_PAGE, SESSION_TOKEN, ACTION_TOKEN, EXPRESS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafFeature is required")]
    public required TerraformValue<string> WafFeature
    {
        get => GetArgument<TerraformValue<string>>("waf_feature");
        set => SetArgument("waf_feature", value);
    }

    /// <summary>
    /// The WAF service that uses this key. Possible values: CA, FASTLY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WafService is required")]
    public required TerraformValue<string> WafService
    {
        get => GetArgument<TerraformValue<string>>("waf_service");
        set => SetArgument("waf_service", value);
    }

}


/// <summary>
/// Block type for web_settings in GoogleRecaptchaEnterpriseKey.
/// Nesting mode: list
/// </summary>
public class GoogleRecaptchaEnterpriseKeyWebSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_settings";

    /// <summary>
    /// If set to true, it means allowed_domains will not be enforced.
    /// </summary>
    public TerraformValue<bool>? AllowAllDomains
    {
        get => GetArgument<TerraformValue<bool>>("allow_all_domains");
        set => SetArgument("allow_all_domains", value);
    }

    /// <summary>
    /// If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.
    /// </summary>
    public TerraformValue<bool>? AllowAmpTraffic
    {
        get => GetArgument<TerraformValue<bool>>("allow_amp_traffic");
        set => SetArgument("allow_amp_traffic", value);
    }

    /// <summary>
    /// Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: &#39;example.com&#39; or &#39;subdomain.example.com&#39;
    /// </summary>
    public TerraformList<string>? AllowedDomains
    {
        get => GetArgument<TerraformList<string>>("allowed_domains");
        set => SetArgument("allowed_domains", value);
    }

    /// <summary>
    /// Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY
    /// </summary>
    public TerraformValue<string>? ChallengeSecurityPreference
    {
        get => GetArgument<TerraformValue<string>>("challenge_security_preference");
        set => SetArgument("challenge_security_preference", value);
    }

    /// <summary>
    /// Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformValue<string> IntegrationType
    {
        get => GetArgument<TerraformValue<string>>("integration_type");
        set => SetArgument("integration_type", value);
    }

}


/// <summary>
/// Represents a google_recaptcha_enterprise_key Terraform resource.
/// Manages a google_recaptcha_enterprise_key resource.
/// </summary>
public partial class GoogleRecaptchaEnterpriseKey(string name) : TerraformResource("google_recaptcha_enterprise_key", name)
{
    /// <summary>
    /// Human-readable display name of this key. Modifiable by user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// See [Creating and managing labels](https://cloud.google.com/recaptcha-enterprise/docs/labels).
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The timestamp corresponding to the creation of this Key.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource id for the Key, which is the same as the Site Key itself.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// AndroidSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidSettings block(s) allowed")]
    public TerraformList<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>? AndroidSettings
    {
        get => GetArgument<TerraformList<GoogleRecaptchaEnterpriseKeyAndroidSettingsBlock>>("android_settings");
        set => SetArgument("android_settings", value);
    }

    /// <summary>
    /// IosSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosSettings block(s) allowed")]
    public TerraformList<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>? IosSettings
    {
        get => GetArgument<TerraformList<GoogleRecaptchaEnterpriseKeyIosSettingsBlock>>("ios_settings");
        set => SetArgument("ios_settings", value);
    }

    /// <summary>
    /// TestingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestingOptions block(s) allowed")]
    public TerraformList<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>? TestingOptions
    {
        get => GetArgument<TerraformList<GoogleRecaptchaEnterpriseKeyTestingOptionsBlock>>("testing_options");
        set => SetArgument("testing_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleRecaptchaEnterpriseKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleRecaptchaEnterpriseKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WafSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WafSettings block(s) allowed")]
    public TerraformList<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>? WafSettings
    {
        get => GetArgument<TerraformList<GoogleRecaptchaEnterpriseKeyWafSettingsBlock>>("waf_settings");
        set => SetArgument("waf_settings", value);
    }

    /// <summary>
    /// WebSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebSettings block(s) allowed")]
    public TerraformList<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>? WebSettings
    {
        get => GetArgument<TerraformList<GoogleRecaptchaEnterpriseKeyWebSettingsBlock>>("web_settings");
        set => SetArgument("web_settings", value);
    }

}
