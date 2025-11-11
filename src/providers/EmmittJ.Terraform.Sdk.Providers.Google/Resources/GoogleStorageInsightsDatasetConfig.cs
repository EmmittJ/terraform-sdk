using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for exclude_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock
{
}

/// <summary>
/// Block type for exclude_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock
{
    /// <summary>
    /// The list of cloud storage locations to exclude in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformPropertyName("locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Locations { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIdentityBlock
{

    /// <summary>
    /// Type of identity to use for the DatasetConfig. Possible values: [&amp;quot;IDENTITY_TYPE_PER_CONFIG&amp;quot;, &amp;quot;IDENTITY_TYPE_PER_PROJECT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for include_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock
{
}

/// <summary>
/// Block type for include_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock
{
    /// <summary>
    /// The list of cloud storage locations to include in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformPropertyName("locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Locations { get; set; }

}

/// <summary>
/// Block type for source_folders in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceFoldersBlock
{
    /// <summary>
    /// The list of folder numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("folder_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? FolderNumbers { get; set; }

}

/// <summary>
/// Block type for source_projects in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceProjectsBlock
{
    /// <summary>
    /// The list of project numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("project_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ProjectNumbers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsDatasetConfigTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_insights_dataset_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageInsightsDatasetConfig : TerraformResource
{
    public GoogleStorageInsightsDatasetConfig(string name) : base("google_storage_insights_dataset_config", name)
    {
    }

    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    [TerraformPropertyName("dataset_config_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatasetConfigId { get; set; }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    [TerraformPropertyName("include_newly_created_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeNewlyCreatedBuckets { get; set; }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    [TerraformPropertyName("link_dataset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LinkDataset { get; set; }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    [TerraformPropertyName("organization_number")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OrganizationNumber { get; set; } = default!;

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("organization_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OrganizationScope { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodDays is required")]
    [TerraformPropertyName("retention_period_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RetentionPeriodDays { get; set; }

    /// <summary>
    /// Block for exclude_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageBuckets block(s) allowed")]
    [TerraformPropertyName("exclude_cloud_storage_buckets")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>>? ExcludeCloudStorageBuckets { get; set; }

    /// <summary>
    /// Block for exclude_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageLocations block(s) allowed")]
    [TerraformPropertyName("exclude_cloud_storage_locations")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>>? ExcludeCloudStorageLocations { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for include_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageBuckets block(s) allowed")]
    [TerraformPropertyName("include_cloud_storage_buckets")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>>? IncludeCloudStorageBuckets { get; set; }

    /// <summary>
    /// Block for include_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageLocations block(s) allowed")]
    [TerraformPropertyName("include_cloud_storage_locations")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>>? IncludeCloudStorageLocations { get; set; }

    /// <summary>
    /// Block for source_folders.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFolders block(s) allowed")]
    [TerraformPropertyName("source_folders")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>>? SourceFolders { get; set; }

    /// <summary>
    /// Block for source_projects.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceProjects block(s) allowed")]
    [TerraformPropertyName("source_projects")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>>? SourceProjects { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageInsightsDatasetConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("dataset_config_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatasetConfigState => new TerraformReference(this, "dataset_config_state");

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    [TerraformPropertyName("link")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Link => new TerraformReference(this, "link");

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
