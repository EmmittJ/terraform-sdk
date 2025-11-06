using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dns_response_policy_rule resource.
/// </summary>
public class GoogleDnsResponsePolicyRule : TerraformResource
{
    public GoogleDnsResponsePolicyRule(string name) : base("google_dns_response_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.
    /// </summary>
    public string? DnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_name")?.Value;
        set => this.WithProperty("dns_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    public string? ResponsePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_policy")?.Value;
        set => this.WithProperty("response_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    public string? RuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_name")?.Value;
        set => this.WithProperty("rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
