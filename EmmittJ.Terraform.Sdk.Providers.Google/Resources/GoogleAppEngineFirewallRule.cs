using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_firewall_rule resource.
/// </summary>
public class GoogleAppEngineFirewallRule : TerraformResource
{
    public GoogleAppEngineFirewallRule(string name) : base("google_app_engine_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action to take if this rule matches. Possible values: [&amp;quot;UNSPECIFIED_ACTION&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional string description of this rule.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A positive integer that defines the order of rule evaluation.
    /// Rules with the lowest priority are evaluated first.
    /// 
    /// A default rule at priority Int32.MaxValue matches all IPv4 and
    /// IPv6 traffic when no previous rule matches. Only the action of
    /// this rule can be modified by the user.
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
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// </summary>
    public string? SourceRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_range")?.Value;
        set => this.WithProperty("source_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
