using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeaturestoreEncryptionSpecBlock() : TerraformBlock("encryption_spec")
{
    /// <summary>
    /// The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. Has the form: projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key. The key needs to be in the same region as where the compute resource is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for online_serving_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeaturestoreOnlineServingConfigBlock() : TerraformBlock("online_serving_config")
{
    /// <summary>
    /// The number of nodes for each cluster. The number of nodes will not scale automatically but can be scaled manually by providing different values when updating.
    /// </summary>
    [TerraformProperty("fixed_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FixedNodeCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiFeaturestoreTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_vertex_ai_featurestore resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiFeaturestore : TerraformResource
{
    public GoogleVertexAiFeaturestore(string name) : base("google_vertex_ai_featurestore", name)
    {
    }

    /// <summary>
    /// If set to true, any EntityTypes and Features for this Featurestore will also be deleted
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to this Featurestore.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the Featurestore. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the dataset. eg us-central1
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public TerraformList<GoogleVertexAiFeaturestoreEncryptionSpecBlock> EncryptionSpec { get; set; } = new();

    /// <summary>
    /// Block for online_serving_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineServingConfig block(s) allowed")]
    [TerraformProperty("online_serving_config")]
    public TerraformList<GoogleVertexAiFeaturestoreOnlineServingConfigBlock> OnlineServingConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVertexAiFeaturestoreTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of when the featurestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

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
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp of when the featurestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
