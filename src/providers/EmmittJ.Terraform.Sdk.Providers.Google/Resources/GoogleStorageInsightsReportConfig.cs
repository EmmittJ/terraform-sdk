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
        set => SetProperty("delimiter", value);
    }

    /// <summary>
    /// The boolean that indicates whether or not headers are included in the inventory report CSV file.
    /// </summary>
    public TerraformProperty<bool>? HeaderRequired
    {
        set => SetProperty("header_required", value);
    }

    /// <summary>
    /// The character used to separate the records in the inventory report CSV file.
    /// </summary>
    public TerraformProperty<string>? RecordSeparator
    {
        set => SetProperty("record_separator", value);
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
        set => SetProperty("frequency", value);
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
        set => SetProperty("metadata_fields", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("display_name");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The editable display name of the inventory report configuration. Has a limit of 256 characters. Can be empty.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// If set, all the inventory report details associated with this report configuration are deleted.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location of the ReportConfig. The source and destination buckets specified in the ReportConfig
    /// must be in the same location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for csv_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigCsvOptionsBlock>? CsvOptions
    {
        set => SetProperty("csv_options", value);
    }

    /// <summary>
    /// Block for frequency_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrequencyOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>? FrequencyOptions
    {
        set => SetProperty("frequency_options", value);
    }

    /// <summary>
    /// Block for object_metadata_report_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectMetadataReportOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>? ObjectMetadataReportOptions
    {
        set => SetProperty("object_metadata_report_options", value);
    }

    /// <summary>
    /// Block for parquet_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    public List<GoogleStorageInsightsReportConfigParquetOptionsBlock>? ParquetOptions
    {
        set => SetProperty("parquet_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageInsightsReportConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The UUID of the inventory report configuration.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
