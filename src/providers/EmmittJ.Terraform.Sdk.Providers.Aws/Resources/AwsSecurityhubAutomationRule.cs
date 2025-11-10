using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_securityhub_automation_rule resource.
/// </summary>
public class AwsSecurityhubAutomationRule : TerraformResource
{
    public AwsSecurityhubAutomationRule(string name) : base("aws_securityhub_automation_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("description");
        SetOutput("is_terminal");
        SetOutput("region");
        SetOutput("rule_name");
        SetOutput("rule_order");
        SetOutput("rule_status");
        SetOutput("tags");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The is_terminal attribute.
    /// </summary>
    public TerraformProperty<bool> IsTerminal
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_terminal");
        set => SetProperty("is_terminal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_name");
        set => SetProperty("rule_name", value);
    }

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOrder is required")]
    public required TerraformProperty<double> RuleOrder
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rule_order");
        set => SetProperty("rule_order", value);
    }

    /// <summary>
    /// The rule_status attribute.
    /// </summary>
    public TerraformProperty<string> RuleStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_status");
        set => SetProperty("rule_status", value);
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
    /// Block for actions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSecurityhubAutomationRuleActionsBlock>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecurityhubAutomationRuleCriteriaBlock>? Criteria
    {
        set => SetProperty("criteria", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
