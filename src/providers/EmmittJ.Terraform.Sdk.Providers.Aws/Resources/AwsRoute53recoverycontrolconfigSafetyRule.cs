using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule_config in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock : TerraformBlock
{
    /// <summary>
    /// The inverted attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Inverted is required")]
    public required TerraformProperty<bool> Inverted
    {
        set => SetProperty("inverted", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_safety_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53recoverycontrolconfigSafetyRule : TerraformResource
{
    public AwsRoute53recoverycontrolconfigSafetyRule(string name) : base("aws_route53recoverycontrolconfig_safety_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("status");
        SetOutput("asserted_controls");
        SetOutput("control_panel_arn");
        SetOutput("gating_controls");
        SetOutput("id");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_controls");
        SetOutput("wait_period_ms");
    }

    /// <summary>
    /// The asserted_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>> AssertedControls
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("asserted_controls");
        set => SetProperty("asserted_controls", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPanelArn is required")]
    public required TerraformProperty<string> ControlPanelArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_panel_arn");
        set => SetProperty("control_panel_arn", value);
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>> GatingControls
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("gating_controls");
        set => SetProperty("gating_controls", value);
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
    /// The target_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>> TargetControls
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("target_controls");
        set => SetProperty("target_controls", value);
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriodMs is required")]
    public required TerraformProperty<double> WaitPeriodMs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("wait_period_ms");
        set => SetProperty("wait_period_ms", value);
    }

    /// <summary>
    /// Block for rule_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleConfig block(s) allowed")]
    public List<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock>? RuleConfig
    {
        set => SetProperty("rule_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
