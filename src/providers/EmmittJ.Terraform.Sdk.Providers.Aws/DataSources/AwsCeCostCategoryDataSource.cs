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
        get => GetRequiredArgument<TerraformValue<string>>("cost_category_arn");
        set => SetArgument("cost_category_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string> DefaultValue
        => CreateReference("default_value");

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformValue<string> EffectiveEnd
        => CreateReference("effective_end");

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformValue<string> EffectiveStart
        => CreateReference("effective_start");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Rule
        => CreateReference("rule");

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    public TerraformValue<string> RuleVersion
        => CreateReference("rule_version");

    /// <summary>
    /// The split_charge_rule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SplitChargeRule
        => CreateReference("split_charge_rule");

}
