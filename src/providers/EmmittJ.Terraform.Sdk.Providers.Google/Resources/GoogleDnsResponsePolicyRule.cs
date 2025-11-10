using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_data in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyRuleLocalDataBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_dns_response_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsResponsePolicyRule : TerraformResource
{
    public GoogleDnsResponsePolicyRule(string name) : base("google_dns_response_policy_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_name");
        SetOutput("id");
        SetOutput("project");
        SetOutput("response_policy");
        SetOutput("rule_name");
    }

    /// <summary>
    /// The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    public required TerraformProperty<string> DnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name");
        set => SetProperty("dns_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicy is required")]
    public required TerraformProperty<string> ResponsePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("response_policy");
        set => SetProperty("response_policy", value);
    }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_name");
        set => SetProperty("rule_name", value);
    }

    /// <summary>
    /// Block for local_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalData block(s) allowed")]
    public List<GoogleDnsResponsePolicyRuleLocalDataBlock>? LocalData
    {
        set => SetProperty("local_data", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDnsResponsePolicyRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
