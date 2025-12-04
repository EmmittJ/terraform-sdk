using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_notifications_event_rule Terraform resource.
/// Manages a aws_notifications_event_rule resource.
/// </summary>
public partial class AwsNotificationsEventRule(string name) : TerraformResource("aws_notifications_event_rule", name)
{
    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    public TerraformValue<string>? EventPattern
    {
        get => GetArgument<TerraformValue<string>>("event_pattern");
        set => SetArgument("event_pattern", value);
    }

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => GetArgument<TerraformValue<string>>("event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// The notification_configuration_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationConfigurationArn is required")]
    public required TerraformValue<string> NotificationConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("notification_configuration_arn");
        set => SetArgument("notification_configuration_arn", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    public required TerraformSet<string> Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
