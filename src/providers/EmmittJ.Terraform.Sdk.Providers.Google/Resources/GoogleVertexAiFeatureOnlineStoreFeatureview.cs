using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for big_query_source in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock : ITerraformBlock
{
    /// <summary>
    /// Columns to construct entityId / row keys. Start by supporting 1 only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityIdColumns is required")]
    [TerraformPropertyName("entity_id_columns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? EntityIdColumns { get; set; }

    /// <summary>
    /// The BigQuery view URI that will be materialized on each sync trigger based on FeatureView.SyncConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

}

/// <summary>
/// Block type for feature_registry_source in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock : ITerraformBlock
{
    /// <summary>
    /// The project number of the parent project of the feature Groups.
    /// </summary>
    [TerraformPropertyName("project_number")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProjectNumber { get; set; }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If true, syncs the FeatureView in a continuous manner to Online Store.
    /// </summary>
    [TerraformPropertyName("continuous")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Continuous { get; set; }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or &amp;quot;TZ=${IANA_TIME_ZONE}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("cron")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Cron { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cron");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_vertex_ai_feature_online_store_featureview resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiFeatureOnlineStoreFeatureview : TerraformResource
{
    public GoogleVertexAiFeatureOnlineStoreFeatureview(string name) : base("google_vertex_ai_feature_online_store_featureview", name)
    {
    }

    /// <summary>
    /// The name of the FeatureOnlineStore to use for the featureview.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureOnlineStore is required")]
    [TerraformPropertyName("feature_online_store")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FeatureOnlineStore { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A set of key/value label pairs to assign to this FeatureView.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Name of the FeatureView. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region for the resource. It should be the same as the featureonlinestore region.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for big_query_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuerySource block(s) allowed")]
    [TerraformPropertyName("big_query_source")]
    public TerraformList<TerraformBlock<GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock>>? BigQuerySource { get; set; } = new();

    /// <summary>
    /// Block for feature_registry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureRegistrySource block(s) allowed")]
    [TerraformPropertyName("feature_registry_source")]
    public TerraformList<TerraformBlock<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock>>? FeatureRegistrySource { get; set; } = new();

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    [TerraformPropertyName("sync_config")]
    public TerraformList<TerraformBlock<GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock>>? SyncConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of when the featureOnlinestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The timestamp of when the featureOnlinestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
