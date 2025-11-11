using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreNotificationConfigBlock
{
    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformPropertyName("pubsub_topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PubsubTopic { get; set; }

}

/// <summary>
/// Block type for notification_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreNotificationConfigsBlock
{
    /// <summary>
    /// Restricts notifications sent for messages matching a filter. If this is empty, all messages
    /// are matched. Syntax: https://cloud.google.com/appengine/docs/standard/python/search/query_strings
    /// 
    /// Fields/functions available for filtering are:
    /// 
    /// * messageType, from the MSH-9.1 field. For example, NOT messageType = &amp;quot;ADT&amp;quot;.
    /// * send_date or sendDate, the YYYY-MM-DD date the message was sent in the dataset&#39;s timeZone, from the MSH-7 segment. For example, send_date &amp;lt; &amp;quot;2017-01-02&amp;quot;.
    /// * sendTime, the timestamp when the message was sent, using the RFC3339 time format for comparisons, from the MSH-7 segment. For example, sendTime &amp;lt; &amp;quot;2017-01-02T00:00:00-05:00&amp;quot;.
    /// * sendFacility, the care center that the message came from, from the MSH-4 segment. For example, sendFacility = &amp;quot;ABC&amp;quot;.
    /// * PatientId(value, type), which matches if the message lists a patient having an ID of the given value and type in the PID-2, PID-3, or PID-4 segments. For example, PatientId(&amp;quot;123456&amp;quot;, &amp;quot;MRN&amp;quot;).
    /// * labels.x, a string value of the label with key x as set using the Message.labels map. For example, labels.&amp;quot;priority&amp;quot;=&amp;quot;high&amp;quot;. The operator :* can be used to assert the existence of a label. For example, labels.&amp;quot;priority&amp;quot;:*.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// 
    /// If a notification cannot be published to Cloud Pub/Sub, errors will be logged to Stackdriver
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformPropertyName("pubsub_topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PubsubTopic { get; set; }

}

/// <summary>
/// Block type for parser_config in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreParserConfigBlock
{
    /// <summary>
    /// Determines whether messages with no header are allowed.
    /// </summary>
    [TerraformPropertyName("allow_null_header")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowNullHeader { get; set; }

    /// <summary>
    /// JSON encoded string for schemas used to parse messages in this
    /// store if schematized parsing is desired.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Schema { get; set; }

    /// <summary>
    /// Byte(s) to be used as the segment terminator. If this is unset, &#39;\r&#39; will be used as segment terminator.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("segment_terminator")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SegmentTerminator { get; set; }

    /// <summary>
    /// The version of the unschematized parser to be used when a custom &#39;schema&#39; is not set. Default value: &amp;quot;V1&amp;quot; Possible values: [&amp;quot;V1&amp;quot;, &amp;quot;V2&amp;quot;, &amp;quot;V3&amp;quot;]
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareHl7V2StoreTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_healthcare_hl7_v2_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleHealthcareHl7V2Store : TerraformResource
{
    public GoogleHealthcareHl7V2Store(string name) : base("google_healthcare_hl7_v2_store", name)
    {
    }

    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformPropertyName("dataset")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Dataset { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// User-supplied key-value pairs used to organize HL7v2 stores.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
    /// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// 
    /// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
    /// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// 
    /// No more than 64 labels can be associated with a given store.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The resource name for the Hl7V2Store.
    /// 
    /// ** Changing this property may recreate the Hl7v2 store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Determines whether duplicate messages are allowed.
    /// </summary>
    [TerraformPropertyName("reject_duplicate_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RejectDuplicateMessage { get; set; }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformPropertyName("notification_config")]
    public TerraformList<TerraformBlock<GoogleHealthcareHl7V2StoreNotificationConfigBlock>>? NotificationConfig { get; set; }

    /// <summary>
    /// Block for notification_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("notification_configs")]
    public TerraformList<TerraformBlock<GoogleHealthcareHl7V2StoreNotificationConfigsBlock>>? NotificationConfigs { get; set; }

    /// <summary>
    /// Block for parser_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParserConfig block(s) allowed")]
    [TerraformPropertyName("parser_config")]
    public TerraformList<TerraformBlock<GoogleHealthcareHl7V2StoreParserConfigBlock>>? ParserConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleHealthcareHl7V2StoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
