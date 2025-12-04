using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNotificationsNotificationHub.
/// Nesting mode: single
/// </summary>
public class AwsNotificationsNotificationHubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_notifications_notification_hub Terraform resource.
/// Manages a aws_notifications_notification_hub resource.
/// </summary>
public partial class AwsNotificationsNotificationHub(string name) : TerraformResource("aws_notifications_notification_hub", name)
{
    /// <summary>
    /// The notification_hub_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationHubRegion is required")]
    public required TerraformValue<string> NotificationHubRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("notification_hub_region");
        set => SetArgument("notification_hub_region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNotificationsNotificationHubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNotificationsNotificationHubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
