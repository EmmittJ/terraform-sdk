using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_rule resource.
/// </summary>
public class AzurermCdnFrontdoorRule : TerraformResource
{
    public AzurermCdnFrontdoorRule(string name) : base("azurerm_cdn_frontdoor_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cdn_frontdoor_rule_set_name");
    }

    /// <summary>
    /// The behavior_on_match attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BehaviorOnMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("behavior_on_match");
        set => this.WithProperty("behavior_on_match", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CdnFrontdoorRuleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_rule_set_id");
        set => this.WithProperty("cdn_frontdoor_rule_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Order
    {
        get => GetProperty<TerraformLiteralProperty<double>>("order");
        set => this.WithProperty("order", value);
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorRuleSetName => this["cdn_frontdoor_rule_set_name"];

}
