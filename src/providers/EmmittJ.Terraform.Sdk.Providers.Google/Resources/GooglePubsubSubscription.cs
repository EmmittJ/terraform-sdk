using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigquery_config in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionBigqueryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_config";

    /// <summary>
    /// When true and use_topic_schema or use_table_schema is true, any fields that are a part of the topic schema or message schema that
    /// are not part of the BigQuery table schema are dropped when writing to BigQuery. Otherwise, the schemas must be kept in sync
    /// and any messages with extra fields are not written and remain in the subscription&#39;s backlog.
    /// </summary>
    public TerraformValue<bool>? DropUnknownFields
    {
        get => GetArgument<TerraformValue<bool>>("drop_unknown_fields");
        set => SetArgument("drop_unknown_fields", value);
    }

    /// <summary>
    /// The service account to use to write to BigQuery. If not specified, the Pub/Sub
    /// [service agent](https://cloud.google.com/iam/docs/service-agents),
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// The name of the table to which to write data, of the form {projectId}.{datasetId}.{tableId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => GetRequiredArgument<TerraformValue<string>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// When true, use the BigQuery table&#39;s schema as the columns to write to in BigQuery. Messages
    /// must be published in JSON format. Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    public TerraformValue<bool>? UseTableSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_table_schema");
        set => SetArgument("use_table_schema", value);
    }

    /// <summary>
    /// When true, use the topic&#39;s schema as the columns to write to in BigQuery, if it exists.
    /// Only one of use_topic_schema and use_table_schema can be set.
    /// </summary>
    public TerraformValue<bool>? UseTopicSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_topic_schema");
        set => SetArgument("use_topic_schema", value);
    }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey to additional columns in the table.
    /// The subscription name, messageId, and publishTime fields are put in their own columns while all other message properties (other than data) are written to a JSON object in the attributes column.
    /// </summary>
    public TerraformValue<bool>? WriteMetadata
    {
        get => GetArgument<TerraformValue<bool>>("write_metadata");
        set => SetArgument("write_metadata", value);
    }

}


/// <summary>
/// Block type for cloud_storage_config in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionCloudStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_config";

    /// <summary>
    /// User-provided name for the Cloud Storage bucket. The bucket must be created by the user. The bucket name must be without any prefix like &amp;quot;gs://&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// User-provided format string specifying how to represent datetimes in Cloud Storage filenames.
    /// </summary>
    public TerraformValue<string>? FilenameDatetimeFormat
    {
        get => GetArgument<TerraformValue<string>>("filename_datetime_format");
        set => SetArgument("filename_datetime_format", value);
    }

    /// <summary>
    /// User-provided prefix for Cloud Storage filename.
    /// </summary>
    public TerraformValue<string>? FilenamePrefix
    {
        get => GetArgument<TerraformValue<string>>("filename_prefix");
        set => SetArgument("filename_prefix", value);
    }

    /// <summary>
    /// User-provided suffix for Cloud Storage filename. Must not end in &amp;quot;/&amp;quot;.
    /// </summary>
    public TerraformValue<string>? FilenameSuffix
    {
        get => GetArgument<TerraformValue<string>>("filename_suffix");
        set => SetArgument("filename_suffix", value);
    }

    /// <summary>
    /// The maximum bytes that can be written to a Cloud Storage file before a new file is created. Min 1 KB, max 10 GiB.
    /// The maxBytes limit may be exceeded in cases where messages are larger than the limit.
    /// </summary>
    public TerraformValue<double>? MaxBytes
    {
        get => GetArgument<TerraformValue<double>>("max_bytes");
        set => SetArgument("max_bytes", value);
    }

    /// <summary>
    /// The maximum duration that can elapse before a new Cloud Storage file is created. Min 1 minute, max 10 minutes, default 5 minutes.
    /// May not exceed the subscription&#39;s acknowledgement deadline.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxDuration
    {
        get => GetArgument<TerraformValue<string>>("max_duration");
        set => SetArgument("max_duration", value);
    }

    /// <summary>
    /// The maximum messages that can be written to a Cloud Storage file before a new file is created. Min 1000 messages.
    /// </summary>
    public TerraformValue<double>? MaxMessages
    {
        get => GetArgument<TerraformValue<double>>("max_messages");
        set => SetArgument("max_messages", value);
    }

    /// <summary>
    /// The service account to use to write to Cloud Storage. If not specified, the Pub/Sub
    /// [service agent](https://cloud.google.com/iam/docs/service-agents),
    /// service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com, is used.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// An output-only field that indicates whether or not the subscription can receive messages.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// AvroConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvroConfig block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionCloudStorageConfigBlockAvroConfigBlock>? AvroConfig
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionCloudStorageConfigBlockAvroConfigBlock>>("avro_config");
        set => SetArgument("avro_config", value);
    }

}

