using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for split_charge_rule in .
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategorySplitChargeRuleBlock : TerraformBlock
{
    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformProperty<string> Method
    {
        get => GetRequiredProperty<TerraformProperty<string>>("method");
        set => WithProperty("method", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

    /// <summary>
    /// The targets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    public HashSet<TerraformProperty<string>>? Targets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("targets");
        set => WithProperty("targets", value);
    }

}

/// <summary>
/// Manages a aws_ce_cost_category resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCeCostCategory : TerraformResource
{
    public AwsCeCostCategory(string name) : base("aws_ce_cost_category", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("effective_end");
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => this.WithProperty("default_value", value);
    }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformProperty<string>? EffectiveStart
    {
        get => GetProperty<TerraformProperty<string>>("effective_start");
        set => this.WithProperty("effective_start", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleVersion is required")]
    public required TerraformProperty<string> RuleVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_version");
        set => this.WithProperty("rule_version", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public List<AwsCeCostCategoryRuleBlock>? Rule
    {
        get => GetProperty<List<AwsCeCostCategoryRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// Block for split_charge_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCeCostCategorySplitChargeRuleBlock>? SplitChargeRule
    {
        get => GetProperty<HashSet<AwsCeCostCategorySplitChargeRuleBlock>>("split_charge_rule");
        set => this.WithProperty("split_charge_rule", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformExpression EffectiveEnd => this["effective_end"];

}
