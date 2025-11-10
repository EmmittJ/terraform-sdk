using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for exclude_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for exclude_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// The list of cloud storage locations to exclude in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public List<TerraformProperty<string>>? Locations
    {
        get => GetProperty<List<TerraformProperty<string>>>("locations");
        set => WithProperty("locations", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Name of the identity.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Type of identity to use for the DatasetConfig. Possible values: [&amp;quot;IDENTITY_TYPE_PER_CONFIG&amp;quot;, &amp;quot;IDENTITY_TYPE_PER_PROJECT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for include_cloud_storage_buckets in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for include_cloud_storage_locations in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock : TerraformBlock
{
    /// <summary>
    /// The list of cloud storage locations to include in the DatasetConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Locations is required")]
    public List<TerraformProperty<string>>? Locations
    {
        get => GetProperty<List<TerraformProperty<string>>>("locations");
        set => WithProperty("locations", value);
    }

}

/// <summary>
/// Block type for source_folders in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceFoldersBlock : TerraformBlock
{
    /// <summary>
    /// The list of folder numbers to include in the DatasetConfig.
    /// </summary>
    public List<TerraformProperty<string>>? FolderNumbers
    {
        get => GetProperty<List<TerraformProperty<string>>>("folder_numbers");
        set => WithProperty("folder_numbers", value);
    }

}

/// <summary>
/// Block type for source_projects in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsDatasetConfigSourceProjectsBlock : TerraformBlock
{
    /// <summary>
    /// The list of project numbers to include in the DatasetConfig.
    /// </summary>
    public List<TerraformProperty<string>>? ProjectNumbers
    {
        get => GetProperty<List<TerraformProperty<string>>>("project_numbers");
        set => WithProperty("project_numbers", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsDatasetConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_storage_insights_dataset_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageInsightsDatasetConfig : TerraformResource
{
    public GoogleStorageInsightsDatasetConfig(string name) : base("google_storage_insights_dataset_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("dataset_config_state");
        this.DeclareOutput("link");
        this.DeclareOutput("name");
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
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    public TerraformProperty<bool>? IncludeNewlyCreatedBuckets
    {
        get => GetProperty<TerraformProperty<bool>>("include_newly_created_buckets");
        set => this.WithProperty("include_newly_created_buckets", value);
    }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    public TerraformProperty<bool>? LinkDataset
    {
        get => GetProperty<TerraformProperty<bool>>("link_dataset");
        set => this.WithProperty("link_dataset", value);
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
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    public TerraformProperty<string>? OrganizationNumber
    {
        get => GetProperty<TerraformProperty<string>>("organization_number");
        set => this.WithProperty("organization_number", value);
    }

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    public TerraformProperty<bool>? OrganizationScope
    {
        get => GetProperty<TerraformProperty<bool>>("organization_scope");
        set => this.WithProperty("organization_scope", value);
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
    /// Number of days of history that must be retained.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodDays is required")]
    public required TerraformProperty<double> RetentionPeriodDays
    {
        get => GetRequiredProperty<TerraformProperty<double>>("retention_period_days");
        set => this.WithProperty("retention_period_days", value);
    }

    /// <summary>
    /// Block for exclude_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageBuckets block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>? ExcludeCloudStorageBuckets
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigExcludeCloudStorageBucketsBlock>>("exclude_cloud_storage_buckets");
        set => this.WithProperty("exclude_cloud_storage_buckets", value);
    }

    /// <summary>
    /// Block for exclude_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeCloudStorageLocations block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>? ExcludeCloudStorageLocations
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigExcludeCloudStorageLocationsBlock>>("exclude_cloud_storage_locations");
        set => this.WithProperty("exclude_cloud_storage_locations", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigIdentityBlock>? Identity
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for include_cloud_storage_buckets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageBuckets block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>? IncludeCloudStorageBuckets
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigIncludeCloudStorageBucketsBlock>>("include_cloud_storage_buckets");
        set => this.WithProperty("include_cloud_storage_buckets", value);
    }

    /// <summary>
    /// Block for include_cloud_storage_locations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeCloudStorageLocations block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>? IncludeCloudStorageLocations
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigIncludeCloudStorageLocationsBlock>>("include_cloud_storage_locations");
        set => this.WithProperty("include_cloud_storage_locations", value);
    }

    /// <summary>
    /// Block for source_folders.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFolders block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>? SourceFolders
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigSourceFoldersBlock>>("source_folders");
        set => this.WithProperty("source_folders", value);
    }

    /// <summary>
    /// Block for source_projects.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceProjects block(s) allowed")]
    public List<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>? SourceProjects
    {
        get => GetProperty<List<GoogleStorageInsightsDatasetConfigSourceProjectsBlock>>("source_projects");
        set => this.WithProperty("source_projects", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageInsightsDatasetConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageInsightsDatasetConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// Details of the linked DatasetConfig.
    /// </summary>
    public TerraformExpression Link => this["link"];

    /// <summary>
    /// The full canonical resource name of the DatasetConfig (e.g., projects/P/locations/L/datasetConfigs/ID).
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// System generated unique identifier for the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The UTC time at which the DatasetConfig was updated. This is auto-populated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
