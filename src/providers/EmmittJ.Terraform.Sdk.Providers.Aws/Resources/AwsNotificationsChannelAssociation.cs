using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_notifications_channel_association Terraform resource.
/// Manages a aws_notifications_channel_association resource.
/// </summary>
public partial class AwsNotificationsChannelAssociation(string name) : TerraformResource("aws_notifications_channel_association", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    public required TerraformValue<string> NotificationConfigurationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_configuration_arn");
        set => SetArgument("notification_configuration_arn", value);
    }

}
