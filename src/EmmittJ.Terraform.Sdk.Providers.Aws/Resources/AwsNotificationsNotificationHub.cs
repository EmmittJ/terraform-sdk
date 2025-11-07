using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_notifications_notification_hub resource.
/// </summary>
public class AwsNotificationsNotificationHub : TerraformResource
{
    public AwsNotificationsNotificationHub(string name) : base("aws_notifications_notification_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The notification_hub_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NotificationHubRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_hub_region");
        set => this.WithProperty("notification_hub_region", value);
    }

}
