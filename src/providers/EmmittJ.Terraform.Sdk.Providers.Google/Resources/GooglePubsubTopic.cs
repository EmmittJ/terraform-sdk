using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingestion_data_source_settings in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubTopicIngestionDataSourceSettingsBlock() : TerraformBlock("ingestion_data_source_settings")
{
}

/// <summary>
/// Block type for message_storage_policy in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubTopicMessageStoragePolicyBlock() : TerraformBlock("message_storage_policy")
{
    /// <summary>
    /// A list of IDs of GCP regions where messages that are published to
    /// the topic may be persisted in storage. Messages published by
    /// publishers running in non-allowed GCP regions (or running outside
    /// of GCP altogether) will be routed for storage in one of the
    /// allowed regions. An empty list means that no regions are allowed,
    /// and is not a valid configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPersistenceRegions is required")]
    [TerraformProperty("allowed_persistence_regions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedPersistenceRegions { get; set; }

    /// <summary>
    /// If true, &#39;allowedPersistenceRegions&#39; is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in &#39;allowedPersistenceRegions&#39;.
    /// </summary>
    [TerraformProperty("enforce_in_transit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnforceInTransit { get; set; }

}

/// <summary>
/// Block type for message_transforms in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubTopicMessageTransformsBlock() : TerraformBlock("message_transforms")
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
/// Block type for schema_settings in .
/// Nesting mode: list
/// </summary>
public partial class GooglePubsubTopicSchemaSettingsBlock() : TerraformBlock("schema_settings")
{
    /// <summary>
    /// The encoding of messages validated against schema. Default value: &amp;quot;ENCODING_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;BINARY&amp;quot;]
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be _deleted-schema_
    /// if the schema has been deleted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [TerraformProperty("schema")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Schema { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePubsubTopicTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_pubsub_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePubsubTopic : TerraformResource
{
    public GooglePubsubTopic(string name) : base("google_pubsub_topic", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageRetentionDuration { get; set; }

    /// <summary>
    /// Name of the topic.
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
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ingestion_data_source_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngestionDataSourceSettings block(s) allowed")]
    [TerraformProperty("ingestion_data_source_settings")]
    public TerraformList<GooglePubsubTopicIngestionDataSourceSettingsBlock> IngestionDataSourceSettings { get; set; } = new();

    /// <summary>
    /// Block for message_storage_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageStoragePolicy block(s) allowed")]
    [TerraformProperty("message_storage_policy")]
    public TerraformList<GooglePubsubTopicMessageStoragePolicyBlock> MessageStoragePolicy { get; set; } = new();

    /// <summary>
    /// Block for message_transforms.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("message_transforms")]
    public TerraformList<GooglePubsubTopicMessageTransformsBlock> MessageTransforms { get; set; } = new();

    /// <summary>
    /// Block for schema_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaSettings block(s) allowed")]
    [TerraformProperty("schema_settings")]
    public TerraformList<GooglePubsubTopicSchemaSettingsBlock> SchemaSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GooglePubsubTopicTimeoutsBlock Timeouts { get; set; } = new();

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
