using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ce_cost_category.
/// </summary>
public class AwsCeCostCategoryDataSource : TerraformDataSource
{
    public AwsCeCostCategoryDataSource(string name) : base("aws_ce_cost_category", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_value");
        this.DeclareOutput("effective_end");
        this.DeclareOutput("effective_start");
        this.DeclareOutput("name");
        this.DeclareOutput("rule");
        this.DeclareOutput("rule_version");
        this.DeclareOutput("split_charge_rule");
    }

    /// <summary>
    /// The cost_category_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CostCategoryArn is required")]
    public required TerraformProperty<string> CostCategoryArn
    {
        get => GetProperty<TerraformProperty<string>>("cost_category_arn");
        set => this.WithProperty("cost_category_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformExpression DefaultValue => this["default_value"];

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformExpression EffectiveEnd => this["effective_end"];

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformExpression EffectiveStart => this["effective_start"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformExpression Rule => this["rule"];

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    public TerraformExpression RuleVersion => this["rule_version"];

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    public TerraformExpression SplitChargeRule => this["split_charge_rule"];

}