/// <summary>
/// Block type for avro_config in GooglePubsubSubscriptionCloudStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionCloudStorageConfigBlockAvroConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro_config";

    /// <summary>
    /// When true, the output Cloud Storage file will be serialized using the topic schema, if it exists.
    /// </summary>
    public TerraformValue<bool>? UseTopicSchema
    {
        get => GetArgument<TerraformValue<bool>>("use_topic_schema");
        set => SetArgument("use_topic_schema", value);
    }

    /// <summary>
    /// When true, write the subscription name, messageId, publishTime, attributes, and orderingKey as additional fields in the output.
    /// </summary>
    public TerraformValue<bool>? WriteMetadata
    {
        get => GetArgument<TerraformValue<bool>>("write_metadata");
        set => SetArgument("write_metadata", value);
    }

}


/// <summary>
/// Block type for dead_letter_policy in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionDeadLetterPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_policy";

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
    public TerraformValue<string>? DeadLetterTopic
    {
        get => GetArgument<TerraformValue<string>>("dead_letter_topic");
        set => SetArgument("dead_letter_topic", value);
    }

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
    public TerraformValue<double>? MaxDeliveryAttempts
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_attempts");
        set => SetArgument("max_delivery_attempts", value);
    }

}


/// <summary>
/// Block type for expiration_policy in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionExpirationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration_policy";

    /// <summary>
    /// Specifies the &amp;quot;time-to-live&amp;quot; duration for an associated resource. The
    /// resource expires if it is not active for a period of ttl.
    /// If ttl is set to &amp;quot;&amp;quot;, the associated resource never expires.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// Example - &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<string> Ttl
    {
        get => GetRequiredArgument<TerraformValue<string>>("ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for message_transforms in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionMessageTransformsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message_transforms";

    /// <summary>
    /// Controls whether or not to use this transform. If not set or &#39;false&#39;,
    /// the transform will be applied to messages. Default: &#39;true&#39;.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// JavascriptUdf block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JavascriptUdf block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionMessageTransformsBlockJavascriptUdfBlock>? JavascriptUdf
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionMessageTransformsBlockJavascriptUdfBlock>>("javascript_udf");
        set => SetArgument("javascript_udf", value);
    }

}

/// <summary>
/// Block type for javascript_udf in GooglePubsubSubscriptionMessageTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionMessageTransformsBlockJavascriptUdfBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "javascript_udf";

    /// <summary>
    /// JavaScript code that contains a function &#39;function_name&#39; with the
    /// following signature:
    /// &#39;&#39;&#39;
    ///   /**
    ///   * Transforms a Pub/Sub message.
    ///   *
    ///   * @return {(Object&amp;lt;string, (string | Object&amp;lt;string, string&amp;gt;)&amp;gt;|null)} - To
    ///   * filter a message, return &#39;null&#39;. To transform a message return a map
    ///   * with the following keys:
    ///   *   - (required) &#39;data&#39; : {string}
    ///   *   - (optional) &#39;attributes&#39; : {Object&amp;lt;string, string&amp;gt;}
    ///   * Returning empty &#39;attributes&#39; will remove all attributes from the
    ///   * message.
    ///   *
    ///   * @param  {(Object&amp;lt;string, (string | Object&amp;lt;string, string&amp;gt;)&amp;gt;} Pub/Sub
    ///   * message. Keys:
    ///   *   - (required) &#39;data&#39; : {string}
    ///   *   - (required) &#39;attributes&#39; : {Object&amp;lt;string, string&amp;gt;}
    ///   *
    ///   * @param  {Object&amp;lt;string, any&amp;gt;} metadata - Pub/Sub message metadata.
    ///   * Keys:
    ///   *   - (required) &#39;message_id&#39;  : {string}
    ///   *   - (optional) &#39;publish_time&#39;: {string} YYYY-MM-DDTHH:MM:SSZ format
    ///   *   - (optional) &#39;ordering_key&#39;: {string}
    ///   */
    ///   function &amp;lt;function_name&amp;gt;(message, metadata) {
    ///   }
    /// &#39;&#39;&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => GetRequiredArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// Name of the JavaScript function that should be applied to Pub/Sub messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

}


