using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for csv_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsReportConfigCsvOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The delimiter used to separate the fields in the inventory report CSV file.
    /// </summary>
    [TerraformProperty("delimiter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delimiter { get; set; }

    /// <summary>
    /// The boolean that indicates whether or not headers are included in the inventory report CSV file.
    /// </summary>
    [TerraformProperty("header_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HeaderRequired { get; set; }

    /// <summary>
    /// The character used to separate the records in the inventory report CSV file.
    /// </summary>
    [TerraformProperty("record_separator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecordSeparator { get; set; }

}

/// <summary>
/// Block type for frequency_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsReportConfigFrequencyOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The frequency in which inventory reports are generated. Values are DAILY or WEEKLY. Possible values: [&amp;quot;DAILY&amp;quot;, &amp;quot;WEEKLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformProperty("frequency")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Frequency { get; set; }

}

/// <summary>
/// Block type for object_metadata_report_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The metadata fields included in an inventory report.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataFields is required")]
    [TerraformProperty("metadata_fields")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? MetadataFields { get; set; }

}

/// <summary>
/// Block type for parquet_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageInsightsReportConfigParquetOptionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageInsightsReportConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_insights_report_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageInsightsReportConfig : TerraformResource
{
    public GoogleStorageInsightsReportConfig(string name) : base("google_storage_insights_report_config", name)
    {
    }

    /// <summary>
    /// The editable display name of the inventory report configuration. Has a limit of 256 characters. Can be empty.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// If set, all the inventory report details associated with this report configuration are deleted.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the ReportConfig. The source and destination buckets specified in the ReportConfig
    /// must be in the same location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for csv_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    [TerraformProperty("csv_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigCsvOptionsBlock>>? CsvOptions { get; set; }

    /// <summary>
    /// Block for frequency_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrequencyOptions block(s) allowed")]
    [TerraformProperty("frequency_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>>? FrequencyOptions { get; set; }

    /// <summary>
    /// Block for object_metadata_report_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectMetadataReportOptions block(s) allowed")]
    [TerraformProperty("object_metadata_report_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>>? ObjectMetadataReportOptions { get; set; }

    /// <summary>
    /// Block for parquet_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    [TerraformProperty("parquet_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigParquetOptionsBlock>>? ParquetOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleStorageInsightsReportConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The UUID of the inventory report configuration.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
