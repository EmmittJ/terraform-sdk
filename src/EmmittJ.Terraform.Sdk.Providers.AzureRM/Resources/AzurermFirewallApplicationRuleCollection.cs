using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallApplicationRuleCollectionRuleBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The fqdn_tags attribute.
    /// </summary>
    public List<TerraformProperty<string>>? FqdnTags
    {
        get => GetProperty<List<TerraformProperty<string>>>("fqdn_tags");
        set => WithProperty("fqdn_tags", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SourceAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_addresses");
        set => WithProperty("source_addresses", value);
    }

    /// <summary>
    /// The source_ip_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SourceIpGroups
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_ip_groups");
        set => WithProperty("source_ip_groups", value);
    }

    /// <summary>
    /// The target_fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TargetFqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_fqdns");
        set => WithProperty("target_fqdns", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallApplicationRuleCollectionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_firewall_application_rule_collection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFirewallApplicationRuleCollection : TerraformResource
{
    public AzurermFirewallApplicationRuleCollection(string name) : base("azurerm_firewall_application_rule_collection", name)
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
    /// The azure_firewall_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureFirewallName is required")]
    public required TerraformProperty<string> AzureFirewallName
    {
        get => GetProperty<TerraformProperty<string>>("azure_firewall_name");
        set => this.WithProperty("azure_firewall_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public List<AzurermFirewallApplicationRuleCollectionRuleBlock>? Rule
    {
        get => GetProperty<List<AzurermFirewallApplicationRuleCollectionRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallApplicationRuleCollectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFirewallApplicationRuleCollectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
