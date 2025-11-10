using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for local_data in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyRuleLocalDataBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a google_dns_response_policy_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDnsResponsePolicyRule : TerraformResource
{
    public GoogleDnsResponsePolicyRule(string name) : base("google_dns_response_policy_rule", name)
    {
    }

    /// <summary>
    /// The DNS name (wildcard or exact) to apply this rule to. Must be unique within the Response Policy Rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    [TerraformPropertyName("dns_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DnsName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Identifies the response policy addressed by this request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicy is required")]
    [TerraformPropertyName("response_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResponsePolicy { get; set; }

    /// <summary>
    /// An identifier for this rule. Must be unique with the ResponsePolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformPropertyName("rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleName { get; set; }

    /// <summary>
    /// Block for local_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalData block(s) allowed")]
    [TerraformPropertyName("local_data")]
    public TerraformList<TerraformBlock<GoogleDnsResponsePolicyRuleLocalDataBlock>>? LocalData { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDnsResponsePolicyRuleTimeoutsBlock>? Timeouts { get; set; } = new();

}
