using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiIndexEncryptionSpecBlock() : TerraformBlock("encryption_spec")
{
    /// <summary>
    /// Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: &#39;projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key&#39;. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiIndexMetadataBlock() : TerraformBlock("metadata")
{
    /// <summary>
    /// Allows inserting, updating  or deleting the contents of the Matching Engine Index.
    /// The string must be a valid Cloud Storage directory path. If this
    /// field is set when calling IndexService.UpdateIndex, then no other
    /// Index field can be also updated as part of the same call.
    /// The expected structure and format of the files this URI points to is
    /// described at https://cloud.google.com/vertex-ai/docs/matching-engine/using-matching-engine#input-data-format
    /// </summary>
    [TerraformProperty("contents_delta_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentsDeltaUri { get; set; }

    /// <summary>
    /// If this field is set together with contentsDeltaUri when calling IndexService.UpdateIndex,
    /// then existing content of the Index will be replaced by the data from the contentsDeltaUri.
    /// </summary>
    [TerraformProperty("is_complete_overwrite")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsCompleteOverwrite { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiIndexTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_vertex_ai_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiIndex : TerraformResource
{
    public GoogleVertexAiIndex(string name) : base("google_vertex_ai_index", name)
    {
    }

    /// <summary>
    /// The description of the Index.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the Index. The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The update method to use with this Index. The value must be the followings. If not set, BATCH_UPDATE will be used by default.
    /// * BATCH_UPDATE: user can call indexes.patch with files on Cloud Storage of datapoints to update.
    /// * STREAM_UPDATE: user can call indexes.upsertDatapoints/DeleteDatapoints to update the Index and the updates will be applied in corresponding DeployedIndexes in nearly real-time.
    /// </summary>
    [TerraformProperty("index_update_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IndexUpdateMethod { get; set; }

    /// <summary>
    /// The labels with user-defined metadata to organize your Indexes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the index. eg us-central1
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public TerraformList<GoogleVertexAiIndexEncryptionSpecBlock> EncryptionSpec { get; set; } = new();

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Metadata block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    [TerraformProperty("metadata")]
    public required TerraformList<GoogleVertexAiIndexMetadataBlock> Metadata { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVertexAiIndexTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of when the Index was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The pointers to DeployedIndexes created from this Index. An Index can be only deleted if all its DeployedIndexes had been undeployed first.
    /// </summary>
    [TerraformProperty("deployed_indexes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DeployedIndexes { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Used to perform consistent read-modify-write updates.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Stats of the index resource.
    /// </summary>
    [TerraformProperty("index_stats")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IndexStats { get; }

    /// <summary>
    /// Points to a YAML file stored on Google Cloud Storage describing additional information about the Index, that is specific to it. Unset if the Index does not have any additional information.
    /// </summary>
    [TerraformProperty("metadata_schema_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetadataSchemaUri { get; }

    /// <summary>
    /// The resource name of the Index.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp of when the Index was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
