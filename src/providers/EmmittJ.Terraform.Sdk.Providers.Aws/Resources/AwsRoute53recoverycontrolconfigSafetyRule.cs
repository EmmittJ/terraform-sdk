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
        get => GetRequiredProperty<TerraformProperty<bool>>("inverted");
        set => WithProperty("inverted", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        get => GetRequiredProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The asserted_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AssertedControls
    {
        get => GetProperty<List<TerraformProperty<string>>>("asserted_controls");
        set => this.WithProperty("asserted_controls", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPanelArn is required")]
    public required TerraformProperty<string> ControlPanelArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("control_panel_arn");
        set => this.WithProperty("control_panel_arn", value);
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GatingControls
    {
        get => GetProperty<List<TerraformProperty<string>>>("gating_controls");
        set => this.WithProperty("gating_controls", value);
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
    /// The target_controls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TargetControls
    {
        get => GetProperty<List<TerraformProperty<string>>>("target_controls");
        set => this.WithProperty("target_controls", value);
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriodMs is required")]
    public required TerraformProperty<double> WaitPeriodMs
    {
        get => GetRequiredProperty<TerraformProperty<double>>("wait_period_ms");
        set => this.WithProperty("wait_period_ms", value);
    }

    /// <summary>
    /// Block for rule_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleConfig block(s) allowed")]
    public List<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock>? RuleConfig
    {
        get => GetProperty<List<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock>>("rule_config");
        set => this.WithProperty("rule_config", value);
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
