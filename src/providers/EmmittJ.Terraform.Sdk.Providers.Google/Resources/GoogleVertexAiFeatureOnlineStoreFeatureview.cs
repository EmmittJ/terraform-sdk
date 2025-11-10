using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for big_query_source in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Columns to construct entityId / row keys. Start by supporting 1 only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityIdColumns is required")]
    public List<TerraformProperty<string>>? EntityIdColumns
    {
        set => SetProperty("entity_id_columns", value);
    }

    /// <summary>
    /// The BigQuery view URI that will be materialized on each sync trigger based on FeatureView.SyncConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for feature_registry_source in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock : TerraformBlock
{
    /// <summary>
    /// The project number of the parent project of the feature Groups.
    /// </summary>
    public TerraformProperty<string>? ProjectNumber
    {
        set => SetProperty("project_number", value);
    }

}

/// <summary>
/// Block type for sync_config in .
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// If true, syncs the FeatureView in a continuous manner to Online Store.
    /// </summary>
    public TerraformProperty<bool>? Continuous
    {
        set => SetProperty("continuous", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or &amp;quot;TZ=${IANA_TIME_ZONE}&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Cron
    {
        set => SetProperty("cron", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock : TerraformBlock
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
/// Manages a google_vertex_ai_feature_online_store_featureview resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVertexAiFeatureOnlineStoreFeatureview : TerraformResource
{
    public GoogleVertexAiFeatureOnlineStoreFeatureview(string name) : base("google_vertex_ai_feature_online_store_featureview", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("feature_online_store");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The name of the FeatureOnlineStore to use for the featureview.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureOnlineStore is required")]
    public required TerraformProperty<string> FeatureOnlineStore
    {
        get => GetRequiredOutput<TerraformProperty<string>>("feature_online_store");
        set => SetProperty("feature_online_store", value);
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
    /// A set of key/value label pairs to assign to this FeatureView.
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
    /// Name of the FeatureView. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    public TerraformProperty<string> Name
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
    /// The region for the resource. It should be the same as the featureonlinestore region.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for big_query_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuerySource block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock>? BigQuerySource
    {
        set => SetProperty("big_query_source", value);
    }

    /// <summary>
    /// Block for feature_registry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureRegistrySource block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock>? FeatureRegistrySource
    {
        set => SetProperty("feature_registry_source", value);
    }

    /// <summary>
    /// Block for sync_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public List<GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock>? SyncConfig
    {
        set => SetProperty("sync_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of when the featureOnlinestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp of when the featureOnlinestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
