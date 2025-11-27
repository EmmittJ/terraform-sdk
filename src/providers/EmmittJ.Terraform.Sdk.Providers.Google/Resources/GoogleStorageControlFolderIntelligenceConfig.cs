using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in GoogleStorageControlFolderIntelligenceConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// ExcludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>? ExcludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock>>("excluded_cloud_storage_buckets");
        set => SetArgument("excluded_cloud_storage_buckets", value);
    }

    /// <summary>
    /// ExcludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>? ExcludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock>>("excluded_cloud_storage_locations");
        set => SetArgument("excluded_cloud_storage_locations", value);
    }

    /// <summary>
    /// IncludedCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>? IncludedCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock>>("included_cloud_storage_buckets");
        set => SetArgument("included_cloud_storage_buckets", value);
    }

    /// <summary>
    /// IncludedCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludedCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>? IncludedCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock>>("included_cloud_storage_locations");
        set => SetArgument("included_cloud_storage_locations", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_buckets in GoogleStorageControlFolderIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageBucketsBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "bucket_id_regexes").ResolveNodes(ctx));
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for excluded_cloud_storage_locations in GoogleStorageControlFolderIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlockExcludedCloudStorageLocationsBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "locations").ResolveNodes(ctx));
        set => SetArgument("locations", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_buckets in GoogleStorageControlFolderIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageBucketsBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "bucket_id_regexes").ResolveNodes(ctx));
        set => SetArgument("bucket_id_regexes", value);
    }

}

/// <summary>
/// Block type for included_cloud_storage_locations in GoogleStorageControlFolderIntelligenceConfigFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlockIncludedCloudStorageLocationsBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "locations").ResolveNodes(ctx));
        set => SetArgument("locations", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageControlFolderIntelligenceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_control_folder_intelligence_config Terraform resource.
/// Manages a google_storage_control_folder_intelligence_config resource.
/// </summary>
public partial class GoogleStorageControlFolderIntelligenceConfig(string name) : TerraformResource("google_storage_control_folder_intelligence_config", name)
{
    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    public TerraformValue<string> EditionConfig
    {
        get => new TerraformReference<string>(this, "edition_config");
        set => SetArgument("edition_config", value);
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
    /// Identifier of the GCP Folder. For GCP Folder, this field can be folder number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveIntelligenceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "effective_intelligence_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trial_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleStorageControlFolderIntelligenceConfigFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
