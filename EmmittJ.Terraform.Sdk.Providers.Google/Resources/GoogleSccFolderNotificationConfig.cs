using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_folder_notification_config resource.
/// </summary>
public class GoogleSccFolderNotificationConfig : TerraformResource
{
    public GoogleSccFolderNotificationConfig(string name) : base("google_scc_folder_notification_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("service_account");
    }

    /// <summary>
    /// This must be unique within the organization.
    /// </summary>
    public string? ConfigId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_id")?.Value;
        set => this.WithProperty("config_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Numerical ID of the parent folder.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Pub/Sub topic to send notifications to. Its format is
    /// &amp;quot;projects/[project_id]/topics/[topic]&amp;quot;.
    /// </summary>
    public string? PubsubTopic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pubsub_topic")?.Value;
        set => this.WithProperty("pubsub_topic", value == null ? null : new TerraformLiteralProperty<string>(value));
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
