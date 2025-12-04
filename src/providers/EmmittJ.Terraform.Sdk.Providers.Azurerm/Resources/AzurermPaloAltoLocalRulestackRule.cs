using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for category in AzurermPaloAltoLocalRulestackRule.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "category";

    /// <summary>
    /// The custom_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomUrls is required")]
    public TerraformList<string>? CustomUrls
    {
        get => GetArgument<TerraformList<string>>("custom_urls");
        set => SetArgument("custom_urls", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => GetArgument<TerraformList<string>>("feeds");
        set => SetArgument("feeds", value);
    }

}


/// <summary>
/// Block type for destination in AzurermPaloAltoLocalRulestackRule.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformList<string>? Cidrs
    {
        get => GetArgument<TerraformList<string>>("cidrs");
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public TerraformList<string>? Countries
    {
        get => GetArgument<TerraformList<string>>("countries");
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => GetArgument<TerraformList<string>>("feeds");
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackFqdnListIds
    {
        get => GetArgument<TerraformList<string>>("local_rulestack_fqdn_list_ids");
        set => SetArgument("local_rulestack_fqdn_list_ids", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => GetArgument<TerraformList<string>>("local_rulestack_prefix_list_ids");
        set => SetArgument("local_rulestack_prefix_list_ids", value);
    }

}


/// <summary>
/// Block type for source in AzurermPaloAltoLocalRulestackRule.
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public TerraformList<string>? Cidrs
    {
        get => GetArgument<TerraformList<string>>("cidrs");
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public TerraformList<string>? Countries
    {
        get => GetArgument<TerraformList<string>>("countries");
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => GetArgument<TerraformList<string>>("feeds");
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => GetArgument<TerraformList<string>>("local_rulestack_prefix_list_ids");
        set => SetArgument("local_rulestack_prefix_list_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPaloAltoLocalRulestackRule.
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_palo_alto_local_rulestack_rule Terraform resource.
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackRule(string name) : TerraformResource("azurerm_palo_alto_local_rulestack_rule", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    public TerraformList<string>? Applications
    {
        get => GetArgument<TerraformList<string>>("applications");
        set => SetArgument("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformValue<string>? AuditComment
    {
        get => GetArgument<TerraformValue<string>>("audit_comment");
        set => SetArgument("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public TerraformValue<string>? DecryptionRuleType
    {
        get => GetArgument<TerraformValue<string>>("decryption_rule_type");
        set => SetArgument("decryption_rule_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inspection_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? InspectionCertificateId
    {
        get => GetArgument<TerraformValue<string>>("inspection_certificate_id");
        set => SetArgument("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LoggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("logging_enabled");
        set => SetArgument("logging_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    public TerraformValue<bool>? NegateDestination
    {
        get => GetArgument<TerraformValue<bool>>("negate_destination");
        set => SetArgument("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public TerraformValue<bool>? NegateSource
    {
        get => GetArgument<TerraformValue<bool>>("negate_source");
        set => SetArgument("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public TerraformList<string>? ProtocolPorts
    {
        get => GetArgument<TerraformList<string>>("protocol_ports");
        set => SetArgument("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformValue<string> RulestackId
    {
        get => GetRequiredArgument<TerraformValue<string>>("rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Category block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public TerraformList<AzurermPaloAltoLocalRulestackRuleCategoryBlock>? Category
    {
        get => GetArgument<TerraformList<AzurermPaloAltoLocalRulestackRuleCategoryBlock>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AzurermPaloAltoLocalRulestackRuleDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AzurermPaloAltoLocalRulestackRuleDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AzurermPaloAltoLocalRulestackRuleSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AzurermPaloAltoLocalRulestackRuleSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
