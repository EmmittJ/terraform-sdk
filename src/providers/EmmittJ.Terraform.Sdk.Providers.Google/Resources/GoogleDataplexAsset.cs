using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for discovery_spec in GoogleDataplexAsset.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexAssetDiscoverySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "discovery_spec";

    /// <summary>
    /// Required. Whether discovery is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? ExcludePatterns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exclude_patterns").ResolveNodes(ctx));
        set => SetArgument("exclude_patterns", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? IncludePatterns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "include_patterns").ResolveNodes(ctx));
        set => SetArgument("include_patterns", value);
    }

    /// <summary>
    /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or TZ=${IANA_TIME_ZONE}&amp;quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &amp;quot;CRON_TZ=America/New_York 1 * * * *&amp;quot;, or &amp;quot;TZ=America/New_York 1 * * * *&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// CsvOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public TerraformList<GoogleDataplexAssetDiscoverySpecBlockCsvOptionsBlock>? CsvOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexAssetDiscoverySpecBlockCsvOptionsBlock>>("csv_options");
        set => SetArgument("csv_options", value);
    }

    /// <summary>
    /// JsonOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonOptions block(s) allowed")]
    public TerraformList<GoogleDataplexAssetDiscoverySpecBlockJsonOptionsBlock>? JsonOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexAssetDiscoverySpecBlockJsonOptionsBlock>>("json_options");
        set => SetArgument("json_options", value);
    }

}

/// <summary>
/// Block type for csv_options in GoogleDataplexAssetDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexAssetDiscoverySpecBlockCsvOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_options";

    /// <summary>
    /// Optional. The delimiter being used to separate values. This defaults to &#39;,&#39;.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => new TerraformReference<string>(this, "delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// Optional. Whether to disable the inference of data type for CSV data. If true, all columns will be registered as strings.
    /// </summary>
    public TerraformValue<bool>? DisableTypeInference
    {
        get => new TerraformReference<bool>(this, "disable_type_inference");
        set => SetArgument("disable_type_inference", value);
    }

    /// <summary>
    /// Optional. The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.
    /// </summary>
    public TerraformValue<double>? HeaderRows
    {
        get => new TerraformReference<double>(this, "header_rows");
        set => SetArgument("header_rows", value);
    }

}

/// <summary>
/// Block type for json_options in GoogleDataplexAssetDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexAssetDiscoverySpecBlockJsonOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_options";

    /// <summary>
    /// Optional. Whether to disable the inference of data type for Json data. If true, all columns will be registered as their primitive types (strings, number or boolean).
    /// </summary>
    public TerraformValue<bool>? DisableTypeInference
    {
        get => new TerraformReference<bool>(this, "disable_type_inference");
        set => SetArgument("disable_type_inference", value);
    }

    /// <summary>
    /// Optional. The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

}


/// <summary>
/// Block type for resource_spec in GoogleDataplexAsset.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexAssetResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_spec";

    /// <summary>
    /// Immutable. Relative name of the cloud resource that contains the data that is being managed within a lake. For example: `projects/{project_number}/buckets/{bucket_id}` `projects/{project_number}/datasets/{dataset_id}`
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional. Determines how read permissions are handled for each asset and their associated tables. Only available to storage buckets assets. Possible values: DIRECT, MANAGED
    /// </summary>
    public TerraformValue<string> ReadAccessMode
    {
        get => new TerraformReference<string>(this, "read_access_mode");
        set => SetArgument("read_access_mode", value);
    }

    /// <summary>
    /// Required. Immutable. Type of resource. Possible values: STORAGE_BUCKET, BIGQUERY_DATASET
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexAsset.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexAssetTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataplex_asset Terraform resource.
/// Manages a google_dataplex_asset resource.
/// </summary>
public partial class GoogleDataplexAsset(string name) : TerraformResource("google_dataplex_asset", name)
{
    /// <summary>
    /// The zone for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataplexZone is required")]
    public required TerraformValue<string> DataplexZone
    {
        get => new TerraformReference<string>(this, "dataplex_zone");
        set => SetArgument("dataplex_zone", value);
    }

    /// <summary>
    /// Optional. Description of the asset.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. User friendly display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Optional. User defined labels for the asset.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The lake for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lake is required")]
    public required TerraformValue<string> Lake
    {
        get => new TerraformReference<string>(this, "lake");
        set => SetArgument("lake", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the asset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The time when the asset was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Status of the discovery feature applied to data referenced by this asset.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiscoveryStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "discovery_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Status of the resource referenced by this asset.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Status of the security policy applied to resource referenced by this asset.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecurityStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "security_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. System generated globally unique ID for the asset. This ID will be different if the asset is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. The time when the asset was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// DiscoverySpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoverySpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiscoverySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiscoverySpec block(s) allowed")]
    public required TerraformList<GoogleDataplexAssetDiscoverySpecBlock> DiscoverySpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexAssetDiscoverySpecBlock>>("discovery_spec");
        set => SetArgument("discovery_spec", value);
    }

    /// <summary>
    /// ResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    public required TerraformList<GoogleDataplexAssetResourceSpecBlock> ResourceSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexAssetResourceSpecBlock>>("resource_spec");
        set => SetArgument("resource_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexAssetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexAssetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
