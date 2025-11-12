using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionBigqueryConfigBlock() : TerraformBlock("bigquery_config")
{
    /// <summary>
    /// When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that
    /// are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync
    /// and any messages with extra fields are not written and remain in the subscription&#39;s backlog.
    /// </summary>
    [TerraformProperty("drop_unknown_fields")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DropUnknownFields { get; set; }

    /// <summary>
    /// The service account to use to write to BigQuery. If not specified, the Pub/Sub
    /// [service agent](https://cloud.google.com/iam/docs/service-agents),
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccountEmail { get; set; }

    /// <summary>
    /// The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    [TerraformProperty("table")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Table { get; set; }

    /// <summary>
    /// When true, use the BigQuery table&#39;s schema as the columns to write to in BigQuery. Messages
    /// must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [TerraformProperty("use_table_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseTableSchema { get; set; }

    /// <summary>
    /// When true, use the topic&#39;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    [TerraformProperty("use_topic_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseTopicSchema { get; set; }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table.
    /// The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
    /// </summary>
    [TerraformProperty("write_metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WriteMetadata { get; set; }

}

/// <summary>
/// Block type for cloud_storage_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionCloudStorageConfigBlock() : TerraformBlock("cloud_storage_config")
{
    /// <summary>
    /// User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &amp;quot;gs://&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// User-provided format string specifying how to represent datetimes in Cloud Storage filenames.
    /// </summary>
    [TerraformProperty("filename_datetime_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilenameDatetimeFormat { get; set; }

    /// <summary>
    /// User-provided prefix for Cloud Storage filename.
    /// </summary>
    [TerraformProperty("filename_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilenamePrefix { get; set; }

    /// <summary>
    /// User-provided suffix for Cloud Storage filename. Must not end in &amp;quot;/&amp;quot;.
    /// </summary>
    [TerraformProperty("filename_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilenameSuffix { get; set; }

    /// <summary>
    /// The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB.
    /// The maxBytes limit may be exceeded in cases where messages are larger than the limit.
    /// </summary>
    [TerraformProperty("max_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxBytes { get; set; }

    /// <summary>
    /// The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes.
    /// May not exceed the subscription&#39;s acknowledgement deadline.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("max_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxDuration { get; set; }

    /// <summary>
    /// The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.
    /// </summary>
    [TerraformProperty("max_messages")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxMessages { get; set; }

    /// <summary>
    /// The service account to use to write to Cloud Storage. If not specified, the Pub/Sub
    /// [service agent](https://cloud.google.com/iam/docs/service-agents),
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccountEmail { get; set; }


}

/// <summary>
/// Block type for dead_letter_policy in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionDeadLetterPolicyBlock() : TerraformBlock("dead_letter_policy")
{
    /// <summary>
    /// The name of the topic to which dead letter messages should be published.
    /// Format is &#39;projects/{project}/topics/{topic}&#39;.
    /// 
    /// The Cloud Pub/Sub service account associated with the enclosing subscription&#39;s
    /// parent project (i.e.,
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must have
    /// permission to Publish() to this topic.
    /// 
    /// The operation will fail if the topic does not exist.
    /// Users should ensure that there is a subscription attached to this topic
    /// since messages published to a topic with no subscriptions are lost.
    /// </summary>
    [TerraformProperty("dead_letter_topic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeadLetterTopic { get; set; }

    /// <summary>
    /// The maximum number of delivery attempts for any message. The value must be
    /// between 5 and 100.
    /// 
    /// The number of delivery attempts is defined as 1 + (the sum of number of
    /// NACKs and number of times the acknowledgement deadline has been exceeded for the message).
    /// 
    /// A NACK is any call to ModifyAckDeadline with a 0 deadline. Note that
    /// client libraries may automatically extend ack_deadlines.
    /// 
    /// This field will be honored on a best effort basis.
    /// 
    /// If this parameter is 0, a default value of 5 is used.
    /// </summary>
    [TerraformProperty("max_delivery_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDeliveryAttempts { get; set; }

}

/// <summary>
/// Block type for expiration_policy in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionExpirationPolicyBlock() : TerraformBlock("expiration_policy")
{
    /// <summary>
    /// Specifies the &amp;quot;time-to-live&amp;quot; duration for an associated resource. The
    /// resource expires if it is not active for a period of ttl.
    /// If ttl is set to &amp;quot;&amp;quot;, the associated resource never expires.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example - &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    [TerraformProperty("ttl")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Ttl { get; set; }

}

/// <summary>
/// Block type for message_transforms in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionMessageTransformsBlock() : TerraformBlock("message_transforms")
{
    /// <summary>
    /// Controls whether or not to use this transform. If not set or &#39;false&#39;,
    /// the transform will be applied to messages. Default: &#39;true&#39;.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

}

/// <summary>
/// Block type for push_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionPushConfigBlock() : TerraformBlock("push_config")
{
    /// <summary>
    /// Endpoint configuration attributes.
    /// 
    /// Every endpoint has a set of API supported attributes that can
    /// be used to control different aspects of the message delivery.
    /// 
    /// The currently supported attribute is x-goog-version, which you
    /// can use to change the format of the pushed message. This
    /// attribute indicates the version of the data expected by
    /// the endpoint. This controls the shape of the pushed message
    /// (i.e., its fields and metadata). The endpoint version is
    /// based on the version of the Pub/Sub API.
    /// 
    /// If not present during the subscriptions.create call,
    /// it will default to the version of the API used to make
    /// such call. If not present during a subscriptions.modifyPushConfig
    /// call, its value will not be changed. subscriptions.get
    /// calls will always return a valid version, even if the
    /// subscription was created without this attribute.
    /// 
    /// The possible values for this attribute are:
    /// 
    /// - v1beta1: uses the push format defined in the v1beta1 Pub/Sub API.
    /// - v1 or v1beta2: uses the push format defined in the v1 Pub/Sub API.
    /// </summary>
    [TerraformProperty("attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// A URL locating the endpoint to which messages should be pushed.
    /// For example, a Webhook endpoint might use
    /// &amp;quot;https://example.com/push&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PushEndpoint is required")]
    [TerraformProperty("push_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PushEndpoint { get; set; }

}

/// <summary>
/// Block type for retry_policy in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubSubscriptionRetryPolicyBlock() : TerraformBlock("retry_policy")
{
    /// <summary>
    /// The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("maximum_backoff")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaximumBackoff { get; set; }

    /// <summary>
    /// The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("minimum_backoff")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinimumBackoff { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePubsubSubscriptionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_pubsub_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePubsubSubscription : TerraformResource
{
    public GooglePubsubSubscription(string name) : base("google_pubsub_subscription", name)
    {
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
    [TerraformProperty("ack_deadline_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AckDeadlineSeconds { get; set; }

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
    [TerraformProperty("enable_exactly_once_delivery")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableExactlyOnceDelivery { get; set; }

    /// <summary>
    /// If &#39;true&#39;, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    [TerraformProperty("enable_message_ordering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableMessageOrdering { get; set; }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&#39;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&#39;t modify the filter.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to this Subscription.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

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
    [TerraformProperty("message_retention_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If &#39;true&#39;, then
    /// messages are not expunged from the subscription&#39;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    [TerraformProperty("retain_acked_messages")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetainAckedMessages { get; set; }

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
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

    /// <summary>
    /// Block for bigquery_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryConfig block(s) allowed")]
    [TerraformProperty("bigquery_config")]
    public TerraformList<GooglePubsubSubscriptionBigqueryConfigBlock> BigqueryConfig { get; set; } = new();

    /// <summary>
    /// Block for cloud_storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageConfig block(s) allowed")]
    [TerraformProperty("cloud_storage_config")]
    public TerraformList<GooglePubsubSubscriptionCloudStorageConfigBlock> CloudStorageConfig { get; set; } = new();

    /// <summary>
    /// Block for dead_letter_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterPolicy block(s) allowed")]
    [TerraformProperty("dead_letter_policy")]
    public TerraformList<GooglePubsubSubscriptionDeadLetterPolicyBlock> DeadLetterPolicy { get; set; } = new();

    /// <summary>
    /// Block for expiration_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpirationPolicy block(s) allowed")]
    [TerraformProperty("expiration_policy")]
    public TerraformList<GooglePubsubSubscriptionExpirationPolicyBlock> ExpirationPolicy { get; set; } = new();

    /// <summary>
    /// Block for message_transforms.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("message_transforms")]
    public TerraformList<GooglePubsubSubscriptionMessageTransformsBlock> MessageTransforms { get; set; } = new();

    /// <summary>
    /// Block for push_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushConfig block(s) allowed")]
    [TerraformProperty("push_config")]
    public TerraformList<GooglePubsubSubscriptionPushConfigBlock> PushConfig { get; set; } = new();

    /// <summary>
    /// Block for retry_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    [TerraformProperty("retry_policy")]
    public TerraformList<GooglePubsubSubscriptionRetryPolicyBlock> RetryPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GooglePubsubSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
