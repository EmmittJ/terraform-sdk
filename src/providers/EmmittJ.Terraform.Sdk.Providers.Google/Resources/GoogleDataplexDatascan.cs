using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataBlock : TerraformBlock
{
    /// <summary>
    /// The Dataplex entity that represents the data source(e.g. BigQuery table) for Datascan.
    /// </summary>
    public TerraformProperty<string>? Entity
    {
        get => GetProperty<TerraformProperty<string>>("entity");
        set => WithProperty("entity", value);
    }

    /// <summary>
    /// The service-qualified full resource name of the cloud resource for a DataScan job to scan against. The field could be:
    /// Cloud Storage bucket (//storage.googleapis.com/projects/PROJECT_ID/buckets/BUCKET_ID) for DataDiscoveryScan OR BigQuery table of type &amp;quot;TABLE&amp;quot; (/bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID) for DataProfileScan/DataQualityScan.
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => WithProperty("resource", value);
    }

}

/// <summary>
/// Block type for data_discovery_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for data_profile_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlock : TerraformBlock
{
    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    public TerraformProperty<string>? RowFilter
    {
        get => GetProperty<TerraformProperty<string>>("row_filter");
        set => WithProperty("row_filter", value);
    }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    public TerraformProperty<double>? SamplingPercent
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percent");
        set => WithProperty("sampling_percent", value);
    }

}

/// <summary>
/// Block type for data_quality_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlock : TerraformBlock
{
    /// <summary>
    /// If set, the latest DataScan job result will be published to Dataplex Catalog.
    /// </summary>
    public TerraformProperty<bool>? CatalogPublishingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("catalog_publishing_enabled");
        set => WithProperty("catalog_publishing_enabled", value);
    }

    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    public TerraformProperty<string>? RowFilter
    {
        get => GetProperty<TerraformProperty<string>>("row_filter");
        set => WithProperty("row_filter", value);
    }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    public TerraformProperty<double>? SamplingPercent
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percent");
        set => WithProperty("sampling_percent", value);
    }

}

/// <summary>
/// Block type for execution_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlock : TerraformBlock
{
    /// <summary>
    /// The unnested field (of type Date or Timestamp) that contains values which monotonically increase over time. If not specified, a data scan will run for all data in the table.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => WithProperty("field", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexDatascanTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataplex_datascan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexDatascan : TerraformResource
{
    public GoogleDataplexDatascan(string name) : base("google_dataplex_datascan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("execution_status");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("type");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// DataScan identifier. Must contain only lowercase letters, numbers and hyphens. Must start with a letter. Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    public required TerraformProperty<string> DataScanId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_scan_id");
        set => this.WithProperty("data_scan_id", value);
    }

    /// <summary>
    /// Description of the scan.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// User-defined labels for the scan. A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location where the data scan should reside.
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
    /// Block for data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Data block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Data block(s) allowed")]
    public List<GoogleDataplexDatascanDataBlock>? Data
    {
        get => GetProperty<List<GoogleDataplexDatascanDataBlock>>("data");
        set => this.WithProperty("data", value);
    }

    /// <summary>
    /// Block for data_discovery_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDiscoverySpec block(s) allowed")]
    public List<GoogleDataplexDatascanDataDiscoverySpecBlock>? DataDiscoverySpec
    {
        get => GetProperty<List<GoogleDataplexDatascanDataDiscoverySpecBlock>>("data_discovery_spec");
        set => this.WithProperty("data_discovery_spec", value);
    }

    /// <summary>
    /// Block for data_profile_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProfileSpec block(s) allowed")]
    public List<GoogleDataplexDatascanDataProfileSpecBlock>? DataProfileSpec
    {
        get => GetProperty<List<GoogleDataplexDatascanDataProfileSpecBlock>>("data_profile_spec");
        set => this.WithProperty("data_profile_spec", value);
    }

    /// <summary>
    /// Block for data_quality_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualitySpec block(s) allowed")]
    public List<GoogleDataplexDatascanDataQualitySpecBlock>? DataQualitySpec
    {
        get => GetProperty<List<GoogleDataplexDatascanDataQualitySpecBlock>>("data_quality_spec");
        set => this.WithProperty("data_quality_spec", value);
    }

    /// <summary>
    /// Block for execution_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    public List<GoogleDataplexDatascanExecutionSpecBlock>? ExecutionSpec
    {
        get => GetProperty<List<GoogleDataplexDatascanExecutionSpecBlock>>("execution_spec");
        set => this.WithProperty("execution_spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexDatascanTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataplexDatascanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the scan was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Status of the data scan execution.
    /// </summary>
    public TerraformExpression ExecutionStatus => this["execution_status"];

    /// <summary>
    /// The relative resource name of the scan, of the form: projects/{project}/locations/{locationId}/dataScans/{datascan_id}, where project refers to a project_id or project_number and locationId refers to a GCP region.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Current state of the DataScan.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The type of DataScan.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// System generated globally unique ID for the scan. This ID will be different if the scan is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time when the scan was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
