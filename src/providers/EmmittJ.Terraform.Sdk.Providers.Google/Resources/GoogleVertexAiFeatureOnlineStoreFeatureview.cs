using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for big_query_source in GoogleVertexAiFeatureOnlineStoreFeatureview.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query_source";

    /// <summary>
    /// Columns to construct entityId / row keys. Start by supporting 1 only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityIdColumns is required")]
    public TerraformList<string>? EntityIdColumns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "entity_id_columns").ResolveNodes(ctx));
        set => SetArgument("entity_id_columns", value);
    }

    /// <summary>
    /// The BigQuery view URI that will be materialized on each sync trigger based on FeatureView.SyncConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for feature_registry_source in GoogleVertexAiFeatureOnlineStoreFeatureview.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_registry_source";

    /// <summary>
    /// The project number of the parent project of the feature Groups.
    /// </summary>
    public TerraformValue<string>? ProjectNumber
    {
        get => new TerraformReference<string>(this, "project_number");
        set => SetArgument("project_number", value);
    }

    /// <summary>
    /// FeatureGroups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureGroups block(s) required")]
    public required TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlockFeatureGroupsBlock> FeatureGroups
    {
        get => GetRequiredArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlockFeatureGroupsBlock>>("feature_groups");
        set => SetArgument("feature_groups", value);
    }

}

/// <summary>
/// Block type for feature_groups in GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlockFeatureGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_groups";

    /// <summary>
    /// Identifier of the feature group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupId is required")]
    public required TerraformValue<string> FeatureGroupId
    {
        get => new TerraformReference<string>(this, "feature_group_id");
        set => SetArgument("feature_group_id", value);
    }

    /// <summary>
    /// Identifiers of features under the feature group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureIds is required")]
    public TerraformList<string>? FeatureIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "feature_ids").ResolveNodes(ctx));
        set => SetArgument("feature_ids", value);
    }

}


/// <summary>
/// Block type for sync_config in GoogleVertexAiFeatureOnlineStoreFeatureview.
/// Nesting mode: list
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sync_config";

    /// <summary>
    /// If true, syncs the FeatureView in a continuous manner to Online Store.
    /// </summary>
    public TerraformValue<bool>? Continuous
    {
        get => new TerraformReference<bool>(this, "continuous");
        set => SetArgument("continuous", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or &amp;quot;TZ=${IANA_TIME_ZONE}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Cron
    {
        get => new TerraformReference<string>(this, "cron");
        set => SetArgument("cron", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVertexAiFeatureOnlineStoreFeatureview.
/// Nesting mode: single
/// </summary>
public class GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_vertex_ai_feature_online_store_featureview Terraform resource.
/// Manages a google_vertex_ai_feature_online_store_featureview resource.
/// </summary>
public partial class GoogleVertexAiFeatureOnlineStoreFeatureview(string name) : TerraformResource("google_vertex_ai_feature_online_store_featureview", name)
{
    /// <summary>
    /// The name of the FeatureOnlineStore to use for the featureview.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureOnlineStore is required")]
    public required TerraformValue<string> FeatureOnlineStore
    {
        get => new TerraformReference<string>(this, "feature_online_store");
        set => SetArgument("feature_online_store", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of key/value label pairs to assign to this FeatureView.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Name of the FeatureView. This value may be up to 60 characters, and valid characters are [a-z0-9_]. The first character cannot be a number.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region for the resource. It should be the same as the featureonlinestore region.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The timestamp of when the featureOnlinestore was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timestamp of when the featureOnlinestore was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// BigQuerySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQuerySource block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock>? BigQuerySource
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewBigQuerySourceBlock>>("big_query_source");
        set => SetArgument("big_query_source", value);
    }

    /// <summary>
    /// FeatureRegistrySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureRegistrySource block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock>? FeatureRegistrySource
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewFeatureRegistrySourceBlock>>("feature_registry_source");
        set => SetArgument("feature_registry_source", value);
    }

    /// <summary>
    /// SyncConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SyncConfig block(s) allowed")]
    public TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock>? SyncConfig
    {
        get => GetArgument<TerraformList<GoogleVertexAiFeatureOnlineStoreFeatureviewSyncConfigBlock>>("sync_config");
        set => SetArgument("sync_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVertexAiFeatureOnlineStoreFeatureviewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
