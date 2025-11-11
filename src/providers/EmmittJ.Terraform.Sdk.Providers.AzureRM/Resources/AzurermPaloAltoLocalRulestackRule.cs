using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoLocalRulestackRuleCategoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomUrls is required")]
    [TerraformProperty("custom_urls")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CustomUrls { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformProperty("feeds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Feeds { get; set; }

}

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoLocalRulestackRuleDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformProperty("cidrs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Cidrs { get; set; }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformProperty("countries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Countries { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformProperty("feeds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Feeds { get; set; }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    [TerraformProperty("local_rulestack_fqdn_list_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LocalRulestackFqdnListIds { get; set; }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformProperty("local_rulestack_prefix_list_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LocalRulestackPrefixListIds { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoLocalRulestackRuleSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [TerraformProperty("cidrs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Cidrs { get; set; }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformProperty("countries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Countries { get; set; }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformProperty("feeds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Feeds { get; set; }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformProperty("local_rulestack_prefix_list_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LocalRulestackPrefixListIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoLocalRulestackRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPaloAltoLocalRulestackRule : TerraformResource
{
    public AzurermPaloAltoLocalRulestackRule(string name) : base("azurerm_palo_alto_local_rulestack_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    [TerraformProperty("applications")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Applications { get; set; }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    [TerraformProperty("audit_comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuditComment { get; set; }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    [TerraformProperty("decryption_rule_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DecryptionRuleType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inspection_certificate_id attribute.
    /// </summary>
    [TerraformProperty("inspection_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InspectionCertificateId { get; set; }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    [TerraformProperty("logging_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LoggingEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    [TerraformProperty("negate_destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegateDestination { get; set; }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    [TerraformProperty("negate_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NegateSource { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    [TerraformProperty("protocol_ports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ProtocolPorts { get; set; }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformProperty("rulestack_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RulestackId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    [TerraformProperty("category")]
    public partial TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleCategoryBlock>>? Category { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformProperty("destination")]
    public partial TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AzurermPaloAltoLocalRulestackRuleSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermPaloAltoLocalRulestackRuleTimeoutsBlock>? Timeouts { get; set; }

}
