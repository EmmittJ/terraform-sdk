using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_security_gateway_security_policy_rule resource.
/// </summary>
public partial class GoogleNetworkSecurityGatewaySecurityPolicyRule : TerraformResource
{
    public GoogleNetworkSecurityGatewaySecurityPolicyRule(string name) : base("google_network_security_gateway_security_policy_rule", name)
    {
    }

    /// <summary>
    /// CEL expression for matching on L7/application level criteria.
    /// </summary>
    [TerraformProperty("application_matcher")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationMatcher { get; set; }

    /// <summary>
    /// Profile which tells what the primitive action should be. Possible values are: * ALLOW * DENY. Possible values: [&amp;quot;BASIC_PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicProfile is required")]
    [TerraformProperty("basic_profile")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BasicProfile { get; set; }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether the rule is enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The name of the gatewat security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewaySecurityPolicy is required")]
    [TerraformProperty("gateway_security_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GatewaySecurityPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the gateway security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of the resource. ame is the full resource name so projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}
    /// rule should match the pattern: (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Priority of the rule. Lower number corresponds to higher precedence.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// CEL expression for matching on session criteria.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionMatcher is required")]
    [TerraformProperty("session_matcher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SessionMatcher { get; set; }

    /// <summary>
    /// Flag to enable TLS inspection of traffic matching on. Can only be true if the
    /// parent GatewaySecurityPolicy references a TLSInspectionConfig.
    /// </summary>
    [TerraformProperty("tls_inspection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TlsInspectionEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The timestamp when the resource was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
