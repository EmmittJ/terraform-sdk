using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for advanced_options_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// JSON body parsing. Supported values include: &amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_WITH_GRAPHQL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? JsonParsing
    {
        set => SetProperty("json_parsing", value);
    }

    /// <summary>
    /// Logging level. Supported values include: &amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;. Possible values: [&amp;quot;NORMAL&amp;quot;, &amp;quot;VERBOSE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        set => SetProperty("log_level", value);
    }

    /// <summary>
    /// An optional list of case-insensitive request header names to use for resolving the callers client IP address.
    /// </summary>
    public HashSet<TerraformProperty<string>>? UserIpRequestHeaders
    {
        set => SetProperty("user_ip_request_headers", value);
    }

}

/// <summary>
/// Block type for ddos_protection_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Google Cloud Armor offers the following options to help protect systems against DDoS attacks:
    /// - STANDARD: basic always-on protection for network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED: additional protections for Managed Protection Plus subscribers who use network load balancers, protocol forwarding, or VMs with public IP addresses.
    /// - ADVANCED_PREVIEW: flag to enable the security policy in preview mode. Possible values: [&amp;quot;ADVANCED&amp;quot;, &amp;quot;ADVANCED_PREVIEW&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DdosProtection is required")]
    public required TerraformProperty<string> DdosProtection
    {
        set => SetProperty("ddos_protection", value);
    }

}

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// The Action to perform when the rule is matched. The following are the valid actions:
    /// 
    /// * allow: allow access to target.
    /// 
    /// * deny(STATUS): deny access to target, returns the HTTP response code specified. Valid values for STATUS are 403, 404, and 502.
    /// 
    /// * rate_based_ban: limit client traffic to the configured threshold and ban the client if the traffic exceeds the threshold. Configure parameters for this action in RateLimitOptions. Requires rateLimitOptions to be set.
    /// 
    /// * redirect: redirect to a different target. This can either be an internal reCAPTCHA redirect, or an external URL-based redirect via a 302 response. Parameters for this action can be configured via redirectOptions. This action is only supported in Global Security Policies of type CLOUD_ARMOR.
    /// 
    /// * throttle: limit client traffic to the configured threshold. Configure parameters for this action in rateLimitOptions. Requires rateLimitOptions to be set for this.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If set to true, the specified action is not enforced.
    /// </summary>
    public TerraformProperty<bool>? Preview
    {
        set => SetProperty("preview", value);
    }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionSecurityPolicyTimeoutsBlock : TerraformBlock
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
/// Block type for user_defined_fields in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// The base relative to which &#39;offset&#39; is measured. Possible values are:
    /// - IPV4: Points to the beginning of the IPv4 header.
    /// - IPV6: Points to the beginning of the IPv6 header.
    /// - TCP: Points to the beginning of the TCP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments.
    /// - UDP: Points to the beginning of the UDP header, skipping over any IPv4 options or IPv6 extension headers. Not present for non-first fragments. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;, &amp;quot;TCP&amp;quot;, &amp;quot;UDP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Base is required")]
    public required TerraformProperty<string> Base
    {
        set => SetProperty("base", value);
    }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &amp;quot;0x&amp;quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    public TerraformProperty<string>? Mask
    {
        set => SetProperty("mask", value);
    }

    /// <summary>
    /// The name of this field. Must be unique within the policy.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Offset of the first byte of the field (in network byte order) relative to &#39;base&#39;.
    /// </summary>
    public TerraformProperty<double>? Offset
    {
        set => SetProperty("offset", value);
    }

    /// <summary>
    /// Size of the field in bytes. Valid values: 1-4.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        set => SetProperty("size", value);
    }

}

/// <summary>
/// Manages a google_compute_region_security_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionSecurityPolicy : TerraformResource
{
    public GoogleComputeRegionSecurityPolicy(string name) : base("google_compute_region_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fingerprint");
        SetOutput("policy_id");
        SetOutput("self_link");
        SetOutput("self_link_with_policy_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("type");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The type indicates the intended use of the security policy.
    /// - CLOUD_ARMOR: Cloud Armor backend security policies can be configured to filter incoming HTTP requests targeting backend services. They filter requests before they hit the origin servers.
    /// - CLOUD_ARMOR_EDGE: Cloud Armor edge security policies can be configured to filter incoming HTTP requests targeting backend services (including Cloud CDN-enabled) as well as backend buckets (Cloud Storage). They filter requests before the request is served from Google&#39;s cache.
    /// - CLOUD_ARMOR_NETWORK: Cloud Armor network policies can be configured to filter packets targeting network load balancing resources such as backend services, target pools, target instances, and instances with external IPs. They filter requests before the request is served from the application.
    /// This field can be set only at resource creation time. Possible values: [&amp;quot;CLOUD_ARMOR&amp;quot;, &amp;quot;CLOUD_ARMOR_EDGE&amp;quot;, &amp;quot;CLOUD_ARMOR_NETWORK&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for advanced_options_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedOptionsConfig block(s) allowed")]
    public List<GoogleComputeRegionSecurityPolicyAdvancedOptionsConfigBlock>? AdvancedOptionsConfig
    {
        set => SetProperty("advanced_options_config", value);
    }

    /// <summary>
    /// Block for ddos_protection_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DdosProtectionConfig block(s) allowed")]
    public List<GoogleComputeRegionSecurityPolicyDdosProtectionConfigBlock>? DdosProtectionConfig
    {
        set => SetProperty("ddos_protection_config", value);
    }

    /// <summary>
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionSecurityPolicyRulesBlock>? Rules
    {
        set => SetProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionSecurityPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_defined_fields.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionSecurityPolicyUserDefinedFieldsBlock>? UserDefinedFields
    {
        set => SetProperty("user_defined_fields", value);
    }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression PolicyId => this["policy_id"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformExpression SelfLinkWithPolicyId => this["self_link_with_policy_id"];

}
