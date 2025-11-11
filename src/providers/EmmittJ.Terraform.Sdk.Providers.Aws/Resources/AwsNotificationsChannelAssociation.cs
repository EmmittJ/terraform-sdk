using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_notifications_channel_association resource.
/// </summary>
public partial class AwsNotificationsChannelAssociation : TerraformResource
{
    public AwsNotificationsChannelAssociation(string name) : base("aws_notifications_channel_association", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    [TerraformProperty("notification_configuration_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NotificationConfigurationArn { get; set; }

}
