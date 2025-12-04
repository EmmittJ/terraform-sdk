using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for csv_options in GoogleStorageInsightsReportConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigCsvOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_options";

    /// <summary>
    /// The delimiter used to separate the fields in the inventory report CSV file.
    /// </summary>
    public TerraformValue<string>? Delimiter
    {
        get => GetArgument<TerraformValue<string>>("delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The boolean that indicates whether or not headers are included in the inventory report CSV file.
    /// </summary>
    public TerraformValue<bool>? HeaderRequired
    {
        get => GetArgument<TerraformValue<bool>>("header_required");
        set => SetArgument("header_required", value);
    }

    /// <summary>
    /// The character used to separate the records in the inventory report CSV file.
    /// </summary>
    public TerraformValue<string>? RecordSeparator
    {
        get => GetArgument<TerraformValue<string>>("record_separator");
        set => SetArgument("record_separator", value);
    }

}


/// <summary>
/// Block type for frequency_options in GoogleStorageInsightsReportConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigFrequencyOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frequency_options";

    /// <summary>
    /// The frequency in which inventory reports are generated. Values are DAILY or WEEKLY. Possible values: [&amp;quot;DAILY&amp;quot;, &amp;quot;WEEKLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// EndDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public required TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlockEndDateBlock> EndDate
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlockEndDateBlock>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// StartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public required TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlockStartDateBlock> StartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlockStartDateBlock>>("start_date");
        set => SetArgument("start_date", value);
    }

}

/// <summary>
/// Block type for end_date in GoogleStorageInsightsReportConfigFrequencyOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigFrequencyOptionsBlockEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_date";

    /// <summary>
    /// The day of the month to stop generating inventory reports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// The month to stop generating inventory reports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// The year to stop generating inventory reports
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_date in GoogleStorageInsightsReportConfigFrequencyOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigFrequencyOptionsBlockStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_date";

    /// <summary>
    /// The day of the month to start generating inventory reports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// The month to start generating inventory reports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// The year to start generating inventory reports
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}


/// <summary>
/// Block type for object_metadata_report_options in GoogleStorageInsightsReportConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_metadata_report_options";

    /// <summary>
    /// The metadata fields included in an inventory report.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataFields is required")]
    public TerraformList<string>? MetadataFields
    {
        get => GetArgument<TerraformList<string>>("metadata_fields");
        set => SetArgument("metadata_fields", value);
    }

    /// <summary>
    /// StorageDestinationOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDestinationOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageDestinationOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDestinationOptions block(s) allowed")]
    public required TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageDestinationOptionsBlock> StorageDestinationOptions
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageDestinationOptionsBlock>>("storage_destination_options");
        set => SetArgument("storage_destination_options", value);
    }

    /// <summary>
    /// StorageFilters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageFilters block(s) allowed")]
    public TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageFiltersBlock>? StorageFilters
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageFiltersBlock>>("storage_filters");
        set => SetArgument("storage_filters", value);
    }

}

/// <summary>
/// Block type for storage_destination_options in GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageDestinationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_destination_options";

    /// <summary>
    /// The destination bucket that stores the generated inventory reports.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The path within the destination bucket to store generated inventory reports.
    /// </summary>
    public TerraformValue<string>? DestinationPath
    {
        get => GetArgument<TerraformValue<string>>("destination_path");
        set => SetArgument("destination_path", value);
    }

}

/// <summary>
/// Block type for storage_filters in GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlockStorageFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_filters";

    /// <summary>
    /// The filter to use when specifying which bucket to generate inventory reports for.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

}


/// <summary>
/// Block type for parquet_options in GoogleStorageInsightsReportConfig.
/// Nesting mode: list
/// </summary>
public class GoogleStorageInsightsReportConfigParquetOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parquet_options";

}


/// <summary>
/// Block type for timeouts in GoogleStorageInsightsReportConfig.
/// Nesting mode: single
/// </summary>
public class GoogleStorageInsightsReportConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_storage_insights_report_config Terraform resource.
/// Manages a google_storage_insights_report_config resource.
/// </summary>
public partial class GoogleStorageInsightsReportConfig(string name) : TerraformResource("google_storage_insights_report_config", name)
{
    /// <summary>
    /// The editable display name of the inventory report configuration. Has a limit of 256 characters. Can be empty.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// If set, all the inventory report details associated with this report configuration are deleted.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the ReportConfig. The source and destination buckets specified in the ReportConfig
    /// must be in the same location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The UUID of the inventory report configuration.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// CsvOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public TerraformList<GoogleStorageInsightsReportConfigCsvOptionsBlock>? CsvOptions
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsReportConfigCsvOptionsBlock>>("csv_options");
        set => SetArgument("csv_options", value);
    }

    /// <summary>
    /// FrequencyOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrequencyOptions block(s) allowed")]
    public TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>? FrequencyOptions
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsReportConfigFrequencyOptionsBlock>>("frequency_options");
        set => SetArgument("frequency_options", value);
    }

    /// <summary>
    /// ObjectMetadataReportOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectMetadataReportOptions block(s) allowed")]
    public TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>? ObjectMetadataReportOptions
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsReportConfigObjectMetadataReportOptionsBlock>>("object_metadata_report_options");
        set => SetArgument("object_metadata_report_options", value);
    }

    /// <summary>
    /// ParquetOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    public TerraformList<GoogleStorageInsightsReportConfigParquetOptionsBlock>? ParquetOptions
    {
        get => GetArgument<TerraformList<GoogleStorageInsightsReportConfigParquetOptionsBlock>>("parquet_options");
        set => SetArgument("parquet_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageInsightsReportConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageInsightsReportConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
