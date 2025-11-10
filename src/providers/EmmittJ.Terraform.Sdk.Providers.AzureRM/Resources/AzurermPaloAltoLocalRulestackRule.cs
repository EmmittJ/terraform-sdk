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
        set => SetProperty("custom_urls", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        set => SetProperty("feeds", value);
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
        set => SetProperty("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Countries
    {
        set => SetProperty("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        set => SetProperty("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_fqdn_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackFqdnListIds
    {
        set => SetProperty("local_rulestack_fqdn_list_ids", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackPrefixListIds
    {
        set => SetProperty("local_rulestack_prefix_list_ids", value);
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
        set => SetProperty("cidrs", value);
    }

    /// <summary>
    /// The countries attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Countries
    {
        set => SetProperty("countries", value);
    }

    /// <summary>
    /// The feeds attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Feeds
    {
        set => SetProperty("feeds", value);
    }

    /// <summary>
    /// The local_rulestack_prefix_list_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LocalRulestackPrefixListIds
    {
        set => SetProperty("local_rulestack_prefix_list_ids", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_palo_alto_local_rulestack_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPaloAltoLocalRulestackRule : TerraformResource
{
    public AzurermPaloAltoLocalRulestackRule(string name) : base("azurerm_palo_alto_local_rulestack_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("applications");
        SetOutput("audit_comment");
        SetOutput("decryption_rule_type");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("inspection_certificate_id");
        SetOutput("logging_enabled");
        SetOutput("name");
        SetOutput("negate_destination");
        SetOutput("negate_source");
        SetOutput("priority");
        SetOutput("protocol");
        SetOutput("protocol_ports");
        SetOutput("rulestack_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Applications is required")]
    public List<TerraformProperty<string>> Applications
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("applications");
        set => SetProperty("applications", value);
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string> AuditComment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("audit_comment");
        set => SetProperty("audit_comment", value);
    }

    /// <summary>
    /// The decryption_rule_type attribute.
    /// </summary>
    public TerraformProperty<string> DecryptionRuleType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("decryption_rule_type");
        set => SetProperty("decryption_rule_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The inspection_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string> InspectionCertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inspection_certificate_id");
        set => SetProperty("inspection_certificate_id", value);
    }

    /// <summary>
    /// The logging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LoggingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("logging_enabled");
        set => SetProperty("logging_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The negate_destination attribute.
    /// </summary>
    public TerraformProperty<bool> NegateDestination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("negate_destination");
        set => SetProperty("negate_destination", value);
    }

    /// <summary>
    /// The negate_source attribute.
    /// </summary>
    public TerraformProperty<bool> NegateSource
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("negate_source");
        set => SetProperty("negate_source", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_ports attribute.
    /// </summary>
    public List<TerraformProperty<string>> ProtocolPorts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("protocol_ports");
        set => SetProperty("protocol_ports", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rulestack_id");
        set => SetProperty("rulestack_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleCategoryBlock>? Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermPaloAltoLocalRulestackRuleSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
