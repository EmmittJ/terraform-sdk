using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_pubsub_topic.
/// </summary>
public class GooglePubsubTopicDataSource : TerraformDataSource
{
    public GooglePubsubTopicDataSource(string name) : base("google_pubsub_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// </summary>
    [TerraformPropertyName("ingestion_data_source_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IngestionDataSourceSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ingestion_data_source_settings");

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

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
    [TerraformPropertyName("message_retention_duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MessageRetentionDuration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "message_retention_duration");

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// </summary>
    [TerraformPropertyName("message_storage_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MessageStoragePolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "message_storage_policy");

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// </summary>
    [TerraformPropertyName("message_transforms")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MessageTransforms => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "message_transforms");

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// </summary>
    [TerraformPropertyName("schema_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SchemaSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schema_settings");

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
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
