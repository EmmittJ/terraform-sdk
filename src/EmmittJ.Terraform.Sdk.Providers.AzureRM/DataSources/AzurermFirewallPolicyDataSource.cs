using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_firewall_policy.
/// </summary>
public class AzurermFirewallPolicyDataSource : TerraformDataSource
{
    public AzurermFirewallPolicyDataSource(string name) : base("azurerm_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("base_policy_id");
        this.DeclareOutput("child_policies");
        this.DeclareOutput("dns");
        this.DeclareOutput("firewalls");
        this.DeclareOutput("location");
        this.DeclareOutput("rule_collection_groups");
        this.DeclareOutput("tags");
        this.DeclareOutput("threat_intelligence_allowlist");
        this.DeclareOutput("threat_intelligence_mode");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFirewallPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFirewallPolicyDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The base_policy_id attribute.
    /// </summary>
    public TerraformExpression BasePolicyId => this["base_policy_id"];

    /// <summary>
    /// The child_policies attribute.
    /// </summary>
    public TerraformExpression ChildPolicies => this["child_policies"];

    /// <summary>
    /// The dns attribute.
    /// </summary>
    public TerraformExpression Dns => this["dns"];

    /// <summary>
    /// The firewalls attribute.
    /// </summary>
    public TerraformExpression Firewalls => this["firewalls"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The rule_collection_groups attribute.
    /// </summary>
    public TerraformExpression RuleCollectionGroups => this["rule_collection_groups"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The threat_intelligence_allowlist attribute.
    /// </summary>
    public TerraformExpression ThreatIntelligenceAllowlist => this["threat_intelligence_allowlist"];

    /// <summary>
    /// The threat_intelligence_mode attribute.
    /// </summary>
    public TerraformExpression ThreatIntelligenceMode => this["threat_intelligence_mode"];

}
