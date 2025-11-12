using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for exclude_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock() : TerraformBlock("exclude_cloud_storage_buckets")
{
}

/// <summary>
/// Block type for exclude_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock() : TerraformBlock("exclude_cloud_storage_locations")
{
    /// <summary>
    /// The list of cloud storage locations to exclude in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformProperty("locations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Locations { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigIdentityBlock() : TerraformBlock("identity")
{

    /// <summary>
    /// Type of identity to use for the DatasetConfig. Possible values: [&amp;quot;IDENTITY_TYPE_PER_CONFIG&amp;quot;, &amp;quot;IDENTITY_TYPE_PER_PROJECT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for include_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock() : TerraformBlock("include_cloud_storage_buckets")
{
}

/// <summary>
/// Block type for include_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock() : TerraformBlock("include_cloud_storage_locations")
{
    /// <summary>
    /// The list of cloud storage locations to include in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformProperty("locations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Locations { get; set; }

}

/// <summary>
/// Block type for source_folders in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigSourceFoldersBlock() : TerraformBlock("source_folders")
{
    /// <summary>
    /// The list of folder numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformProperty("folder_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FolderNumbers { get; set; }

}

/// <summary>
/// Block type for source_projects in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigSourceProjectsBlock() : TerraformBlock("source_projects")
{
    /// <summary>
    /// The list of project numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformProperty("project_numbers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ProjectNumbers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_storage_insights_dataset_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageInsightsDatasetConfig : TerraformResource
{
    public GoogleStorageInsightsDatasetConfig(string name) : base("google_storage_insights_dataset_config", name)
    {
    }

    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    [TerraformProperty("dataset_config_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatasetConfigId { get; set; }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    [TerraformProperty("include_newly_created_buckets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeNewlyCreatedBuckets { get; set; }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    [TerraformProperty("link_dataset")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LinkDataset { get; set; }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    [TerraformProperty("organization_number")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationNumber { get; set; }

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    [TerraformProperty("organization_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OrganizationScope { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodDays is required")]
    [TerraformProperty("retention_period_days")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RetentionPeriodDays { get; set; }

    /// <summary>
    /// Block for exclude_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageBuckets block(s) allowed")]
    [TerraformProperty("exclude_cloud_storage_buckets")]
    public TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock> ExcludeCloudStorageBuckets { get; set; } = new();

    /// <summary>
    /// Block for exclude_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageLocations block(s) allowed")]
    [TerraformProperty("exclude_cloud_storage_locations")]
    public TerraformList<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock> ExcludeCloudStorageLocations { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public required TerraformList<GoogleStorageInsightsDatasetConfigIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for include_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageBuckets block(s) allowed")]
    [TerraformProperty("include_cloud_storage_buckets")]
    public TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock> IncludeCloudStorageBuckets { get; set; } = new();

    /// <summary>
    /// Block for include_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageLocations block(s) allowed")]
    [TerraformProperty("include_cloud_storage_locations")]
    public TerraformList<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock> IncludeCloudStorageLocations { get; set; } = new();

    /// <summary>
    /// Block for source_folders.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFolders block(s) allowed")]
    [TerraformProperty("source_folders")]
    public TerraformList<GoogleStorageInsightsDatasetConfigSourceFoldersBlock> SourceFolders { get; set; } = new();

    /// <summary>
    /// Block for source_projects.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceProjects block(s) allowed")]
    [TerraformProperty("source_projects")]
    public TerraformList<GoogleStorageInsightsDatasetConfigSourceProjectsBlock> SourceProjects { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleStorageInsightsDatasetConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    [TerraformProperty("dataset_config_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatasetConfigState { get; }

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    [TerraformProperty("link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Link { get; }

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