/// <summary>
/// Block type for push_config in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionPushConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "push_config";

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
    public TerraformMap<string>? Attributes
    {
        get => GetArgument<TerraformMap<string>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// A URL locating the endpoint to which messages should be pushed.
    /// For example, a Webhook endpoint might use
    /// &amp;quot;https://example.com/push&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PushEndpoint is required")]
    public required TerraformValue<string> PushEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("push_endpoint");
        set => SetArgument("push_endpoint", value);
    }

    /// <summary>
    /// NoWrapper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NoWrapper block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionPushConfigBlockNoWrapperBlock>? NoWrapper
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionPushConfigBlockNoWrapperBlock>>("no_wrapper");
        set => SetArgument("no_wrapper", value);
    }

    /// <summary>
    /// OidcToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcToken block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionPushConfigBlockOidcTokenBlock>? OidcToken
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionPushConfigBlockOidcTokenBlock>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }

}

/// <summary>
/// Block type for no_wrapper in GooglePubsubSubscriptionPushConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionPushConfigBlockNoWrapperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "no_wrapper";

    /// <summary>
    /// When true, writes the Pub/Sub message metadata to
    /// &#39;x-goog-pubsub-&amp;lt;KEY&amp;gt;:&amp;lt;VAL&amp;gt;&#39; headers of the HTTP request. Writes the
    /// Pub/Sub message attributes to &#39;&amp;lt;KEY&amp;gt;:&amp;lt;VAL&amp;gt;&#39; headers of the HTTP request.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteMetadata is required")]
    public required TerraformValue<bool> WriteMetadata
    {
        get => GetRequiredArgument<TerraformValue<bool>>("write_metadata");
        set => SetArgument("write_metadata", value);
    }

}

/// <summary>
/// Block type for oidc_token in GooglePubsubSubscriptionPushConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionPushConfigBlockOidcTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_token";

    /// <summary>
    /// Audience to be used when generating OIDC token. The audience claim
    /// identifies the recipients that the JWT is intended for. The audience
    /// value is a single case-sensitive string. Having multiple values (array)
    /// for the audience field is not supported. More info about the OIDC JWT
    /// token audience here: https://tools.ietf.org/html/rfc7519#section-4.1.3
    /// Note: if not specified, the Push endpoint URL will be used.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => GetArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// Service account email to be used for generating the OIDC token.
    /// The caller (for subscriptions.create, subscriptions.patch, and
    /// subscriptions.modifyPushConfig RPCs) must have the
    /// iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

}


