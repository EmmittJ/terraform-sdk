using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_notifications_event_rule resource.
/// </summary>
public partial class AwsNotificationsEventRule : TerraformResource
{
    public AwsNotificationsEventRule(string name) : base("aws_notifications_event_rule", name)
    {
    }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [TerraformProperty("event_pattern")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventPattern { get; set; }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    [TerraformProperty("event_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventType { get; set; }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    [TerraformProperty("notification_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NotificationConfigurationArn { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    [TerraformProperty("regions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Regions { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
