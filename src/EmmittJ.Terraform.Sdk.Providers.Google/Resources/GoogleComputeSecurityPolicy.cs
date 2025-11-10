using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for adaptive_protection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for advanced_options_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? JsonParsing
    {
        get => GetProperty<TerraformProperty<string>>("json_parsing");
        set => WithProperty("json_parsing", value);
    }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        get => GetProperty<TerraformProperty<string>>("log_level");
        set => WithProperty("log_level", value);
    }

    /// <summary>
    /// An optional list of case-insensitive request header names to use for resolving the callers client IP address.
    /// </summary>
    public HashSet<TerraformProperty<string>>? UserIpRequestHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("user_ip_request_headers");
        set => WithProperty("user_ip_request_headers", value);
    }

}

/// <summary>
/// Block type for recaptcha_options_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// A field to supply a reCAPTCHA site key to be used for all the rules using the redirect action with the type of GOOGLE_RECAPTCHA under the security policy. The specified site key needs to be created from the reCAPTCHA API. The user is responsible for the validity of the specified site key. If not specified, a Google-managed site key is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectSiteKey is required")]
    public required TerraformProperty<string> RedirectSiteKey
    {
        get => GetProperty<TerraformProperty<string>>("redirect_site_key");
        set => WithProperty("redirect_site_key", value);
    }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeSecurityPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Action to take when match matches the request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// An optional description of this rule. Max size is 64.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// When set to true, the action specified above is not enforced. Stackdriver logs for requests that trigger a preview action are annotated as such.
    /// </summary>
    public TerraformProperty<bool>? Preview
    {
        get => GetProperty<TerraformProperty<bool>>("preview");
        set => WithProperty("preview", value);
    }

    /// <summary>
    /// An unique positive integer indicating the priority of evaluation for a rule. Rules are evaluated from highest priority (lowest numerically) to lowest priority (highest numerically) in order.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSecurityPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_compute_security_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeSecurityPolicy : TerraformResource
{
    public GoogleComputeSecurityPolicy(string name) : base("google_compute_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// An optional description of this security policy. Max size is 2048.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for adaptive_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdaptiveProtectionConfig block(s) allowed")]
    public List<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock>? AdaptiveProtectionConfig
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyAdaptiveProtectionConfigBlock>>("adaptive_protection_config");
        set => this.WithProperty("adaptive_protection_config", value);
    }

    /// <summary>
    /// Block for advanced_options_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    public List<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock>? AdvancedOptionsConfig
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyAdvancedOptionsConfigBlock>>("advanced_options_config");
        set => this.WithProperty("advanced_options_config", value);
    }

    /// <summary>
    /// Block for recaptcha_options_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecaptchaOptionsConfig block(s) allowed")]
    public List<GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock>? RecaptchaOptionsConfig
    {
        get => GetProperty<List<GoogleComputeSecurityPolicyRecaptchaOptionsConfigBlock>>("recaptcha_options_config");
        set => this.WithProperty("recaptcha_options_config", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeSecurityPolicyRuleBlock>? Rule
    {
        get => GetProperty<HashSet<GoogleComputeSecurityPolicyRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeSecurityPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeSecurityPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Fingerprint of this resource.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
