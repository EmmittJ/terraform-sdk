using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_insights_dataset_config.
/// </summary>
public class GoogleStorageInsightsDatasetConfigDataSource : TerraformDataSource
{
    public GoogleStorageInsightsDatasetConfigDataSource(string name) : base("google_storage_insights_dataset_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("dataset_config_state");
        SetOutput("description");
        SetOutput("exclude_cloud_storage_buckets");
        SetOutput("exclude_cloud_storage_locations");
        SetOutput("identity");
        SetOutput("include_cloud_storage_buckets");
        SetOutput("include_cloud_storage_locations");
        SetOutput("include_newly_created_buckets");
        SetOutput("link");
        SetOutput("link_dataset");
        SetOutput("name");
        SetOutput("organization_number");
        SetOutput("organization_scope");
        SetOutput("retention_period_days");
        SetOutput("source_folders");
        SetOutput("source_projects");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("dataset_config_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    public required TerraformProperty<string> DatasetConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset_config_id");
        set => SetProperty("dataset_config_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The UTC time at which the DatasetConfig was created. This is auto-populated.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// State of the DatasetConfig.
    /// </summary>
    public TerraformExpression DatasetConfigState => this["dataset_config_state"];

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Defined the options for excluding cloud storage buckets for the DatasetConfig.
    /// </summary>
    public TerraformExpression ExcludeCloudStorageBuckets => this["exclude_cloud_storage_buckets"];

    /// <summary>
    /// Defines the options for excluding cloud storage locations for the DatasetConfig.
    /// </summary>
    public TerraformExpression ExcludeCloudStorageLocations => this["exclude_cloud_storage_locations"];

    /// <summary>
    /// Identity used by DatasetConfig.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// Defines the options for including cloud storage buckets for the DatasetConfig.
    /// </summary>
    public TerraformExpression IncludeCloudStorageBuckets => this["include_cloud_storage_buckets"];

    /// <summary>
    /// Defines the options for including cloud storage locations for the DatasetConfig.
    /// </summary>
    public TerraformExpression IncludeCloudStorageLocations => this["include_cloud_storage_locations"];

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    public TerraformExpression IncludeNewlyCreatedBuckets => this["include_newly_created_buckets"];

    /// <summary>
    /// Details of the linked DatasetConfig.
    /// </summary>
    public TerraformExpression Link => this["link"];

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    public TerraformExpression LinkDataset => this["link_dataset"];

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    public TerraformExpression OrganizationNumber => this["organization_number"];

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    public TerraformExpression OrganizationScope => this["organization_scope"];

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    public TerraformExpression RetentionPeriodDays => this["retention_period_days"];

    /// <summary>
    /// Defines the options for providing source folders for the DatasetConfig.
    /// </summary>
    public TerraformExpression SourceFolders => this["source_folders"];

    /// <summary>
    /// Defines the options for providing source projects for the DatasetConfig.
    /// </summary>
    public TerraformExpression SourceProjects => this["source_projects"];

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
