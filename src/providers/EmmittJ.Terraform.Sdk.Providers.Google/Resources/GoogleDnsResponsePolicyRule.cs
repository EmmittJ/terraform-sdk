using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_data in GoogleDnsResponsePolicyRule.
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyRuleLocalDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_data";

    /// <summary>
    /// LocalDatas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDatas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDatas block(s) required")]
    public required TerraformList<GoogleDnsResponsePolicyRuleLocalDataBlockLocalDatasBlock> LocalDatas
    {
        get => GetRequiredArgument<TerraformList<GoogleDnsResponsePolicyRuleLocalDataBlockLocalDatasBlock>>("local_datas");
        set => SetArgument("local_datas", value);
    }

}

/// <summary>
/// Block type for local_datas in GoogleDnsResponsePolicyRuleLocalDataBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyRuleLocalDataBlockLocalDatasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_datas";

    /// <summary>
    /// For example, www.example.com.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// As defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1)
    /// </summary>
    public TerraformList<string>? Rrdatas
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "rrdatas").ResolveNodes(ctx));
        set => SetArgument("rrdatas", value);
    }

    /// <summary>
    /// Number of seconds that this ResourceRecordSet can be cached by
    /// resolvers.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// One of valid DNS resource types. Possible values: [&amp;quot;A&amp;quot;, &amp;quot;AAAA&amp;quot;, &amp;quot;CAA&amp;quot;, &amp;quot;CNAME&amp;quot;, &amp;quot;DNSKEY&amp;quot;, &amp;quot;DS&amp;quot;, &amp;quot;HTTPS&amp;quot;, &amp;quot;IPSECVPNKEY&amp;quot;, &amp;quot;MX&amp;quot;, &amp;quot;NAPTR&amp;quot;, &amp;quot;NS&amp;quot;, &amp;quot;PTR&amp;quot;, &amp;quot;SOA&amp;quot;, &amp;quot;SPF&amp;quot;, &amp;quot;SRV&amp;quot;, &amp;quot;SSHFP&amp;quot;, &amp;quot;SVCB&amp;quot;, &amp;quot;TLSA&amp;quot;, &amp;quot;TXT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDnsResponsePolicyRule.
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_dns_response_policy_rule Terraform resource.
/// Manages a google_dns_response_policy_rule resource.
/// </summary>
public partial class GoogleDnsResponsePolicyRule(string name) : TerraformResource("google_dns_response_policy_rule", name)
{
    /// <summary>
    /// The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    public required TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
        set => SetArgument("dns_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicy is required")]
    public required TerraformValue<string> ResponsePolicy
    {
        get => new TerraformReference<string>(this, "response_policy");
        set => SetArgument("response_policy", value);
    }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// LocalData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalData block(s) allowed")]
    public TerraformList<GoogleDnsResponsePolicyRuleLocalDataBlock>? LocalData
    {
        get => GetArgument<TerraformList<GoogleDnsResponsePolicyRuleLocalDataBlock>>("local_data");
        set => SetArgument("local_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDnsResponsePolicyRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDnsResponsePolicyRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
