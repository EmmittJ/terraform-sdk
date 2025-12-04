using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in GoogleHealthcareDicomStore.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareDicomStoreNotificationConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// Indicates whether or not to send Pub/Sub notifications on bulk import. Only supported for DICOM imports.
    /// </summary>
    public TerraformValue<bool>? SendForBulkImport
    {
        get => GetArgument<TerraformValue<bool>>("send_for_bulk_import");
        set => SetArgument("send_for_bulk_import", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleHealthcareDicomStore.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareDicomStoreTimeoutsBlock : TerraformBlock
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
/// Represents a google_healthcare_dicom_store Terraform resource.
/// Manages a google_healthcare_dicom_store resource.
/// </summary>
public partial class GoogleHealthcareDicomStore(string name) : TerraformResource("google_healthcare_dicom_store", name)
{
    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => GetArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-supplied key-value pairs used to organize DICOM stores.
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
    /// The resource name for the DicomStore.
    /// 
    /// ** Changing this property may recreate the Dicom store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    public TerraformList<GoogleHealthcareDicomStoreNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareDicomStoreNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcareDicomStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcareDicomStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
