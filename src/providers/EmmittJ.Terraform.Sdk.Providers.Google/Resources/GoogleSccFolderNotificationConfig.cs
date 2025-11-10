using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for streaming_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSccFolderNotificationConfigStreamingConfigBlock : TerraformBlock
{
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
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter");
        set => WithProperty("filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccFolderNotificationConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_scc_folder_notification_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSccFolderNotificationConfig : TerraformResource
{
    public GoogleSccFolderNotificationConfig(string name) : base("google_scc_folder_notification_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("service_account");
    }

    /// <summary>
    /// This must be unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigId is required")]
    public required TerraformProperty<string> ConfigId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("config_id");
        set => this.WithProperty("config_id", value);
    }

    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Numerical ID of the parent folder.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetRequiredProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The Pub/Sub topic to send notifications to. Its format is
    /// &amp;quot;projects/[project_id]/topics/[topic]&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformProperty<string> PubsubTopic
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pubsub_topic");
        set => this.WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Block for streaming_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StreamingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingConfig block(s) allowed")]
    public List<GoogleSccFolderNotificationConfigStreamingConfigBlock>? StreamingConfig
    {
        get => GetProperty<List<GoogleSccFolderNotificationConfigStreamingConfigBlock>>("streaming_config");
        set => this.WithProperty("streaming_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSccFolderNotificationConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSccFolderNotificationConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of this notification config, in the format
    /// &#39;folders/{{folder}}/notificationConfigs/{{config_id}}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service account that needs &amp;quot;pubsub.topics.publish&amp;quot; permission to
    /// publish to the Pub/Sub topic.
    /// </summary>
    public TerraformExpression ServiceAccount => this["service_account"];

}
