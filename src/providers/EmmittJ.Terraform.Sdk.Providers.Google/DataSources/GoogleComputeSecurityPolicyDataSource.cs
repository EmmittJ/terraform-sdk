using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_security_policy.
/// </summary>
public class GoogleComputeSecurityPolicyDataSource : TerraformDataSource
{
    public GoogleComputeSecurityPolicyDataSource(string name) : base("google_compute_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("adaptive_protection_config");
        SetOutput("advanced_options_config");
        SetOutput("description");
        SetOutput("effective_labels");
        SetOutput("fingerprint");
        SetOutput("label_fingerprint");
        SetOutput("labels");
        SetOutput("recaptcha_options_config");
        SetOutput("rule");
        SetOutput("terraform_labels");
        SetOutput("type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("self_link");
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
    /// The name of the security policy.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformProperty<string> SelfLink
    {
        get => GetRequiredOutput<TerraformProperty<string>>("self_link");
        set => SetProperty("self_link", value);
    }

    /// <summary>
    /// Adaptive Protection Config of this security policy.
    /// </summary>
    public TerraformExpression AdaptiveProtectionConfig => this["adaptive_protection_config"];

    /// <summary>
    /// Advanced Options Config of this security policy.
    /// </summary>
    public TerraformExpression AdvancedOptionsConfig => this["advanced_options_config"];

    /// <summary>
    /// An optional description of this security policy. Max size is 2048.
    /// </summary>
    public TerraformExpression Description => this["description"];

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
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// reCAPTCHA configuration options to be applied for the security policy.
    /// </summary>
    public TerraformExpression RecaptchaOptionsConfig => this["recaptcha_options_config"];

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &amp;quot;*&amp;quot;). If no rules are provided when creating a security policy, a default rule with action &amp;quot;allow&amp;quot; will be added.
    /// </summary>
    public TerraformExpression Rule => this["rule"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
