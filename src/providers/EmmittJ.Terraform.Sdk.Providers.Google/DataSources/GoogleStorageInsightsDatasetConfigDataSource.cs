using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_insights_dataset_config Terraform data source.
/// Retrieves information about a google_storage_insights_dataset_config.
/// </summary>
public partial class GoogleStorageInsightsDatasetConfigDataSource(string name) : TerraformDataSource("google_storage_insights_dataset_config", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    public TerraformValue<string> DatasetConfigState
        => CreateReference("dataset_config_state");

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// Defined the options for excluding cloud storage buckets for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExcludeCloudStorageBuckets
        => CreateReference("exclude_cloud_storage_buckets");

    /// <summary>
    /// Defines the options for excluding cloud storage locations for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExcludeCloudStorageLocations
        => CreateReference("exclude_cloud_storage_locations");

    /// <summary>
    /// Identity used by DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// Defines the options for including cloud storage buckets for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> IncludeCloudStorageBuckets
        => CreateReference("include_cloud_storage_buckets");

    /// <summary>
    /// Defines the options for including cloud storage locations for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> IncludeCloudStorageLocations
        => CreateReference("include_cloud_storage_locations");

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    public TerraformValue<bool> IncludeNewlyCreatedBuckets
        => CreateReference("include_newly_created_buckets");

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> Link
        => CreateReference("link");

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    public TerraformValue<bool> LinkDataset
        => CreateReference("link_dataset");

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    public TerraformValue<string> OrganizationNumber
        => CreateReference("organization_number");

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    public TerraformValue<bool> OrganizationScope
        => CreateReference("organization_scope");

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    public TerraformValue<double> RetentionPeriodDays
        => CreateReference("retention_period_days");

    /// <summary>
    /// Defines the options for providing source folders for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceFolders
        => CreateReference("source_folders");

    /// <summary>
    /// Defines the options for providing source projects for the DatasetConfig.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceProjects
        => CreateReference("source_projects");

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

}
