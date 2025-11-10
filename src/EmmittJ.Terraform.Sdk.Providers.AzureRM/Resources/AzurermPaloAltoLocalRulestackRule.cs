using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleCategoryBlock : TerraformBlock
{
    /// <summary>
    /// The custom_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomUrls is required")]
    public List<TerraformProperty<string>>? CustomUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("custom_urls");
        set => WithProperty("custom_urls", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        get => GetProperty<List<TerraformProperty<string>>>("feeds");
        set => WithProperty("feeds", value);
    }

}

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Cidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("cidrs");
        set => WithProperty("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Countries
    {
        get => GetProperty<List<TerraformProperty<string>>>("countries");
        set => WithProperty("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        get => GetProperty<List<TerraformProperty<string>>>("feeds");
        set => WithProperty("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackFqdnListIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("local_rulestack_fqdn_list_ids");
        set => WithProperty("local_rulestack_fqdn_list_ids", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackPrefixListIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("local_rulestack_prefix_list_ids");
        set => WithProperty("local_rulestack_prefix_list_ids", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Cidrs
    {
        get => GetProperty<List<TerraformProperty<string>>>("cidrs");
        set => WithProperty("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Countries
    {
        get => GetProperty<List<TerraformProperty<string>>>("countries");
        set => WithProperty("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        get => GetProperty<List<TerraformProperty<string>>>("feeds");
        set => WithProperty("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackPrefixListIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("local_rulestack_prefix_list_ids");
        set => WithProperty("local_rulestack_prefix_list_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackRule : TerraformResource
{
    public AzurermPaloAltoLocalRulestackRule(string name) : base("azurerm_palo_alto_local_rulestack_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    public List<TerraformProperty<string>>? Applications
    {
        get => GetProperty<List<TerraformProperty<string>>>("applications");
        set => this.WithProperty("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string>? AuditComment
    {
        get => GetProperty<TerraformProperty<string>>("audit_comment");
        set => this.WithProperty("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public TerraformProperty<string>? DecryptionRuleType
    {
        get => GetProperty<TerraformProperty<string>>("decryption_rule_type");
        set => this.WithProperty("decryption_rule_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The inspection_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? InspectionCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("inspection_certificate_id");
        set => this.WithProperty("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LoggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("logging_enabled");
        set => this.WithProperty("logging_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    public TerraformProperty<bool>? NegateDestination
    {
        get => GetProperty<TerraformProperty<bool>>("negate_destination");
        set => this.WithProperty("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public TerraformProperty<bool>? NegateSource
    {
        get => GetProperty<TerraformProperty<bool>>("negate_source");
        set => this.WithProperty("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ProtocolPorts
    {
        get => GetProperty<List<TerraformProperty<string>>>("protocol_ports");
        set => this.WithProperty("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetProperty<TerraformProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleCategoryBlock>? Category
    {
        get => GetProperty<List<AzurermPaloAltoLocalRulestackRuleCategoryBlock>>("category");
        set => this.WithProperty("category", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleDestinationBlock>? Destination
    {
        get => GetProperty<List<AzurermPaloAltoLocalRulestackRuleDestinationBlock>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleSourceBlock>? Source
    {
        get => GetProperty<List<AzurermPaloAltoLocalRulestackRuleSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPaloAltoLocalRulestackRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
