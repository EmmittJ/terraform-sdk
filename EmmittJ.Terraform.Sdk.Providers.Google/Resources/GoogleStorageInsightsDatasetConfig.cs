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
    public string? DatasetConfigId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset_config_id")?.Value;
        set => this.WithProperty("dataset_config_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional user-provided description for the dataset configuration with a maximum length of 256 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set to true, the request includes all the newly created buckets in the dataset that meet the inclusion and exclusion rules.
    /// </summary>
    public bool? IncludeNewlyCreatedBuckets
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_newly_created_buckets")?.Value;
        set => this.WithProperty("include_newly_created_buckets", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A boolean terraform only flag to link/unlink dataset.
    /// 
    /// Setting this field to true while creation will automatically link the created dataset as an additional functionality.
    /// -&amp;gt; **Note** A dataset config resource can only be destroyed once it is unlinked,
    /// so users must set this field to false to unlink the dataset and destroy the dataset config resource.
    /// </summary>
    public bool? LinkDataset
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("link_dataset")?.Value;
        set => this.WithProperty("link_dataset", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location of the DatasetConfig.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Organization resource ID that the source projects should belong to.
    /// Projects that do not belong to the provided organization are not considered when creating the dataset.
    /// </summary>
    public string? OrganizationNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_number")?.Value;
        set => this.WithProperty("organization_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Defines the options for providing a source organization for the DatasetConfig.
    /// </summary>
    public bool? OrganizationScope
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("organization_scope")?.Value;
        set => this.WithProperty("organization_scope", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Number of days of history that must be retained.
    /// </summary>
    public double? RetentionPeriodDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period_days")?.Value;
        set => this.WithProperty("retention_period_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
