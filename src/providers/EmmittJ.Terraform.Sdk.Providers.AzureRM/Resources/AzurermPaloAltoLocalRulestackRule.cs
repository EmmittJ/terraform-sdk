using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleCategoryBlock
{
    /// <summary>
    /// The custom_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomUrls is required")]
    [TerraformPropertyName("custom_urls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? CustomUrls { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformPropertyName("feeds")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Feeds { get; set; }

}

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleDestinationBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformPropertyName("cidrs")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Cidrs { get; set; }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformPropertyName("countries")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Countries { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformPropertyName("feeds")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Feeds { get; set; }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    [TerraformPropertyName("local_rulestack_fqdn_list_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LocalRulestackFqdnListIds { get; set; }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformPropertyName("local_rulestack_prefix_list_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LocalRulestackPrefixListIds { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleSourceBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformPropertyName("cidrs")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Cidrs { get; set; }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformPropertyName("countries")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Countries { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformPropertyName("feeds")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Feeds { get; set; }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformPropertyName("local_rulestack_prefix_list_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LocalRulestackPrefixListIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPaloAltoLocalRulestackRule : TerraformResource
{
    public AzurermPaloAltoLocalRulestackRule(string name) : base("azurerm_palo_alto_local_rulestack_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    [TerraformPropertyName("applications")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Applications { get; set; }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    [TerraformPropertyName("audit_comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuditComment { get; set; }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    [TerraformPropertyName("decryption_rule_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DecryptionRuleType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The inspection_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("inspection_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InspectionCertificateId { get; set; }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("logging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LoggingEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    [TerraformPropertyName("negate_destination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegateDestination { get; set; }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    [TerraformPropertyName("negate_source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? NegateSource { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    [TerraformPropertyName("protocol_ports")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ProtocolPorts { get; set; }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformPropertyName("rulestack_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RulestackId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    [TerraformPropertyName("category")]
    public TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleCategoryBlock>>? Category { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformPropertyName("destination")]
    public TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoLocalRulestackRuleTimeoutsBlock>? Timeouts { get; set; }

}
