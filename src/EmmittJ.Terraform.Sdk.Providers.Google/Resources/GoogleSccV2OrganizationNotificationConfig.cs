using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_scc_v2_organization_notification_config resource.
/// </summary>
public class GoogleSccV2OrganizationNotificationConfig : TerraformResource
{
    public GoogleSccV2OrganizationNotificationConfig(string name) : base("google_scc_v2_organization_notification_config", name)
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
    public TerraformProperty<string>? ConfigId
    {
        get => GetProperty<TerraformProperty<string>>("config_id");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// location Id is provided by organization. If not provided, Use global as default.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The organization whose Cloud Security Command Center the Notification
    /// Config lives in.
    /// </summary>
    public TerraformProperty<string>? Organization
    {
        get => GetProperty<TerraformProperty<string>>("organization");
        set => this.WithProperty("organization", value);
    }

    /// <summary>
    /// The Pub/Sub topic to send notifications to. Its format is
    /// &amp;quot;projects/[project_id]/topics/[topic]&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? PubsubTopic
    {
        get => GetProperty<TerraformProperty<string>>("pubsub_topic");
        set => this.WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// The resource name of this notification config, in the format
    /// &#39;organizations/{{organization}}/notificationConfigs/{{config_id}}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service account that needs &amp;quot;pubsub.topics.publish&amp;quot; permission to
    /// publish to the Pub/Sub topic.
    /// </summary>
    public TerraformExpression ServiceAccount => this["service_account"];

}
