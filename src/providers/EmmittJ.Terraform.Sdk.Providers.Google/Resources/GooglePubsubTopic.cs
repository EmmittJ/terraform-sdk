using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingestion_data_source_settings in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicIngestionDataSourceSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for message_storage_policy in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicMessageStoragePolicyBlock : TerraformBlock
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
    public HashSet<TerraformProperty<string>>? AllowedPersistenceRegions
    {
        set => SetProperty("allowed_persistence_regions", value);
    }

    /// <summary>
    /// If true, &#39;allowedPersistenceRegions&#39; is also used to enforce in-transit
    /// guarantees for messages. That is, Pub/Sub will fail topics.publish
    /// operations on this topic and subscribe operations on any subscription
    /// attached to this topic in any region that is not in &#39;allowedPersistenceRegions&#39;.
    /// </summary>
    public TerraformProperty<bool>? EnforceInTransit
    {
        set => SetProperty("enforce_in_transit", value);
    }

}

/// <summary>
/// Block type for message_transforms in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicMessageTransformsBlock : TerraformBlock
{
    /// <summary>
    /// Controls whether or not to use this transform. If not set or &#39;false&#39;,
    /// the transform will be applied to messages. Default: &#39;true&#39;.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        set => SetProperty("disabled", value);
    }

}

/// <summary>
/// Block type for schema_settings in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubTopicSchemaSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The encoding of messages validated against schema. Default value: &amp;quot;ENCODING_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;ENCODING_UNSPECIFIED&amp;quot;, &amp;quot;JSON&amp;quot;, &amp;quot;BINARY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The name of the schema that messages published should be
    /// validated against. Format is projects/{project}/schemas/{schema}.
    /// The value of this field will be _deleted-schema_
    /// if the schema has been deleted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformProperty<string> Schema
    {
        set => SetProperty("schema", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubTopicTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_pubsub_topic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePubsubTopic : TerraformResource
{
    public GooglePubsubTopic(string name) : base("google_pubsub_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("message_retention_duration");
        SetOutput("name");
        SetOutput("project");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

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
    public TerraformProperty<string> MessageRetentionDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message_retention_duration");
        set => SetProperty("message_retention_duration", value);
    }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

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
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for ingestion_data_source_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngestionDataSourceSettings block(s) allowed")]
    public List<GooglePubsubTopicIngestionDataSourceSettingsBlock>? IngestionDataSourceSettings
    {
        set => SetProperty("ingestion_data_source_settings", value);
    }

    /// <summary>
    /// Block for message_storage_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageStoragePolicy block(s) allowed")]
    public List<GooglePubsubTopicMessageStoragePolicyBlock>? MessageStoragePolicy
    {
        set => SetProperty("message_storage_policy", value);
    }

    /// <summary>
    /// Block for message_transforms.
    /// Nesting mode: list
    /// </summary>
    public List<GooglePubsubTopicMessageTransformsBlock>? MessageTransforms
    {
        set => SetProperty("message_transforms", value);
    }

    /// <summary>
    /// Block for schema_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaSettings block(s) allowed")]
    public List<GooglePubsubTopicSchemaSettingsBlock>? SchemaSettings
    {
        set => SetProperty("schema_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubTopicTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
