using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for application_rule_collection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for nat_rule_collection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for network_rule_collection in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
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
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_firewall_policy_rule_collection_group resource.
/// </summary>
public class AzurermFirewallPolicyRuleCollectionGroup : TerraformResource
{
    public AzurermFirewallPolicyRuleCollectionGroup(string name) : base("azurerm_firewall_policy_rule_collection_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyId is required")]
    public required TerraformProperty<string> FirewallPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_id");
        set => this.WithProperty("firewall_policy_id", value);
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
    /// Block for application_rule_collection.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock>? ApplicationRuleCollection
    {
        get => GetProperty<List<AzurermFirewallPolicyRuleCollectionGroupApplicationRuleCollectionBlock>>("application_rule_collection");
        set => this.WithProperty("application_rule_collection", value);
    }

    /// <summary>
    /// Block for nat_rule_collection.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock>? NatRuleCollection
    {
        get => GetProperty<List<AzurermFirewallPolicyRuleCollectionGroupNatRuleCollectionBlock>>("nat_rule_collection");
        set => this.WithProperty("nat_rule_collection", value);
    }

    /// <summary>
    /// Block for network_rule_collection.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock>? NetworkRuleCollection
    {
        get => GetProperty<List<AzurermFirewallPolicyRuleCollectionGroupNetworkRuleCollectionBlock>>("network_rule_collection");
        set => this.WithProperty("network_rule_collection", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFirewallPolicyRuleCollectionGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
