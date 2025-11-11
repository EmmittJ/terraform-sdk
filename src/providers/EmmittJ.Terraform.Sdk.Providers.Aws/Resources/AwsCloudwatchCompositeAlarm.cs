using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions_suppressor in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchCompositeAlarmActionsSuppressorBlock : TerraformBlockBase
{
    /// <summary>
    /// The alarm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alarm is required")]
    [TerraformProperty("alarm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Alarm { get; set; }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    [TerraformProperty("extension_period")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ExtensionPeriod { get; set; }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    [TerraformProperty("wait_period")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> WaitPeriod { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_composite_alarm resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchCompositeAlarm : TerraformResource
{
    public AwsCloudwatchCompositeAlarm(string name) : base("aws_cloudwatch_composite_alarm", name)
    {
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    [TerraformProperty("actions_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ActionsEnabled { get; set; }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    [TerraformProperty("alarm_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AlarmActions { get; set; }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    [TerraformProperty("alarm_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AlarmDescription { get; set; }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformProperty("alarm_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AlarmName { get; set; }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    [TerraformProperty("alarm_rule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AlarmRule { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    [TerraformProperty("insufficient_data_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    [TerraformProperty("ok_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OkActions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for actions_suppressor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionsSuppressor block(s) allowed")]
    [TerraformProperty("actions_suppressor")]
    public partial TerraformList<TerraformBlock<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>>? ActionsSuppressor { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
