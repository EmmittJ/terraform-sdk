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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_urls").ResolveNodes(ctx));
        set => SetArgument("custom_urls", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public TerraformList<string>? Countries
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "countries").ResolveNodes(ctx));
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackFqdnListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_fqdn_list_ids").ResolveNodes(ctx));
        set => SetArgument("local_rulestack_fqdn_list_ids", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_prefix_list_ids").ResolveNodes(ctx));
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public TerraformList<string>? Countries
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "countries").ResolveNodes(ctx));
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_prefix_list_ids").ResolveNodes(ctx));
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    public TerraformList<string>? Applications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "applications").ResolveNodes(ctx));
        set => SetArgument("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformValue<string>? AuditComment
    {
        get => new TerraformReference<string>(this, "audit_comment");
        set => SetArgument("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public TerraformValue<string>? DecryptionRuleType
    {
        get => new TerraformReference<string>(this, "decryption_rule_type");
        set => SetArgument("decryption_rule_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The inspection_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? InspectionCertificateId
    {
        get => new TerraformReference<string>(this, "inspection_certificate_id");
        set => SetArgument("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LoggingEnabled
    {
        get => new TerraformReference<bool>(this, "logging_enabled");
        set => SetArgument("logging_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    public TerraformValue<bool>? NegateDestination
    {
        get => new TerraformReference<bool>(this, "negate_destination");
        set => SetArgument("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public TerraformValue<bool>? NegateSource
    {
        get => new TerraformReference<bool>(this, "negate_source");
        set => SetArgument("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public TerraformList<string>? ProtocolPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocol_ports").ResolveNodes(ctx));
        set => SetArgument("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformValue<string> RulestackId
    {
        get => new TerraformReference<string>(this, "rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
