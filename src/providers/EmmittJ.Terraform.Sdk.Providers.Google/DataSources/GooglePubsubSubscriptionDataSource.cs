using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_pubsub_subscription.
/// </summary>
public class GooglePubsubSubscriptionDataSource : TerraformDataSource
{
    public GooglePubsubSubscriptionDataSource(string name) : base("google_pubsub_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ack_deadline_seconds");
        this.WithOutput("bigquery_config");
        this.WithOutput("cloud_storage_config");
        this.WithOutput("dead_letter_policy");
        this.WithOutput("effective_labels");
        this.WithOutput("enable_exactly_once_delivery");
        this.WithOutput("enable_message_ordering");
        this.WithOutput("expiration_policy");
        this.WithOutput("filter");
        this.WithOutput("labels");
        this.WithOutput("message_retention_duration");
        this.WithOutput("message_transforms");
        this.WithOutput("push_config");
        this.WithOutput("retain_acked_messages");
        this.WithOutput("retry_policy");
        this.WithOutput("tags");
        this.WithOutput("terraform_labels");
        this.WithOutput("topic");
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
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// This value is the maximum time after a subscriber receives a message
    /// before the subscriber should acknowledge the message. After message
    /// delivery but before the ack deadline expires and before the message is
    /// acknowledged, it is an outstanding message and will not be delivered
    /// again during that time (on a best-effort basis).
    /// 
    /// For pull subscriptions, this value is used as the initial value for
    /// the ack deadline. To override this value for a given message, call
    /// subscriptions.modifyAckDeadline with the corresponding ackId if using
    /// pull. The minimum custom deadline you can specify is 10 seconds. The
    /// maximum custom deadline you can specify is 600 seconds (10 minutes).
    /// If this parameter is 0, a default value of 10 seconds is used.
    /// 
    /// For push delivery, this value is also used to set the request timeout
    /// for the call to the push endpoint.
    /// 
    /// If the subscriber never acknowledges the message, the Pub/Sub system
    /// will eventually redeliver the message.
    /// </summary>
    public TerraformExpression AckDeadlineSeconds => this["ack_deadline_seconds"];

    /// <summary>
    /// If delivery to BigQuery is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// </summary>
    public TerraformExpression BigqueryConfig => this["bigquery_config"];

    /// <summary>
    /// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// </summary>
    public TerraformExpression CloudStorageConfig => this["cloud_storage_config"];

    /// <summary>
    /// A policy that specifies the conditions for dead lettering messages in
    /// this subscription. If dead_letter_policy is not set, dead lettering
    /// is disabled.
    /// 
    /// The Cloud Pub/Sub service account associated with this subscription&#39;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Acknowledge() messages on this subscription.
    /// </summary>
    public TerraformExpression DeadLetterPolicy => this["dead_letter_policy"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// If &#39;true&#39;, Pub/Sub provides the following guarantees for the delivery
    /// of a message with a given value of messageId on this Subscriptions&#39;:
    /// 
    /// - The message sent to a subscriber is guaranteed not to be resent before the message&#39;s acknowledgement deadline expires.
    /// 
    /// - An acknowledged message will not be resent to a subscriber.
    /// 
    /// Note that subscribers may still receive multiple copies of a message when &#39;enable_exactly_once_delivery&#39;
    /// is true if the message was published multiple times by a publisher client. These copies are considered distinct by Pub/Sub and have distinct messageId values
    /// </summary>
    public TerraformExpression EnableExactlyOnceDelivery => this["enable_exactly_once_delivery"];

    /// <summary>
    /// If &#39;true&#39;, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    public TerraformExpression EnableMessageOrdering => this["enable_message_ordering"];

    /// <summary>
    /// A policy that specifies the conditions for this subscription&#39;s expiration.
    /// A subscription is considered active as long as any connected subscriber
    /// is successfully consuming messages from the subscription or is issuing
    /// operations on the subscription. If expirationPolicy is not set, a default
    /// policy with ttl of 31 days will be used.  If it is set but ttl is &amp;quot;&amp;quot;, the
    /// resource never expires.  The minimum allowed value for expirationPolicy.ttl
    /// is 1 day.
    /// </summary>
    public TerraformExpression ExpirationPolicy => this["expiration_policy"];

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&#39;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&#39;t modify the filter.
    /// </summary>
    public TerraformExpression Filter => this["filter"];

    /// <summary>
    /// A set of key/value label pairs to assign to this Subscription.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// How long to retain unacknowledged messages in the subscription&#39;s
    /// backlog, from the moment a message is published. If
    /// retain_acked_messages is true, then this also configures the retention
    /// of acknowledged messages, and thus configures how far back in time a
    /// subscriptions.seek can be done. Defaults to 7 days. Cannot be more
    /// than 31 days (&#39;&amp;quot;2678400s&amp;quot;&#39;) or less than 10 minutes (&#39;&amp;quot;600s&amp;quot;&#39;).
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated
    /// by &#39;s&#39;. Example: &#39;&amp;quot;600.5s&amp;quot;&#39;.
    /// </summary>
    public TerraformExpression MessageRetentionDuration => this["message_retention_duration"];

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// </summary>
    public TerraformExpression MessageTransforms => this["message_transforms"];

    /// <summary>
    /// If push delivery is used with this subscription, this field is used to
    /// configure it. An empty pushConfig signifies that the subscriber will
    /// pull and ack messages using API methods.
    /// </summary>
    public TerraformExpression PushConfig => this["push_config"];

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If &#39;true&#39;, then
    /// messages are not expunged from the subscription&#39;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    public TerraformExpression RetainAckedMessages => this["retain_acked_messages"];

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery for this subscription.
    /// 
    /// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
    /// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
    /// </summary>
    public TerraformExpression RetryPolicy => this["retry_policy"];

    /// <summary>
    /// Input only. Resource manager tags to be bound to the subscription. Tag
    /// keys and values have the same definition as resource manager tags. Keys
    /// must be in the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the &#39;google_tags_tag_value&#39;
    /// resource.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    public TerraformExpression Topic => this["topic"];

}
