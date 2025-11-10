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
        this.DeclareOutput("create_time");
        this.DeclareOutput("dataset_config_state");
        this.DeclareOutput("description");
        this.DeclareOutput("exclude_cloud_storage_buckets");
        this.DeclareOutput("exclude_cloud_storage_locations");
        this.DeclareOutput("identity");
        this.DeclareOutput("include_cloud_storage_buckets");
        this.DeclareOutput("include_cloud_storage_locations");
        this.DeclareOutput("include_newly_created_buckets");
        this.DeclareOutput("link");
        this.DeclareOutput("link_dataset");
        this.DeclareOutput("name");
        this.DeclareOutput("organization_number");
        this.DeclareOutput("organization_scope");
        this.DeclareOutput("retention_period_days");
        this.DeclareOutput("source_folders");
        this.DeclareOutput("source_projects");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The user-defined ID of the DatasetConfig
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetConfigId is required")]
    public required TerraformProperty<string> DatasetConfigId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dataset_config_id");
        set => this.WithProperty("dataset_config_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
