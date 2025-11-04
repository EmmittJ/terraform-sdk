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
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    public string? NotificationConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_configuration_arn")?.Value;
        set => this.WithProperty("notification_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
