using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for discovery_spec in GoogleDataplexZone.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneDiscoverySpecBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? ExcludePatterns
    {
        get => GetArgument<TerraformList<string>>("exclude_patterns");
        set => SetArgument("exclude_patterns", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public TerraformList<string>? IncludePatterns
    {
        get => GetArgument<TerraformList<string>>("include_patterns");
        set => SetArgument("include_patterns", value);
    }

    /// <summary>
    /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or TZ=${IANA_TIME_ZONE}&amp;quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &amp;quot;CRON_TZ=America/New_York 1 * * * *&amp;quot;, or &amp;quot;TZ=America/New_York 1 * * * *&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// CsvOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public TerraformList<GoogleDataplexZoneDiscoverySpecBlockCsvOptionsBlock>? CsvOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexZoneDiscoverySpecBlockCsvOptionsBlock>>("csv_options");
        set => SetArgument("csv_options", value);
    }

    /// <summary>
    /// JsonOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonOptions block(s) allowed")]
    public TerraformList<GoogleDataplexZoneDiscoverySpecBlockJsonOptionsBlock>? JsonOptions
    {
        get => GetArgument<TerraformList<GoogleDataplexZoneDiscoverySpecBlockJsonOptionsBlock>>("json_options");
        set => SetArgument("json_options", value);
    }

}

/// <summary>
/// Block type for csv_options in GoogleDataplexZoneDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneDiscoverySpecBlockCsvOptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// Optional. Whether to disable the inference of data type for CSV data. If true, all columns will be registered as strings.
    /// </summary>
    public TerraformValue<bool>? DisableTypeInference
    {
        get => GetArgument<TerraformValue<bool>>("disable_type_inference");
        set => SetArgument("disable_type_inference", value);
    }

    /// <summary>
    /// Optional. The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// Optional. The number of rows to interpret as header rows that should be skipped when reading data rows.
    /// </summary>
    public TerraformValue<double>? HeaderRows
    {
        get => GetArgument<TerraformValue<double>>("header_rows");
        set => SetArgument("header_rows", value);
    }

}

/// <summary>
/// Block type for json_options in GoogleDataplexZoneDiscoverySpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneDiscoverySpecBlockJsonOptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("disable_type_inference");
        set => SetArgument("disable_type_inference", value);
    }

    /// <summary>
    /// Optional. The character encoding of the data. The default is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

}


/// <summary>
/// Block type for resource_spec in GoogleDataplexZone.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_spec";

    /// <summary>
    /// Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone. Possible values: LOCATION_TYPE_UNSPECIFIED, SINGLE_REGION, MULTI_REGION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationType is required")]
    public required TerraformValue<string> LocationType
    {
        get => GetArgument<TerraformValue<string>>("location_type");
        set => SetArgument("location_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexZone.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexZoneTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataplex_zone Terraform resource.
/// Manages a google_dataplex_zone resource.
/// </summary>
public partial class GoogleDataplexZone(string name) : TerraformResource("google_dataplex_zone", name)
{
    /// <summary>
    /// Optional. Description of the zone.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. User friendly display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. User defined labels for the zone.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The lake for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lake is required")]
    public required TerraformValue<string> Lake
    {
        get => GetArgument<TerraformValue<string>>("lake");
        set => SetArgument("lake", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Required. Immutable. The type of the zone. Possible values: TYPE_UNSPECIFIED, RAW, CURATED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Output only. Aggregated status of the underlying assets of the zone.
    /// </summary>
    public TerraformList<TerraformMap<object>> AssetStatus
        => AsReference("asset_status");

    /// <summary>
    /// Output only. The time when the zone was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Output only. Current state of the zone. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. System generated globally unique ID for the zone. This ID will be different if the zone is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The time when the zone was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// DiscoverySpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoverySpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiscoverySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiscoverySpec block(s) allowed")]
    public required TerraformList<GoogleDataplexZoneDiscoverySpecBlock> DiscoverySpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexZoneDiscoverySpecBlock>>("discovery_spec");
        set => SetArgument("discovery_spec", value);
    }

    /// <summary>
    /// ResourceSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    public required TerraformList<GoogleDataplexZoneResourceSpecBlock> ResourceSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexZoneResourceSpecBlock>>("resource_spec");
        set => SetArgument("resource_spec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
