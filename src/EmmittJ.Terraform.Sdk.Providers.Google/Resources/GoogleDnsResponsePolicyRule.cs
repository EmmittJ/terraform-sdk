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
    public TerraformLiteralProperty<string>? DnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_name");
        set => this.WithProperty("dns_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    public TerraformLiteralProperty<string>? ResponsePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_policy");
        set => this.WithProperty("response_policy", value);
    }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    public TerraformLiteralProperty<string>? RuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

}
