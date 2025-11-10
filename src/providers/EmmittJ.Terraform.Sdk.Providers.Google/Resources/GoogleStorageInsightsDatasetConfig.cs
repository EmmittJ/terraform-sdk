using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for exclude_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for exclude_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock : ITerraformBlock
{
    /// <summary>
    /// The list of cloud storage locations to exclude in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformPropertyName("locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Locations { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the identity.
    /// </summary>
    [TerraformPropertyName("name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// Type of identity to use for the DatasetConfig. Possible values: [&amp;quot;IDENTITY_TYPE_PER_CONFIG&amp;quot;, &amp;quot;IDENTITY_TYPE_PER_PROJECT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for include_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for include_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock : ITerraformBlock
{
    /// <summary>
    /// The list of cloud storage locations to include in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    [TerraformPropertyName("locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Locations { get; set; }

}

/// <summary>
/// Block type for source_folders in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceFoldersBlock : ITerraformBlock
{
    /// <summary>
    /// The list of folder numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("folder_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FolderNumbers { get; set; }

}

/// <summary>
/// Block type for source_projects in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceProjectsBlock : ITerraformBlock
{
    /// <summary>
    /// The list of project numbers to include in the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("project_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ProjectNumbers { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsDatasetConfigTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> DatasetConfigId { get; set; }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    [TerraformPropertyName("include_newly_created_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeNewlyCreatedBuckets { get; set; }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    [TerraformPropertyName("link_dataset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LinkDataset { get; set; }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    [TerraformPropertyName("organization_number")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationNumber { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organization_number");

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("organization_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OrganizationScope { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodDays is required")]
    [TerraformPropertyName("retention_period_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RetentionPeriodDays { get; set; }

    /// <summary>
    /// Block for exclude_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageBuckets block(s) allowed")]
    [TerraformPropertyName("exclude_cloud_storage_buckets")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>>? ExcludeCloudStorageBuckets { get; set; } = new();

    /// <summary>
    /// Block for exclude_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageLocations block(s) allowed")]
    [TerraformPropertyName("exclude_cloud_storage_locations")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>>? ExcludeCloudStorageLocations { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for include_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageBuckets block(s) allowed")]
    [TerraformPropertyName("include_cloud_storage_buckets")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>>? IncludeCloudStorageBuckets { get; set; } = new();

    /// <summary>
    /// Block for include_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageLocations block(s) allowed")]
    [TerraformPropertyName("include_cloud_storage_locations")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>>? IncludeCloudStorageLocations { get; set; } = new();

    /// <summary>
    /// Block for source_folders.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFolders block(s) allowed")]
    [TerraformPropertyName("source_folders")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>>? SourceFolders { get; set; } = new();

    /// <summary>
    /// Block for source_projects.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceProjects block(s) allowed")]
    [TerraformPropertyName("source_projects")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>>? SourceProjects { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageInsightsDatasetConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("dataset_config_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatasetConfigState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dataset_config_state");

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    [TerraformPropertyName("link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Link => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "link");

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
