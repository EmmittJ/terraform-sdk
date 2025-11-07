using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_pubsub_subscription resource.
/// </summary>
public class GooglePubsubSubscription : TerraformResource
{
    public GooglePubsubSubscription(string name) : base("google_pubsub_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
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
    public TerraformLiteralProperty<double>? AckDeadlineSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ack_deadline_seconds");
        set => this.WithProperty("ack_deadline_seconds", value);
    }

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
    public TerraformLiteralProperty<bool>? EnableExactlyOnceDelivery
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_exactly_once_delivery");
        set => this.WithProperty("enable_exactly_once_delivery", value);
    }

    /// <summary>
    /// If &#39;true&#39;, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableMessageOrdering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_message_ordering");
        set => this.WithProperty("enable_message_ordering", value);
    }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&#39;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&#39;t modify the filter.
    /// </summary>
    public TerraformLiteralProperty<string>? Filter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Subscription.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

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
    public TerraformLiteralProperty<string>? MessageRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message_retention_duration");
        set => this.WithProperty("message_retention_duration", value);
    }

    /// <summary>
    /// Name of the subscription.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If &#39;true&#39;, then
    /// messages are not expunged from the subscription&#39;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    public TerraformLiteralProperty<bool>? RetainAckedMessages
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retain_acked_messages");
        set => this.WithProperty("retain_acked_messages", value);
    }

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
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    public TerraformLiteralProperty<string>? Topic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic");
        set => this.WithProperty("topic", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
