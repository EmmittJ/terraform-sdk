using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_insights_dataset_config resource.
/// </summary>
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
    public TerraformProperty<string>? DatasetConfigId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_config_id");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
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
    public TerraformProperty<double>? RetentionPeriodDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_period_days");
        set => this.WithProperty("retention_period_days", value);
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
