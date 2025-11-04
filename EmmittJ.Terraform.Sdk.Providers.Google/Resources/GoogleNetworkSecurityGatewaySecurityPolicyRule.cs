using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("self_link");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// CEL expression for matching on L7/application level criteria.
    /// </summary>
    public string? ApplicationMatcher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_matcher")?.Value;
        set => this.WithProperty("application_matcher", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Profile which tells what the primitive action should be. Possible values are: * ALLOW * DENY. Possible values: [&amp;quot;BASIC_PROFILE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    public string? BasicProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("basic_profile")?.Value;
        set => this.WithProperty("basic_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the rule is enforced.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the gatewat security policy this rule belongs to.
    /// </summary>
    public string? GatewaySecurityPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_security_policy")?.Value;
        set => this.WithProperty("gateway_security_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the gateway security policy.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource. ame is the full resource name so projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}/rules/{rule}
    /// rule should match the pattern: (^a-z?$).
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Priority of the rule. Lower number corresponds to higher precedence.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// CEL expression for matching on session criteria.
    /// </summary>
    public string? SessionMatcher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_matcher")?.Value;
        set => this.WithProperty("session_matcher", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Flag to enable TLS inspection of traffic matching on. Can only be true if the
    /// parent GatewaySecurityPolicy references a TLSInspectionConfig.
    /// </summary>
    public bool? TlsInspectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_inspection_enabled")?.Value;
        set => this.WithProperty("tls_inspection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
