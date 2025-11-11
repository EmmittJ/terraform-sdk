using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataBlock
{
    /// <summary>
    /// The Dataplex entity that represents the data source(e.g. BigQuery table) for Datascan.
    /// </summary>
    [TerraformPropertyName("entity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Entity { get; set; }

    /// <summary>
    /// The service-qualified full resource name of the cloud resource for a DataScan job to scan against. The field could be:
    /// Cloud Storage bucket (//storage.googleapis.com/projects/PROJECT_ID/buckets/BUCKET_ID) for DataDiscoveryScan OR BigQuery table of type &amp;quot;TABLE&amp;quot; (/bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID) for DataProfileScan/DataQualityScan.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Resource { get; set; }

}

/// <summary>
/// Block type for data_discovery_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataDiscoverySpecBlock
{
}

/// <summary>
/// Block type for data_profile_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataProfileSpecBlock
{
    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    [TerraformPropertyName("row_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RowFilter { get; set; }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    [TerraformPropertyName("sampling_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SamplingPercent { get; set; }

}

/// <summary>
/// Block type for data_quality_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanDataQualitySpecBlock
{
    /// <summary>
    /// If set, the latest DataScan job result will be published to Dataplex Catalog.
    /// </summary>
    [TerraformPropertyName("catalog_publishing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CatalogPublishingEnabled { get; set; }

    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    [TerraformPropertyName("row_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RowFilter { get; set; }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    [TerraformPropertyName("sampling_percent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SamplingPercent { get; set; }

}

/// <summary>
/// Block type for execution_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexDatascanExecutionSpecBlock
{
    /// <summary>
    /// The unnested field (of type Date or Timestamp) that contains values which monotonically increase over time. If not specified, a data scan will run for all data in the table.
    /// </summary>
    [TerraformPropertyName("field")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Field { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexDatascanTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataplex_datascan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexDatascan : TerraformResource
{
    public GoogleDataplexDatascan(string name) : base("google_dataplex_datascan", name)
    {
    }

    /// <summary>
    /// DataScan identifier. Must contain only lowercase letters, numbers and hyphens. Must start with a letter. Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    [TerraformPropertyName("data_scan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataScanId { get; set; }

    /// <summary>
    /// Description of the scan.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// User-defined labels for the scan. A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the data scan should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Data block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Data block(s) allowed")]
    [TerraformPropertyName("data")]
    public TerraformList<TerraformBlock<GoogleDataplexDatascanDataBlock>>? Data { get; set; }

    /// <summary>
    /// Block for data_discovery_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDiscoverySpec block(s) allowed")]
    [TerraformPropertyName("data_discovery_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexDatascanDataDiscoverySpecBlock>>? DataDiscoverySpec { get; set; }

    /// <summary>
    /// Block for data_profile_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProfileSpec block(s) allowed")]
    [TerraformPropertyName("data_profile_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexDatascanDataProfileSpecBlock>>? DataProfileSpec { get; set; }

    /// <summary>
    /// Block for data_quality_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualitySpec block(s) allowed")]
    [TerraformPropertyName("data_quality_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexDatascanDataQualitySpecBlock>>? DataQualitySpec { get; set; }

    /// <summary>
    /// Block for execution_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    [TerraformPropertyName("execution_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexDatascanExecutionSpecBlock>>? ExecutionSpec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataplexDatascanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the scan was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Status of the data scan execution.
    /// </summary>
    [TerraformPropertyName("execution_status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExecutionStatus => new TerraformReference(this, "execution_status");

    /// <summary>
    /// The relative resource name of the scan, of the form: projects/{project}/locations/{locationId}/dataScans/{datascan_id}, where project refers to a project_id or project_number and locationId refers to a GCP region.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Current state of the DataScan.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The type of DataScan.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// System generated globally unique ID for the scan. This ID will be different if the scan is deleted and re-created with the same name.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

    /// <summary>
    /// The time when the scan was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
