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
        get => new TerraformReference<bool>(this, "inverted");
        set => SetArgument("inverted", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "asserted_controls").ResolveNodes(ctx));
        set => SetArgument("asserted_controls", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPanelArn is required")]
    public required TerraformValue<string> ControlPanelArn
    {
        get => new TerraformReference<string>(this, "control_panel_arn");
        set => SetArgument("control_panel_arn", value);
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public TerraformList<string>? GatingControls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gating_controls").ResolveNodes(ctx));
        set => SetArgument("gating_controls", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_controls attribute.
    /// </summary>
    public TerraformList<string>? TargetControls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_controls").ResolveNodes(ctx));
        set => SetArgument("target_controls", value);
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriodMs is required")]
    public required TerraformValue<double> WaitPeriodMs
    {
        get => new TerraformReference<double>(this, "wait_period_ms");
        set => SetArgument("wait_period_ms", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

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
