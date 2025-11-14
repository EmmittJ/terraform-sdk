using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for category in .
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
    [TerraformArgument("custom_urls")]
    public TerraformList<string>? CustomUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_urls").ResolveNodes(ctx));
        set => SetArgument("custom_urls", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformArgument("feeds")]
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
        set => SetArgument("feeds", value);
    }

}

/// <summary>
/// Block type for destination in .
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
    [TerraformArgument("cidrs")]
    public TerraformList<string>? Cidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformArgument("countries")]
    public TerraformList<string>? Countries
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "countries").ResolveNodes(ctx));
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformArgument("feeds")]
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    [TerraformArgument("local_rulestack_fqdn_list_ids")]
    public TerraformList<string>? LocalRulestackFqdnListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_fqdn_list_ids").ResolveNodes(ctx));
        set => SetArgument("local_rulestack_fqdn_list_ids", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformArgument("local_rulestack_prefix_list_ids")]
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_prefix_list_ids").ResolveNodes(ctx));
        set => SetArgument("local_rulestack_prefix_list_ids", value);
    }

}

/// <summary>
/// Block type for source in .
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
    [TerraformArgument("cidrs")]
    public TerraformList<string>? Cidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidrs").ResolveNodes(ctx));
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    [TerraformArgument("countries")]
    public TerraformList<string>? Countries
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "countries").ResolveNodes(ctx));
        set => SetArgument("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    [TerraformArgument("feeds")]
    public TerraformList<string>? Feeds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feeds").ResolveNodes(ctx));
        set => SetArgument("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    [TerraformArgument("local_rulestack_prefix_list_ids")]
    public TerraformList<string>? LocalRulestackPrefixListIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_rulestack_prefix_list_ids").ResolveNodes(ctx));
        set => SetArgument("local_rulestack_prefix_list_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    [TerraformArgument("applications")]
    public TerraformList<string>? Applications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "applications").ResolveNodes(ctx));
        set => SetArgument("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    [TerraformArgument("audit_comment")]
    public TerraformValue<string>? AuditComment
    {
        get => new TerraformReference<string>(this, "audit_comment");
        set => SetArgument("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    [TerraformArgument("decryption_rule_type")]
    public TerraformValue<string>? DecryptionRuleType
    {
        get => new TerraformReference<string>(this, "decryption_rule_type");
        set => SetArgument("decryption_rule_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inspection_certificate_id attribute.
    /// </summary>
    [TerraformArgument("inspection_certificate_id")]
    public TerraformValue<string>? InspectionCertificateId
    {
        get => new TerraformReference<string>(this, "inspection_certificate_id");
        set => SetArgument("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    [TerraformArgument("logging_enabled")]
    public TerraformValue<bool>? LoggingEnabled
    {
        get => new TerraformReference<bool>(this, "logging_enabled");
        set => SetArgument("logging_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    [TerraformArgument("negate_destination")]
    public TerraformValue<bool>? NegateDestination
    {
        get => new TerraformReference<bool>(this, "negate_destination");
        set => SetArgument("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    [TerraformArgument("negate_source")]
    public TerraformValue<bool>? NegateSource
    {
        get => new TerraformReference<bool>(this, "negate_source");
        set => SetArgument("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformArgument("priority")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformArgument("protocol")]
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    [TerraformArgument("protocol_ports")]
    public TerraformList<string>? ProtocolPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocol_ports").ResolveNodes(ctx));
        set => SetArgument("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformArgument("rulestack_id")]
    public required TerraformValue<string> RulestackId
    {
        get => new TerraformReference<string>(this, "rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    [TerraformArgument("category")]
    public TerraformList<AzurermPaloAltoLocalRulestackRuleCategoryBlock> Category { get; set; } = new();

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformArgument("destination")]
    public required TerraformList<AzurermPaloAltoLocalRulestackRuleDestinationBlock> Destination { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformArgument("source")]
    public required TerraformList<AzurermPaloAltoLocalRulestackRuleSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPaloAltoLocalRulestackRuleTimeoutsBlock Timeouts { get; set; } = new();

}
