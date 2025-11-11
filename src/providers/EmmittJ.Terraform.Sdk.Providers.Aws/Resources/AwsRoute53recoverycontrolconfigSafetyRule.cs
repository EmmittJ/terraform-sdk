using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The inverted attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Inverted is required")]
    [TerraformProperty("inverted")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Inverted { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_safety_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRoute53recoverycontrolconfigSafetyRule : TerraformResource
{
    public AwsRoute53recoverycontrolconfigSafetyRule(string name) : base("aws_route53recoverycontrolconfig_safety_rule", name)
    {
    }

    /// <summary>
    /// The asserted_controls attribute.
    /// </summary>
    [TerraformProperty("asserted_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AssertedControls { get; set; }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControlPanelArn is required")]
    [TerraformProperty("control_panel_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ControlPanelArn { get; set; }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    [TerraformProperty("gating_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? GatingControls { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_controls attribute.
    /// </summary>
    [TerraformProperty("target_controls")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TargetControls { get; set; }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriodMs is required")]
    [TerraformProperty("wait_period_ms")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> WaitPeriodMs { get; set; }

    /// <summary>
    /// Block for rule_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleConfig block(s) allowed")]
    [TerraformProperty("rule_config")]
    public TerraformList<TerraformBlock<AwsRoute53recoverycontrolconfigSafetyRuleRuleConfigBlock>>? RuleConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
