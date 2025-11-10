using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_pubsub_topic.
/// </summary>
public class GooglePubsubTopicDataSource : TerraformDataSource
{
    public GooglePubsubTopicDataSource(string name) : base("google_pubsub_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("ingestion_data_source_settings");
        this.DeclareOutput("kms_key_name");
        this.DeclareOutput("labels");
        this.DeclareOutput("message_retention_duration");
        this.DeclareOutput("message_storage_policy");
        this.DeclareOutput("message_transforms");
        this.DeclareOutput("schema_settings");
        this.DeclareOutput("tags");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Name of the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Settings for ingestion from a data source into this topic.
    /// </summary>
    public TerraformExpression IngestionDataSourceSettings => this["ingestion_data_source_settings"];

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey to be used to protect access
    /// to messages published on this topic. Your project&#39;s PubSub service account
    /// (&#39;service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com&#39;) must have
    /// &#39;roles/cloudkms.cryptoKeyEncrypterDecrypter&#39; to use this feature.
    /// The expected format is &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// A set of key/value label pairs to assign to this Topic.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

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
    public TerraformExpression MessageRetentionDuration => this["message_retention_duration"];

    /// <summary>
    /// Policy constraining the set of Google Cloud Platform regions where
    /// messages published to the topic may be stored. If not present, then no
    /// constraints are in effect.
    /// </summary>
    public TerraformExpression MessageStoragePolicy => this["message_storage_policy"];

    /// <summary>
    /// Transforms to be applied to messages published to the topic. Transforms are applied in the
    /// order specified.
    /// </summary>
    public TerraformExpression MessageTransforms => this["message_transforms"];

    /// <summary>
    /// Settings for validating messages published against a schema.
    /// </summary>
    public TerraformExpression SchemaSettings => this["schema_settings"];

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
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
