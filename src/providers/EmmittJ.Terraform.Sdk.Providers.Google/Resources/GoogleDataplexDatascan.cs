using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexDatascanDataBlock : TerraformBlockBase
{
    /// <summary>
    /// The Dataplex entity that represents the data source(e.g. BigQuery table) for Datascan.
    /// </summary>
    [TerraformProperty("entity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Entity { get; set; }

    /// <summary>
    /// The service-qualified full resource name of the cloud resource for a DataScan job to scan against. The field could be:
    /// Cloud Storage bucket (//storage.googleapis.com/projects/PROJECT_ID/buckets/BUCKET_ID) for DataDiscoveryScan OR BigQuery table of type &amp;quot;TABLE&amp;quot; (/bigquery.googleapis.com/projects/PROJECT_ID/datasets/DATASET_ID/tables/TABLE_ID) for DataProfileScan/DataQualityScan.
    /// </summary>
    [TerraformProperty("resource")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Resource { get; set; }

}

/// <summary>
/// Block type for data_discovery_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexDatascanDataDiscoverySpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for data_profile_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexDatascanDataProfileSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    [TerraformProperty("row_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RowFilter { get; set; }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    [TerraformProperty("sampling_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SamplingPercent { get; set; }

}

/// <summary>
/// Block type for data_quality_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexDatascanDataQualitySpecBlock : TerraformBlockBase
{
    /// <summary>
    /// If set, the latest DataScan job result will be published to Dataplex Catalog.
    /// </summary>
    [TerraformProperty("catalog_publishing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CatalogPublishingEnabled { get; set; }

    /// <summary>
    /// A filter applied to all rows in a single DataScan job. The filter needs to be a valid SQL expression for a WHERE clause in BigQuery standard SQL syntax. Example: col1 &amp;gt;= 0 AND col2 &amp;lt; 10
    /// </summary>
    [TerraformProperty("row_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RowFilter { get; set; }

    /// <summary>
    /// The percentage of the records to be selected from the dataset for DataScan.
    /// Value can range between 0.0 and 100.0 with up to 3 significant decimal digits.
    /// Sampling is not applied if &#39;sampling_percent&#39; is not specified, 0 or 100.
    /// </summary>
    [TerraformProperty("sampling_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SamplingPercent { get; set; }

}

/// <summary>
/// Block type for execution_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexDatascanExecutionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The unnested field (of type Date or Timestamp) that contains values which monotonically increase over time. If not specified, a data scan will run for all data in the table.
    /// </summary>
    [TerraformProperty("field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Field { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataplexDatascanTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataplex_datascan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataplexDatascan : TerraformResource
{
    public GoogleDataplexDatascan(string name) : base("google_dataplex_datascan", name)
    {
    }

    /// <summary>
    /// DataScan identifier. Must contain only lowercase letters, numbers and hyphens. Must start with a letter. Must end with a number or a letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    [TerraformProperty("data_scan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataScanId { get; set; }

    /// <summary>
    /// Description of the scan.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the scan. A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the data scan should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Data block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Data block(s) allowed")]
    [TerraformProperty("data")]
    public partial TerraformList<TerraformBlock<GoogleDataplexDatascanDataBlock>>? Data { get; set; }

    /// <summary>
    /// Block for data_discovery_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDiscoverySpec block(s) allowed")]
    [TerraformProperty("data_discovery_spec")]
    public partial TerraformList<TerraformBlock<GoogleDataplexDatascanDataDiscoverySpecBlock>>? DataDiscoverySpec { get; set; }

    /// <summary>
    /// Block for data_profile_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProfileSpec block(s) allowed")]
    [TerraformProperty("data_profile_spec")]
    public partial TerraformList<TerraformBlock<GoogleDataplexDatascanDataProfileSpecBlock>>? DataProfileSpec { get; set; }

    /// <summary>
    /// Block for data_quality_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualitySpec block(s) allowed")]
    [TerraformProperty("data_quality_spec")]
    public partial TerraformList<TerraformBlock<GoogleDataplexDatascanDataQualitySpecBlock>>? DataQualitySpec { get; set; }

    /// <summary>
    /// Block for execution_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    [TerraformProperty("execution_spec")]
    public partial TerraformList<TerraformBlock<GoogleDataplexDatascanExecutionSpecBlock>>? ExecutionSpec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataplexDatascanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the scan was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Status of the data scan execution.
    /// </summary>
    [TerraformProperty("execution_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExecutionStatus { get; }

    /// <summary>
    /// The relative resource name of the scan, of the form: projects/{project}/locations/{locationId}/dataScans/{datascan_id}, where project refers to a project_id or project_number and locationId refers to a GCP region.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Current state of the DataScan.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The type of DataScan.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// System generated globally unique ID for the scan. This ID will be different if the scan is deleted and re-created with the same name.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time when the scan was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
