using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_pubsub_subscription.
/// </summary>
public class GooglePubsubSubscriptionDataSource : TerraformDataSource
{
    public GooglePubsubSubscriptionDataSource(string name) : base("google_pubsub_subscription", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

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
    [TerraformPropertyName("ack_deadline_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AckDeadlineSeconds => new TerraformReference(this, "ack_deadline_seconds");

    /// <summary>
    /// If delivery to BigQuery is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// </summary>
    [TerraformPropertyName("bigquery_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BigqueryConfig => new TerraformReference(this, "bigquery_config");

    /// <summary>
    /// If delivery to Cloud Storage is used with this subscription, this field is used to configure it.
    /// Either pushConfig, bigQueryConfig or cloudStorageConfig can be set, but not combined.
    /// If all three are empty, then the subscriber will pull and ack messages using API methods.
    /// </summary>
    [TerraformPropertyName("cloud_storage_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudStorageConfig => new TerraformReference(this, "cloud_storage_config");

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
    [TerraformPropertyName("dead_letter_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DeadLetterPolicy => new TerraformReference(this, "dead_letter_policy");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

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
    [TerraformPropertyName("enable_exactly_once_delivery")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableExactlyOnceDelivery => new TerraformReference(this, "enable_exactly_once_delivery");

    /// <summary>
    /// If &#39;true&#39;, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    [TerraformPropertyName("enable_message_ordering")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableMessageOrdering => new TerraformReference(this, "enable_message_ordering");

    /// <summary>
    /// A policy that specifies the conditions for this subscription&#39;s expiration.
    /// A subscription is considered active as long as any connected subscriber
    /// is successfully consuming messages from the subscription or is issuing
    /// operations on the subscription. If expirationPolicy is not set, a default
    /// policy with ttl of 31 days will be used.  If it is set but ttl is &amp;quot;&amp;quot;, the
    /// resource never expires.  The minimum allowed value for expirationPolicy.ttl
    /// is 1 day.
    /// </summary>
    [TerraformPropertyName("expiration_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExpirationPolicy => new TerraformReference(this, "expiration_policy");

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&#39;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&#39;t modify the filter.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Filter => new TerraformReference(this, "filter");

    /// <summary>
    /// A set of key/value label pairs to assign to this Subscription.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

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
    [TerraformPropertyName("message_retention_duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MessageRetentionDuration => new TerraformReference(this, "message_retention_duration");

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// </summary>
    [TerraformPropertyName("message_transforms")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MessageTransforms => new TerraformReference(this, "message_transforms");

    /// <summary>
    /// If push delivery is used with this subscription, this field is used to
    /// configure it. An empty pushConfig signifies that the subscriber will
    /// pull and ack messages using API methods.
    /// </summary>
    [TerraformPropertyName("push_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PushConfig => new TerraformReference(this, "push_config");

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If &#39;true&#39;, then
    /// messages are not expunged from the subscription&#39;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    [TerraformPropertyName("retain_acked_messages")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RetainAckedMessages => new TerraformReference(this, "retain_acked_messages");

    /// <summary>
    /// A policy that specifies how Pub/Sub retries message delivery for this subscription.
    /// 
    /// If not set, the default retry policy is applied. This generally implies that messages will be retried as soon as possible for healthy subscribers.
    /// RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events for a given message
    /// </summary>
    [TerraformPropertyName("retry_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RetryPolicy => new TerraformReference(this, "retry_policy");

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
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [TerraformPropertyName("topic")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Topic => new TerraformReference(this, "topic");

}
