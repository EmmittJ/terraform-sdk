using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_gateway_security_policy_rule resource.
/// </summary>
public class GoogleNetworkSecurityGatewaySecurityPolicyRule : TerraformResource
{
    public GoogleNetworkSecurityGatewaySecurityPolicyRule(string name) : base("google_network_security_gateway_security_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("self_link");
        SetOutput("update_time");
        SetOutput("application_matcher");
        SetOutput("basic_profile");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("gateway_security_policy");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("project");
        SetOutput("session_matcher");
        SetOutput("tls_inspection_enabled");
    }

    /// <summary>
    /// CEL expression for matching on L7/application level criteria.
    /// </summary>
    public TerraformProperty<string> ApplicationMatcher
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_matcher");
        set => SetProperty("application_matcher", value);
    }

    /// <summary>
    /// Profile which tells what the primitive action should be. Possible values are: * ALLOW * DENY. Possible values: [&amp;quot;BASIC_PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicProfile is required")]
    public required TerraformProperty<string> BasicProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("basic_profile");
        set => SetProperty("basic_profile", value);
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Whether the rule is enforced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name of the gatewat security policy this rule belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewaySecurityPolicy is required")]
    public required TerraformProperty<string> GatewaySecurityPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_security_policy");
        set => SetProperty("gateway_security_policy", value);
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
    /// The location of the gateway security policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Name of the resource. ame is the full resource name so projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}
    /// rule should match the pattern: (^a-z?$).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Priority of the rule. Lower number corresponds to higher precedence.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// CEL expression for matching on session criteria.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionMatcher is required")]
    public required TerraformProperty<string> SessionMatcher
    {
        get => GetRequiredOutput<TerraformProperty<string>>("session_matcher");
        set => SetProperty("session_matcher", value);
    }

    /// <summary>
    /// Flag to enable TLS inspection of traffic matching on. Can only be true if the
    /// parent GatewaySecurityPolicy references a TLSInspectionConfig.
    /// </summary>
    public TerraformProperty<bool> TlsInspectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls_inspection_enabled");
        set => SetProperty("tls_inspection_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityGatewaySecurityPolicyRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
