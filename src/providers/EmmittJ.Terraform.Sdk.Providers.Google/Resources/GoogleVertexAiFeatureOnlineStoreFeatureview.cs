using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for big_query_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock() : TerraformBlock("big_query_source")
{
    /// <summary>
    /// Columns to construct entityId / row keys. Start by supporting 1 only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityIdColumns is required")]
    [TerraformProperty("entity_id_columns")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? EntityIdColumns { get; set; }

    /// <summary>
    /// The BigQuery view URI that will be materialized on each sync trigger based on FeatureView.SyncConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for feature_registry_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock() : TerraformBlock("feature_registry_source")
{
    /// <summary>
    /// The project number of the parent project of the feature Groups.
    /// </summary>
    [TerraformProperty("project_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectNumber { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock() : TerraformBlock("sync_config")
{
    /// <summary>
    /// If true, syncs the FeatureView in a continuous manner to Online Store.
    /// </summary>
    [TerraformProperty("continuous")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Continuous { get; set; }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or &amp;quot;TZ=${IANA_TIME_ZONE}&amp;quot;.
    /// </summary>
    [TerraformProperty("cron")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Cron { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_vertex_ai_feature_online_store_featureview resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVertexAiFeatureOnlineStoreFeatureview : TerraformResource
{
    public GoogleVertexAiFeatureOnlineStoreFeatureview(string name) : base("google_vertex_ai_feature_online_store_featureview", name)
    {
    }

    /// <summary>
    /// The name of the FeatureOnlineStore to use for the featureview.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureOnlineStore is required")]
    [TerraformProperty("feature_online_store")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FeatureOnlineStore { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to this FeatureView.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the FeatureView. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
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
    /// The region for the resource. It should be the same as the featureonlinestore region.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for big_query_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuerySource block(s) allowed")]
    [TerraformProperty("big_query_source")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock> BigQuerySource { get; set; } = new();

    /// <summary>
    /// Block for feature_registry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureRegistrySource block(s) allowed")]
    [TerraformProperty("feature_registry_source")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock> FeatureRegistrySource { get; set; } = new();

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformProperty("sync_config")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock> SyncConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of when the featureOnlinestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
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
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The timestamp of when the featureOnlinestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
