using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions_suppressor in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchCompositeAlarmActionsSuppressorBlock : ITerraformBlock
{
    /// <summary>
    /// The alarm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alarm is required")]
    [TerraformPropertyName("alarm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Alarm { get; set; }

    /// <summary>
    /// The extension_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionPeriod is required")]
    [TerraformPropertyName("extension_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ExtensionPeriod { get; set; }

    /// <summary>
    /// The wait_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitPeriod is required")]
    [TerraformPropertyName("wait_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> WaitPeriod { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_composite_alarm resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchCompositeAlarm : TerraformResource
{
    public AwsCloudwatchCompositeAlarm(string name) : base("aws_cloudwatch_composite_alarm", name)
    {
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("actions_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ActionsEnabled { get; set; }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    [TerraformPropertyName("alarm_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AlarmActions { get; set; }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    [TerraformPropertyName("alarm_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlarmDescription { get; set; }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformPropertyName("alarm_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AlarmName { get; set; }

    /// <summary>
    /// The alarm_rule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmRule is required")]
    [TerraformPropertyName("alarm_rule")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AlarmRule { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    [TerraformPropertyName("insufficient_data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    [TerraformPropertyName("ok_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OkActions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for actions_suppressor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionsSuppressor block(s) allowed")]
    [TerraformPropertyName("actions_suppressor")]
    public TerraformList<TerraformBlock<AwsCloudwatchCompositeAlarmActionsSuppressorBlock>>? ActionsSuppressor { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