/// <summary>
/// Block type for retry_policy in GooglePubsubSubscription.
/// Nesting mode: list
/// </summary>
public class GooglePubsubSubscriptionRetryPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_policy";

    /// <summary>
    /// The maximum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 600 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> MaximumBackoff
    {
        get => GetArgument<TerraformValue<string>>("maximum_backoff") ?? CreateReference("maximum_backoff");
        set => SetArgument("maximum_backoff", value);
    }

    /// <summary>
    /// The minimum delay between consecutive deliveries of a given message. Value should be between 0 and 600 seconds. Defaults to 10 seconds.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string> MinimumBackoff
    {
        get => GetArgument<TerraformValue<string>>("minimum_backoff") ?? CreateReference("minimum_backoff");
        set => SetArgument("minimum_backoff", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePubsubSubscription.
/// Nesting mode: single
/// </summary>
public class GooglePubsubSubscriptionTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_pubsub_subscription Terraform resource.
/// Manages a google_pubsub_subscription resource.
/// </summary>
public partial class GooglePubsubSubscription(string name) : TerraformResource("google_pubsub_subscription", name)
{
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
    public TerraformValue<double> AckDeadlineSeconds
    {
        get => GetArgument<TerraformValue<double>>("ack_deadline_seconds") ?? CreateReference("ack_deadline_seconds");
        set => SetArgument("ack_deadline_seconds", value);
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
    public TerraformValue<bool>? EnableExactlyOnceDelivery
    {
        get => GetArgument<TerraformValue<bool>>("enable_exactly_once_delivery");
        set => SetArgument("enable_exactly_once_delivery", value);
    }

    /// <summary>
    /// If &#39;true&#39;, messages published with the same orderingKey in PubsubMessage will be delivered to
    /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they
    /// may be delivered in any order.
    /// </summary>
    public TerraformValue<bool>? EnableMessageOrdering
    {
        get => GetArgument<TerraformValue<bool>>("enable_message_ordering");
        set => SetArgument("enable_message_ordering", value);
    }

    /// <summary>
    /// The subscription only delivers the messages that match the filter.
    /// Pub/Sub automatically acknowledges the messages that don&#39;t match the filter. You can filter messages
    /// by their attributes. The maximum length of a filter is 256 bytes. After creating the subscription,
    /// you can&#39;t modify the filter.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Subscription.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
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
    public TerraformValue<string>? MessageRetentionDuration
    {
        get => GetArgument<TerraformValue<string>>("message_retention_duration");
        set => SetArgument("message_retention_duration", value);
    }

    /// <summary>
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Indicates whether to retain acknowledged messages. If &#39;true&#39;, then
    /// messages are not expunged from the subscription&#39;s backlog, even if
    /// they are acknowledged, until they fall out of the
    /// messageRetentionDuration window.
    /// </summary>
    public TerraformValue<bool>? RetainAckedMessages
    {
        get => GetArgument<TerraformValue<bool>>("retain_acked_messages");
        set => SetArgument("retain_acked_messages", value);
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
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// A reference to a Topic resource, of the form projects/{project}/topics/{{name}}
    /// (as in the id property of a google_pubsub_topic), or just a topic name if
    /// the topic is in the same project as the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// BigqueryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryConfig block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionBigqueryConfigBlock>? BigqueryConfig
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionBigqueryConfigBlock>>("bigquery_config");
        set => SetArgument("bigquery_config", value);
    }

    /// <summary>
    /// CloudStorageConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageConfig block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionCloudStorageConfigBlock>? CloudStorageConfig
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionCloudStorageConfigBlock>>("cloud_storage_config");
        set => SetArgument("cloud_storage_config", value);
    }

    /// <summary>
    /// DeadLetterPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterPolicy block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionDeadLetterPolicyBlock>? DeadLetterPolicy
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionDeadLetterPolicyBlock>>("dead_letter_policy");
        set => SetArgument("dead_letter_policy", value);
    }

    /// <summary>
    /// ExpirationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpirationPolicy block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionExpirationPolicyBlock>? ExpirationPolicy
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionExpirationPolicyBlock>>("expiration_policy");
        set => SetArgument("expiration_policy", value);
    }

    /// <summary>
    /// MessageTransforms block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePubsubSubscriptionMessageTransformsBlock>? MessageTransforms
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionMessageTransformsBlock>>("message_transforms");
        set => SetArgument("message_transforms", value);
    }

    /// <summary>
    /// PushConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushConfig block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionPushConfigBlock>? PushConfig
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionPushConfigBlock>>("push_config");
        set => SetArgument("push_config", value);
    }

    /// <summary>
    /// RetryPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryPolicy block(s) allowed")]
    public TerraformList<GooglePubsubSubscriptionRetryPolicyBlock>? RetryPolicy
    {
        get => GetArgument<TerraformList<GooglePubsubSubscriptionRetryPolicyBlock>>("retry_policy");
        set => SetArgument("retry_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePubsubSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePubsubSubscriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
