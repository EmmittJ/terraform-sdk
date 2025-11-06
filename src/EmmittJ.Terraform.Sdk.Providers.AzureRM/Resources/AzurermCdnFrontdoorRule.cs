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
    public string? BehaviorOnMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("behavior_on_match")?.Value;
        set => this.WithProperty("behavior_on_match", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_id attribute.
    /// </summary>
    public string? CdnFrontdoorRuleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_rule_set_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_rule_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public double? Order
    {
        get => GetProperty<TerraformLiteralProperty<double>>("order")?.Value;
        set => this.WithProperty("order", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The cdn_frontdoor_rule_set_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorRuleSetName => this["cdn_frontdoor_rule_set_name"];

}
