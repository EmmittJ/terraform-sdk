using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule_config in AwsRoute53recoverycontrolconfigSafetyRule.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_config";

    /// <summary>
    /// The inverted attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Inverted is required")]
    public required TerraformValue<bool> Inverted
    {
        get => GetArgument<TerraformValue<bool>>("inverted");
        set => SetArgument("inverted", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_route53recoverycontrolconfig_safety_rule Terraform resource.
/// Manages a aws_route53recoverycontrolconfig_safety_rule resource.
/// </summary>
public partial class AwsRoute53recoverycontrolconfigSafetyRule(string name) : TerraformResource("aws_route53recoverycontrolconfig_safety_rule", name)
{
    /// <summary>
    /// The asserted_controls attribute.
    /// </summary>
    public TerraformList<string>? AssertedControls
    {
        get => GetArgument<TerraformList<string>>("asserted_controls");
        set => SetArgument("asserted_controls", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPanelArn is required")]
    public required TerraformValue<string> ControlPanelArn
    {
        get => GetArgument<TerraformValue<string>>("control_panel_arn");
        set => SetArgument("control_panel_arn", value);
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public TerraformList<string>? GatingControls
    {
        get => GetArgument<TerraformList<string>>("gating_controls");
        set => SetArgument("gating_controls", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_controls attribute.
    /// </summary>
    public TerraformList<string>? TargetControls
    {
        get => GetArgument<TerraformList<string>>("target_controls");
        set => SetArgument("target_controls", value);
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriodMs is required")]
    public required TerraformValue<double> WaitPeriodMs
    {
        get => GetArgument<TerraformValue<double>>("wait_period_ms");
        set => SetArgument("wait_period_ms", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// RuleConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleConfig block(s) allowed")]
    public required TerraformList<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock> RuleConfig
    {
        get => GetRequiredArgument<TerraformList<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock>>("rule_config");
        set => SetArgument("rule_config", value);
    }

}
