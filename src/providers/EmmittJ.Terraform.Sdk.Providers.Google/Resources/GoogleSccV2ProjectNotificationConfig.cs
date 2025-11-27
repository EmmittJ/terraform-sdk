using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for streaming_config in GoogleSccV2ProjectNotificationConfig.
/// Nesting mode: list
/// </summary>
public class GoogleSccV2ProjectNotificationConfigStreamingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "streaming_config";

    /// <summary>
    /// Expression that defines the filter to apply across create/update
    /// events of assets or findings as specified by the event type. The
    /// expression is a list of zero or more restrictions combined via
    /// logical operators AND and OR. Parentheses are supported, and OR
    /// has higher precedence than AND.
    /// 
    /// Restrictions have the form &amp;lt;field&amp;gt; &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt; and may have
    /// a - character in front of them to indicate negation. The fields
    /// map to those defined in the corresponding resource.
    /// 
    /// The supported operators are:
    /// 
    /// * = for all value types.
    /// * &amp;gt;, &amp;lt;, &amp;gt;=, &amp;lt;= for integer values.
    /// * :, meaning substring matching, for strings.
    /// 
    /// The supported value types are:
    /// 
    /// * string literals in quotes.
    /// * integer literals without quotes.
    /// * boolean literals true and false without quotes.
    /// 
    /// See
    /// [Filtering notifications](https://cloud.google.com/security-command-center/docs/how-to-api-filter-notifications)
    /// for information on how to write a filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSccV2ProjectNotificationConfig.
/// Nesting mode: single
/// </summary>
public class GoogleSccV2ProjectNotificationConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_scc_v2_project_notification_config Terraform resource.
/// Manages a google_scc_v2_project_notification_config resource.
/// </summary>
public partial class GoogleSccV2ProjectNotificationConfig(string name) : TerraformResource("google_scc_v2_project_notification_config", name)
{
    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformValue<string> ConfigId
    {
        get => new TerraformReference<string>(this, "config_id");
        set => SetArgument("config_id", value);
    }

    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Location ID of the parent organization. Only global is supported at the moment.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Pub/Sub topic to send notifications to. Its format is
    /// &amp;quot;projects/[project_id]/topics/[topic]&amp;quot;.
    /// </summary>
    public TerraformValue<string>? PubsubTopic
    {
        get => new TerraformReference<string>(this, "pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// The resource name of this notification config, in the format
    /// &#39;projects/{{projectId}}/locations/{{location}}/notificationConfigs/{{config_id}}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The service account that needs &amp;quot;pubsub.topics.publish&amp;quot; permission to
    /// publish to the Pub/Sub topic.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
    }

    /// <summary>
    /// StreamingConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StreamingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingConfig block(s) allowed")]
    public required TerraformList<GoogleSccV2ProjectNotificationConfigStreamingConfigBlock> StreamingConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleSccV2ProjectNotificationConfigStreamingConfigBlock>>("streaming_config");
        set => SetArgument("streaming_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSccV2ProjectNotificationConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSccV2ProjectNotificationConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
