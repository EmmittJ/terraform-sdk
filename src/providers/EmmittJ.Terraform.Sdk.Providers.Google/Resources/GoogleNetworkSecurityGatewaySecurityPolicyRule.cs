using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityGatewaySecurityPolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_gateway_security_policy_rule Terraform resource.
/// Manages a google_network_security_gateway_security_policy_rule resource.
/// </summary>
public partial class GoogleNetworkSecurityGatewaySecurityPolicyRule(string name) : TerraformResource("google_network_security_gateway_security_policy_rule", name)
{
    /// <summary>
    /// CEL expression for matching on L7/application level criteria.
    /// </summary>
    public TerraformValue<string>? ApplicationMatcher
    {
        get => new TerraformReference<string>(this, "application_matcher");
        set => SetArgument("application_matcher", value);
    }

    /// <summary>
    /// Profile which tells what the primitive action should be. Possible values are: * ALLOW * DENY. Possible values: [&amp;quot;BASIC_PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicProfile is required")]
    public required TerraformValue<string> BasicProfile
    {
        get => new TerraformReference<string>(this, "basic_profile");
        set => SetArgument("basic_profile", value);
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Whether the rule is enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name of the gatewat security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewaySecurityPolicy is required")]
    public required TerraformValue<string> GatewaySecurityPolicy
    {
        get => new TerraformReference<string>(this, "gateway_security_policy");
        set => SetArgument("gateway_security_policy", value);
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
    /// The location of the gateway security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the resource. ame is the full resource name so projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}
    /// rule should match the pattern: (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Priority of the rule. Lower number corresponds to higher precedence.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
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
    /// CEL expression for matching on session criteria.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionMatcher is required")]
    public required TerraformValue<string> SessionMatcher
    {
        get => new TerraformReference<string>(this, "session_matcher");
        set => SetArgument("session_matcher", value);
    }

    /// <summary>
    /// Flag to enable TLS inspection of traffic matching on. Can only be true if the
    /// parent GatewaySecurityPolicy references a TLSInspectionConfig.
    /// </summary>
    public TerraformValue<bool>? TlsInspectionEnabled
    {
        get => new TerraformReference<bool>(this, "tls_inspection_enabled");
        set => SetArgument("tls_inspection_enabled", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The timestamp when the resource was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
