using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for exclude_cloud_storage_buckets in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_cloud_storage_buckets";

    /// <summary>
    /// CloudStorageBuckets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudStorageBuckets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CloudStorageBuckets block(s) required")]
    public required TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlockCloudStorageBucketsBlock> CloudStorageBuckets
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlockCloudStorageBucketsBlock>>("cloud_storage_buckets");
        set => SetArgument("cloud_storage_buckets", value);
    }

}

/// <summary>
/// Block type for cloud_storage_buckets in GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlockCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_buckets";

    /// <summary>
    /// The list of cloud storage bucket names to exclude in the DatasetConfig.
    /// Exactly one of the bucket_name and bucket_prefix_regex should be specified.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The list of regex patterns for bucket names matching the regex.
    /// Regex should follow the syntax specified in google/re2 on GitHub.
    /// Exactly one of the bucket_name and bucket_prefix_regex should be specified.
    /// </summary>
    public TerraformValue<string>? BucketPrefixRegex
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix_regex");
        set => SetArgument("bucket_prefix_regex", value);
    }

}


/// <summary>
/// Block type for exclude_cloud_storage_locations in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_cloud_storage_locations";

    /// <summary>
    /// The list of cloud storage locations to exclude in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}


/// <summary>
/// Block type for identity in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// Name of the identity.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Type of identity to use for the DatasetConfig. Possible values: [&amp;quot;IDENTITY_TYPE_PER_CONFIG&amp;quot;, &amp;quot;IDENTITY_TYPE_PER_PROJECT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for include_cloud_storage_buckets in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_cloud_storage_buckets";

    /// <summary>
    /// CloudStorageBuckets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudStorageBuckets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CloudStorageBuckets block(s) required")]
    public required TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlockCloudStorageBucketsBlock> CloudStorageBuckets
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlockCloudStorageBucketsBlock>>("cloud_storage_buckets");
        set => SetArgument("cloud_storage_buckets", value);
    }

}

/// <summary>
/// Block type for cloud_storage_buckets in GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlockCloudStorageBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_buckets";

    /// <summary>
    /// The list of cloud storage bucket names to include in the DatasetConfig.
    /// Exactly one of the bucket_name and bucket_prefix_regex should be specified.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The list of regex patterns for bucket names matching the regex.
    /// Regex should follow the syntax specified in google/re2 on GitHub.
    /// Exactly one of the bucket_name and bucket_prefix_regex should be specified.
    /// </summary>
    public TerraformValue<string>? BucketPrefixRegex
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix_regex");
        set => SetArgument("bucket_prefix_regex", value);
    }

}


/// <summary>
/// Block type for include_cloud_storage_locations in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_cloud_storage_locations";

    /// <summary>
    /// The list of cloud storage locations to include in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public TerraformList<string>? Locations
    {
        get => GetArgument<TerraformList<string>>("locations");
        set => SetArgument("locations", value);
    }

}


/// <summary>
/// Block type for source_folders in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceFoldersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_folders";

    /// <summary>
    /// The list of folder numbers to include in the DatasetConfig.
    /// </summary>
    public TerraformList<string>? FolderNumbers
    {
        get => GetArgument<TerraformList<string>>("folder_numbers");
        set => SetArgument("folder_numbers", value);
    }

}


/// <summary>
/// Block type for source_projects in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceProjectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_projects";

    /// <summary>
    /// The list of project numbers to include in the DatasetConfig.
    /// </summary>
    public TerraformList<string>? ProjectNumbers
    {
        get => GetArgument<TerraformList<string>>("project_numbers");
        set => SetArgument("project_numbers", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageInsightsDatasetConfig.
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsDatasetConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_insights_dataset_config Terraform resource.
/// Manages a google_storage_insights_dataset_config resource.
/// </summary>
public partial class GoogleStorageInsightsDatasetConfig(string name) : TerraformResource("google_storage_insights_dataset_config", name)
{
    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    public required TerraformValue<string> DatasetConfigId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_config_id");
        set => SetArgument("dataset_config_id", value);
    }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    public TerraformValue<bool>? IncludeNewlyCreatedBuckets
    {
        get => GetArgument<TerraformValue<bool>>("include_newly_created_buckets");
        set => SetArgument("include_newly_created_buckets", value);
    }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    public TerraformValue<bool>? LinkDataset
    {
        get => GetArgument<TerraformValue<bool>>("link_dataset");
        set => SetArgument("link_dataset", value);
    }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    public TerraformValue<string> OrganizationNumber
    {
        get => GetArgument<TerraformValue<string>>("organization_number") ?? AsReference("organization_number");
        set => SetArgument("organization_number", value);
    }

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    public TerraformValue<bool>? OrganizationScope
    {
        get => GetArgument<TerraformValue<bool>>("organization_scope");
        set => SetArgument("organization_scope", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodDays is required")]
    public required TerraformValue<double> RetentionPeriodDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_period_days");
        set => SetArgument("retention_period_days", value);
    }

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    public TerraformValue<string> DatasetConfigState
        => AsReference("dataset_config_state");

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> Link
        => AsReference("link");

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ExcludeCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>? ExcludeCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>>("exclude_cloud_storage_buckets");
        set => SetArgument("exclude_cloud_storage_buckets", value);
    }

    /// <summary>
    /// ExcludeCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>? ExcludeCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>>("exclude_cloud_storage_locations");
        set => SetArgument("exclude_cloud_storage_locations", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public required TerraformList<GoogleStorageInsightsDatasetConfigIdentityBlock> Identity
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsDatasetConfigIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// IncludeCloudStorageBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageBuckets block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>? IncludeCloudStorageBuckets
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>>("include_cloud_storage_buckets");
        set => SetArgument("include_cloud_storage_buckets", value);
    }

    /// <summary>
    /// IncludeCloudStorageLocations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageLocations block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>? IncludeCloudStorageLocations
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>>("include_cloud_storage_locations");
        set => SetArgument("include_cloud_storage_locations", value);
    }

    /// <summary>
    /// SourceFolders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFolders block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>? SourceFolders
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>>("source_folders");
        set => SetArgument("source_folders", value);
    }

    /// <summary>
    /// SourceProjects block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceProjects block(s) allowed")]
    public TerraformList<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>? SourceProjects
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>>("source_projects");
        set => SetArgument("source_projects", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageInsightsDatasetConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageInsightsDatasetConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
