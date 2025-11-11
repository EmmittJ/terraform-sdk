using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_insights_dataset_config.
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigDataSource : TerraformDataSource
{
    public GoogleStorageInsightsDatasetConfigDataSource(string name) : base("google_storage_insights_dataset_config", name)
    {
    }

    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    [TerraformProperty("dataset_config_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetConfigId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    [TerraformProperty("dataset_config_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatasetConfigState { get; }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Defined the options for excluding cloud storage buckets for the DatasetConfig.
    /// </summary>
    [TerraformProperty("exclude_cloud_storage_buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ExcludeCloudStorageBuckets { get; }

    /// <summary>
    /// Defines the options for excluding cloud storage locations for the DatasetConfig.
    /// </summary>
    [TerraformProperty("exclude_cloud_storage_locations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ExcludeCloudStorageLocations { get; }

    /// <summary>
    /// Identity used by DatasetConfig.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// Defines the options for including cloud storage buckets for the DatasetConfig.
    /// </summary>
    [TerraformProperty("include_cloud_storage_buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IncludeCloudStorageBuckets { get; }

    /// <summary>
    /// Defines the options for including cloud storage locations for the DatasetConfig.
    /// </summary>
    [TerraformProperty("include_cloud_storage_locations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IncludeCloudStorageLocations { get; }

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    [TerraformProperty("include_newly_created_buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IncludeNewlyCreatedBuckets { get; }

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    [TerraformProperty("link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Link { get; }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    [TerraformProperty("link_dataset")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LinkDataset { get; }

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    [TerraformProperty("organization_number")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrganizationNumber { get; }

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    [TerraformProperty("organization_scope")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OrganizationScope { get; }

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [TerraformProperty("retention_period_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetentionPeriodDays { get; }

    /// <summary>
    /// Defines the options for providing source folders for the DatasetConfig.
    /// </summary>
    [TerraformProperty("source_folders")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SourceFolders { get; }

    /// <summary>
    /// Defines the options for providing source projects for the DatasetConfig.
    /// </summary>
    [TerraformProperty("source_projects")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SourceProjects { get; }

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
