using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in GoogleStorageControlProjectIntelligenceConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// ExcludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>? ExcludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>>("excluded_cloud_storage_buckets");
        set => SetArgument("excluded_cloud_storage_buckets", value);
    }

    /// <summary>
    /// ExcludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>? ExcludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>>("excluded_cloud_storage_locations");
        set => SetArgument("excluded_cloud_storage_locations", value);
    }

    /// <summary>
    /// IncludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>? IncludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>>("included_cloud_storage_buckets");
        set => SetArgument("included_cloud_storage_buckets", value);
    }

    /// <summary>
    /// IncludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>? IncludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>>("included_cloud_storage_locations");
        set => SetArgument("included_cloud_storage_locations", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_buckets in GoogleStorageControlProjectIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_cloud_storage_buckets";

    /// <summary>
    /// List of bucket id regexes to exclude in the storage intelligence plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketIdRegexes is required")]
    public TerraformList<string>? BucketIdRegexes
    {
        get => GetArgument<TerraformList<string>>("bucket_id_regexes");
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_locations in GoogleStorageControlProjectIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_cloud_storage_locations";

    /// <summary>
    /// List of locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_buckets in GoogleStorageControlProjectIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_cloud_storage_buckets";

    /// <summary>
    /// List of bucket id regexes to exclude in the storage intelligence plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketIdRegexes is required")]
    public TerraformList<string>? BucketIdRegexes
    {
        get => GetArgument<TerraformList<string>>("bucket_id_regexes");
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_locations in GoogleStorageControlProjectIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "included_cloud_storage_locations";

    /// <summary>
    /// List of locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageControlProjectIntelligenceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_control_project_intelligence_config Terraform resource.
/// Manages a google_storage_control_project_intelligence_config resource.
/// </summary>
public partial class GoogleStorageControlProjectIntelligenceConfig(string name) : TerraformResource("google_storage_control_project_intelligence_config", name)
{
    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    public TerraformValue<string> EditionConfig
    {
        get => GetArgument<TerraformValue<string>>("edition_config") ?? CreateReference("edition_config");
        set => SetArgument("edition_config", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Identifier of the GCP project. For GCP project, this field can be project name or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveIntelligenceConfig
        => CreateReference("effective_intelligence_config");

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialConfig
        => CreateReference("trial_config");

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleStorageControlProjectIntelligenceConfigFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageControlProjectIntelligenceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageControlProjectIntelligenceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
