using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in GoogleHealthcareHl7V2Store.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformValue<string> PubsubTopic
    {
        get => GetRequiredArgument<TerraformValue<string>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

}


/// <summary>
/// Block type for notification_configs in GoogleHealthcareHl7V2Store.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreNotificationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_configs";

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
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

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
    public required TerraformValue<string> PubsubTopic
    {
        get => GetRequiredArgument<TerraformValue<string>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

}


/// <summary>
/// Block type for parser_config in GoogleHealthcareHl7V2Store.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareHl7V2StoreParserConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parser_config";

    /// <summary>
    /// Determines whether messages with no header are allowed.
    /// </summary>
    public TerraformValue<bool>? AllowNullHeader
    {
        get => GetArgument<TerraformValue<bool>>("allow_null_header");
        set => SetArgument("allow_null_header", value);
    }

    /// <summary>
    /// JSON encoded string for schemas used to parse messages in this
    /// store if schematized parsing is desired.
    /// </summary>
    public TerraformValue<string>? Schema
    {
        get => GetArgument<TerraformValue<string>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Byte(s) to be used as the segment terminator. If this is unset, &#39;\r&#39; will be used as segment terminator.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string>? SegmentTerminator
    {
        get => GetArgument<TerraformValue<string>>("segment_terminator");
        set => SetArgument("segment_terminator", value);
    }

    /// <summary>
    /// The version of the unschematized parser to be used when a custom &#39;schema&#39; is not set. Default value: &amp;quot;V1&amp;quot; Possible values: [&amp;quot;V1&amp;quot;, &amp;quot;V2&amp;quot;, &amp;quot;V3&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleHealthcareHl7V2Store.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareHl7V2StoreTimeoutsBlock : TerraformBlock
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
/// Represents a google_healthcare_hl7_v2_store Terraform resource.
/// Manages a google_healthcare_hl7_v2_store resource.
/// </summary>
public partial class GoogleHealthcareHl7V2Store(string name) : TerraformResource("google_healthcare_hl7_v2_store", name)
{
    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

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
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The resource name for the Hl7V2Store.
    /// 
    /// ** Changing this property may recreate the Hl7v2 store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Determines whether duplicate messages are allowed.
    /// </summary>
    public TerraformValue<bool>? RejectDuplicateMessage
    {
        get => GetArgument<TerraformValue<bool>>("reject_duplicate_message");
        set => SetArgument("reject_duplicate_message", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<GoogleHealthcareHl7V2StoreNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareHl7V2StoreNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// NotificationConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleHealthcareHl7V2StoreNotificationConfigsBlock>? NotificationConfigs
    {
        get => GetArgument<TerraformList<GoogleHealthcareHl7V2StoreNotificationConfigsBlock>>("notification_configs");
        set => SetArgument("notification_configs", value);
    }

    /// <summary>
    /// ParserConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParserConfig block(s) allowed")]
    public TerraformList<GoogleHealthcareHl7V2StoreParserConfigBlock>? ParserConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareHl7V2StoreParserConfigBlock>>("parser_config");
        set => SetArgument("parser_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcareHl7V2StoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcareHl7V2StoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
