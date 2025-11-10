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
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("method", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The targets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    public HashSet<TerraformProperty<string>>? Targets
    {
        set => SetProperty("targets", value);
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
        SetOutput("arn");
        SetOutput("effective_end");
        SetOutput("default_value");
        SetOutput("effective_start");
        SetOutput("id");
        SetOutput("name");
        SetOutput("rule_version");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string> DefaultValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_value");
        set => SetProperty("default_value", value);
    }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformProperty<string> EffectiveStart
    {
        get => GetRequiredOutput<TerraformProperty<string>>("effective_start");
        set => SetProperty("effective_start", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleVersion is required")]
    public required TerraformProperty<string> RuleVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_version");
        set => SetProperty("rule_version", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public List<AwsCeCostCategoryRuleBlock>? Rule
    {
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// Block for split_charge_rule.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCeCostCategorySplitChargeRuleBlock>? SplitChargeRule
    {
        set => SetProperty("split_charge_rule", value);
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
