using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_security_gateway_security_policy_rule resource.
/// </summary>
public class GoogleNetworkSecurityGatewaySecurityPolicyRule : TerraformResource
{
    public GoogleNetworkSecurityGatewaySecurityPolicyRule(string name) : base("google_network_security_gateway_security_policy_rule", name)
    {
    }

    /// <summary>
    /// CEL expression for matching on L7/application level criteria.
    /// </summary>
    [TerraformPropertyName("application_matcher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationMatcher { get; set; }

    /// <summary>
    /// Profile which tells what the primitive action should be. Possible values are: * ALLOW * DENY. Possible values: [&amp;quot;BASIC_PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicProfile is required")]
    [TerraformPropertyName("basic_profile")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BasicProfile { get; set; }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Whether the rule is enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The name of the gatewat security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewaySecurityPolicy is required")]
    [TerraformPropertyName("gateway_security_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GatewaySecurityPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the gateway security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Name of the resource. ame is the full resource name so projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}
    /// rule should match the pattern: (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Priority of the rule. Lower number corresponds to higher precedence.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// CEL expression for matching on session criteria.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionMatcher is required")]
    [TerraformPropertyName("session_matcher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SessionMatcher { get; set; }

    /// <summary>
    /// Flag to enable TLS inspection of traffic matching on. Can only be true if the
    /// parent GatewaySecurityPolicy references a TLSInspectionConfig.
    /// </summary>
    [TerraformPropertyName("tls_inspection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TlsInspectionEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
