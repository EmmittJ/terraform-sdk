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
    public TerraformProperty<string>? DnsName
    {
        get => GetProperty<TerraformProperty<string>>("dns_name");
        set => this.WithProperty("dns_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    public TerraformProperty<string>? ResponsePolicy
    {
        get => GetProperty<TerraformProperty<string>>("response_policy");
        set => this.WithProperty("response_policy", value);
    }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

}
