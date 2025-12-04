using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_security_policy Terraform data source.
/// Retrieves information about a google_compute_security_policy.
/// </summary>
public partial class GoogleComputeSecurityPolicyDataSource(string name) : TerraformDataSource("google_compute_security_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the security policy.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string>? SelfLink
    {
        get => GetArgument<TerraformValue<string>>("self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// Adaptive Protection Config of this security policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdaptiveProtectionConfig
        => AsReference("adaptive_protection_config");

    /// <summary>
    /// Advanced Options Config of this security policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdvancedOptionsConfig
        => AsReference("advanced_options_config");

    /// <summary>
    /// An optional description of this security policy. Max size is 2048.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Fingerprint of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// The unique fingerprint of the labels.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// reCAPTCHA configuration options to be applied for the security policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> RecaptchaOptionsConfig
        => AsReference("recaptcha_options_config");

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &amp;quot;*&amp;quot;). If no rules are provided when creating a security policy, a default rule with action &amp;quot;allow&amp;quot; will be added.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Rule
        => AsReference("rule");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The type indicates the intended use of the security policy. CLOUD_ARMOR - Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers. CLOUD_ARMOR_EDGE - Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}
