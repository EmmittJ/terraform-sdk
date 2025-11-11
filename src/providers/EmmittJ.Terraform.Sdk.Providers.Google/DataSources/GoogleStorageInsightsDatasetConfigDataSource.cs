using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_insights_dataset_config.
/// </summary>
public class GoogleStorageInsightsDatasetConfigDataSource : TerraformDataSource
{
    public GoogleStorageInsightsDatasetConfigDataSource(string name) : base("google_storage_insights_dataset_config", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

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
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Defined the options for excluding cloud storage buckets for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("exclude_cloud_storage_buckets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExcludeCloudStorageBuckets => new TerraformReference(this, "exclude_cloud_storage_buckets");

    /// <summary>
    /// Defines the options for excluding cloud storage locations for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("exclude_cloud_storage_locations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExcludeCloudStorageLocations => new TerraformReference(this, "exclude_cloud_storage_locations");

    /// <summary>
    /// Identity used by DatasetConfig.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// Defines the options for including cloud storage buckets for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("include_cloud_storage_buckets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IncludeCloudStorageBuckets => new TerraformReference(this, "include_cloud_storage_buckets");

    /// <summary>
    /// Defines the options for including cloud storage locations for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("include_cloud_storage_locations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IncludeCloudStorageLocations => new TerraformReference(this, "include_cloud_storage_locations");

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    [TerraformPropertyName("include_newly_created_buckets")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IncludeNewlyCreatedBuckets => new TerraformReference(this, "include_newly_created_buckets");

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    [TerraformPropertyName("link")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Link => new TerraformReference(this, "link");

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    [TerraformPropertyName("link_dataset")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LinkDataset => new TerraformReference(this, "link_dataset");

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    [TerraformPropertyName("organization_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrganizationNumber => new TerraformReference(this, "organization_number");

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("organization_scope")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OrganizationScope => new TerraformReference(this, "organization_scope");

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    [TerraformPropertyName("retention_period_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RetentionPeriodDays => new TerraformReference(this, "retention_period_days");

    /// <summary>
    /// Defines the options for providing source folders for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("source_folders")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceFolders => new TerraformReference(this, "source_folders");

    /// <summary>
    /// Defines the options for providing source projects for the DatasetConfig.
    /// </summary>
    [TerraformPropertyName("source_projects")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceProjects => new TerraformReference(this, "source_projects");

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
