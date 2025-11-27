using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ce_cost_category Terraform data source.
/// Retrieves information about a aws_ce_cost_category.
/// </summary>
public partial class AwsCeCostCategoryDataSource(string name) : TerraformDataSource("aws_ce_cost_category", name)
{
    /// <summary>
    /// The cost_category_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CostCategoryArn is required")]
    public required TerraformValue<string> CostCategoryArn
    {
        get => new TerraformReference<string>(this, "cost_category_arn");
        set => SetArgument("cost_category_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string> DefaultValue
    {
        get => new TerraformReference<string>(this, "default_value");
    }

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformValue<string> EffectiveEnd
    {
        get => new TerraformReference<string>(this, "effective_end");
    }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformValue<string> EffectiveStart
    {
        get => new TerraformReference<string>(this, "effective_start");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Rule
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    public TerraformValue<string> RuleVersion
    {
        get => new TerraformReference<string>(this, "rule_version");
    }

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SplitChargeRule
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "split_charge_rule").ResolveNodes(ctx));
    }

}
