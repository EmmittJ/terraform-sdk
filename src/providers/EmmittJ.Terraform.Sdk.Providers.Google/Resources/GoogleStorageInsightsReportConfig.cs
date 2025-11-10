using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for csv_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigCsvOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The delimiter used to separate the fields in the inventory report CSV file.
    /// </summary>
    public TerraformProperty<string>? Delimiter
    {
        get => GetProperty<TerraformProperty<string>>("delimiter");
        set => WithProperty("delimiter", value);
    }

    /// <summary>
    /// The boolean that indicates whether or not headers are included in the inventory report CSV file.
    /// </summary>
    public TerraformProperty<bool>? HeaderRequired
    {
        get => GetProperty<TerraformProperty<bool>>("header_required");
        set => WithProperty("header_required", value);
    }

    /// <summary>
    /// The character used to separate the records in the inventory report CSV file.
    /// </summary>
    public TerraformProperty<string>? RecordSeparator
    {
        get => GetProperty<TerraformProperty<string>>("record_separator");
        set => WithProperty("record_separator", value);
    }

}

/// <summary>
/// Block type for frequency_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigFrequencyOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The frequency in which inventory reports are generated. Values are DAILY or WEEKLY. Possible values: [&amp;quot;DAILY&amp;quot;, &amp;quot;WEEKLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformProperty<string> Frequency
    {
        get => GetRequiredProperty<TerraformProperty<string>>("frequency");
        set => WithProperty("frequency", value);
    }

}

/// <summary>
/// Block type for object_metadata_report_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The metadata fields included in an inventory report.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataFields is required")]
    public List<TerraformProperty<string>>? MetadataFields
    {
        get => GetProperty<List<TerraformProperty<string>>>("metadata_fields");
        set => WithProperty("metadata_fields", value);
    }

}

/// <summary>
/// Block type for parquet_options in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigParquetOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsReportConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_storage_insights_report_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageInsightsReportConfig : TerraformResource
{
    public GoogleStorageInsightsReportConfig(string name) : base("google_storage_insights_report_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// The editable display name of the inventory report configuration. Has a limit of 256 characters. Can be empty.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// If set, all the inventory report details associated with this report configuration are deleted.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The location of the ReportConfig. The source and destination buckets specified in the ReportConfig
    /// must be in the same location.
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
    /// Block for csv_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigCsvOptionsBlock>? CsvOptions
    {
        get => GetProperty<List<GoogleStorageInsightsReportConfigCsvOptionsBlock>>("csv_options");
        set => this.WithProperty("csv_options", value);
    }

    /// <summary>
    /// Block for frequency_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrequencyOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>? FrequencyOptions
    {
        get => GetProperty<List<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>>("frequency_options");
        set => this.WithProperty("frequency_options", value);
    }

    /// <summary>
    /// Block for object_metadata_report_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectMetadataReportOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>? ObjectMetadataReportOptions
    {
        get => GetProperty<List<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>>("object_metadata_report_options");
        set => this.WithProperty("object_metadata_report_options", value);
    }

    /// <summary>
    /// Block for parquet_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigParquetOptionsBlock>? ParquetOptions
    {
        get => GetProperty<List<GoogleStorageInsightsReportConfigParquetOptionsBlock>>("parquet_options");
        set => this.WithProperty("parquet_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageInsightsReportConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageInsightsReportConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The UUID of the inventory report configuration.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
