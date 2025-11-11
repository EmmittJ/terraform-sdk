using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_pubsub_topic.
/// </summary>
public partial class GooglePubsubTopicDataSource : TerraformDataSource
{
    public GooglePubsubTopicDataSource(string name) : base("google_pubsub_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// </summary>
    [TerraformProperty("ingestion_data_source_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IngestionDataSourceSettings { get; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyName { get; }

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Indicates the minimum duration to retain a message after it is published
    /// to the topic. If this field is set, messages published to the topic in
    /// the last messageRetentionDuration are always available to subscribers.
    /// For instance, it allows any attached subscription to seek to a timestamp
    /// that is up to messageRetentionDuration in the past. If this field is not
    /// set, message retention is controlled by settings on individual subscriptions.
    /// The rotation period has the format of a decimal number, followed by the
    /// letter &#39;s&#39; (seconds). Cannot be more than 31 days or less than 10 minutes.
    /// </summary>
    [TerraformProperty("message_retention_duration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MessageRetentionDuration { get; }

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// </summary>
    [TerraformProperty("message_storage_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MessageStoragePolicy { get; }

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// </summary>
    [TerraformProperty("message_transforms")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MessageTransforms { get; }

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// </summary>
    [TerraformProperty("schema_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SchemaSettings { get; }

    /// <summary>
    /// Input only. Resource manager tags to be bound to the topic. Tag keys and
    /// values have the same definition as resource manager tags. Keys must be in
    /// the format tagKeys/{tag_key_id}, and values are in the format
    /// tagValues/456. The field is ignored when empty. The field is immutable and
    /// causes resource replacement when mutated. This field is only set at create
    /// time and modifying this field after creation will trigger recreation. To
    /// apply tags to an existing resource, see the &#39;google_tags_tag_value&#39;
    /// resource.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
