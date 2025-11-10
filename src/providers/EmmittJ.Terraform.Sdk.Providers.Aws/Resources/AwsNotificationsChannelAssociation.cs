using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_notifications_channel_association resource.
/// </summary>
public class AwsNotificationsChannelAssociation : TerraformResource
{
    public AwsNotificationsChannelAssociation(string name) : base("aws_notifications_channel_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("notification_configuration_arn");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    public required TerraformProperty<string> NotificationConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("notification_configuration_arn");
        set => SetProperty("notification_configuration_arn", value);
    }

}
