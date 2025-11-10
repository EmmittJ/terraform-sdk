using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for csv_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigCsvOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The delimiter used to separate the fields in the inventory report CSV file.
    /// </summary>
    [TerraformPropertyName("delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delimiter { get; set; }

    /// <summary>
    /// The boolean that indicates whether or not headers are included in the inventory report CSV file.
    /// </summary>
    [TerraformPropertyName("header_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HeaderRequired { get; set; }

    /// <summary>
    /// The character used to separate the records in the inventory report CSV file.
    /// </summary>
    [TerraformPropertyName("record_separator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecordSeparator { get; set; }

}

/// <summary>
/// Block type for frequency_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigFrequencyOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The frequency in which inventory reports are generated. Values are DAILY or WEEKLY. Possible values: [&amp;quot;DAILY&amp;quot;, &amp;quot;WEEKLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

}

/// <summary>
/// Block type for object_metadata_report_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The metadata fields included in an inventory report.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataFields is required")]
    [TerraformPropertyName("metadata_fields")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? MetadataFields { get; set; }

}

/// <summary>
/// Block type for parquet_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigParquetOptionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsReportConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_insights_report_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageInsightsReportConfig : TerraformResource
{
    public GoogleStorageInsightsReportConfig(string name) : base("google_storage_insights_report_config", name)
    {
    }

    /// <summary>
    /// The editable display name of the inventory report configuration. Has a limit of 256 characters. Can be empty.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// If set, all the inventory report details associated with this report configuration are deleted.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the ReportConfig. The source and destination buckets specified in the ReportConfig
    /// must be in the same location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for csv_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    [TerraformPropertyName("csv_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigCsvOptionsBlock>>? CsvOptions { get; set; } = new();

    /// <summary>
    /// Block for frequency_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrequencyOptions block(s) allowed")]
    [TerraformPropertyName("frequency_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>>? FrequencyOptions { get; set; } = new();

    /// <summary>
    /// Block for object_metadata_report_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectMetadataReportOptions block(s) allowed")]
    [TerraformPropertyName("object_metadata_report_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>>? ObjectMetadataReportOptions { get; set; } = new();

    /// <summary>
    /// Block for parquet_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    [TerraformPropertyName("parquet_options")]
    public TerraformList<TerraformBlock<GoogleStorageInsightsReportConfigParquetOptionsBlock>>? ParquetOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageInsightsReportConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The UUID of the inventory report configuration.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
