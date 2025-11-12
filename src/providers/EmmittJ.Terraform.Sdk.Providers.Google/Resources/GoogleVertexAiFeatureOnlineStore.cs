using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bigtable in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreBigtableBlock() : TerraformBlock("bigtable")
{
}

/// <summary>
/// Block type for dedicated_serving_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock() : TerraformBlock("dedicated_serving_endpoint")
{


}

/// <summary>
/// Block type for optimized in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreOptimizedBlock() : TerraformBlock("optimized")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_vertex_ai_feature_online_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiFeatureOnlineStore : TerraformResource
{
    public GoogleVertexAiFeatureOnlineStore(string name) : base("google_vertex_ai_feature_online_store", name)
    {
    }

    /// <summary>
    /// If set to true, any FeatureViews and Features for this FeatureOnlineStore will also be deleted.
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
    /// The labels with user-defined metadata to organize your feature online stores.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The resource name of the Feature Online Store. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
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
    /// The region of feature online store. eg us-central1
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for bigtable.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bigtable block(s) allowed")]
    [TerraformProperty("bigtable")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreBigtableBlock> Bigtable { get; set; } = new();

    /// <summary>
    /// Block for dedicated_serving_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DedicatedServingEndpoint block(s) allowed")]
    [TerraformProperty("dedicated_serving_endpoint")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreDedicatedServingEndpointBlock> DedicatedServingEndpoint { get; set; } = new();

    /// <summary>
    /// Block for optimized.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Optimized block(s) allowed")]
    [TerraformProperty("optimized")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreOptimizedBlock> Optimized { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVertexAiFeatureOnlineStoreTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of when the feature online store was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The state of the Feature Online Store. See the possible states in [this link](https://cloud.google.com/vertex-ai/docs/reference/rest/v1/projects.locations.featureOnlineStores#state).
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp of when the feature online store was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
