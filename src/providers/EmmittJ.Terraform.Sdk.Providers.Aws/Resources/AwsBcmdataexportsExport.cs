using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for export in AwsBcmdataexportsExport.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The export_arn attribute.
    /// </summary>
    public TerraformValue<string> ExportArn
        => AsReference("export_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// DataQuery block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlockDataQueryBlock>? DataQuery
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlockDataQueryBlock>>("data_query");
        set => SetArgument("data_query", value);
    }

    /// <summary>
    /// DestinationConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlock>? DestinationConfigurations
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlock>>("destination_configurations");
        set => SetArgument("destination_configurations", value);
    }

    /// <summary>
    /// RefreshCadence block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlockRefreshCadenceBlock>? RefreshCadence
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlockRefreshCadenceBlock>>("refresh_cadence");
        set => SetArgument("refresh_cadence", value);
    }

}

/// <summary>
/// Block type for data_query in AwsBcmdataexportsExportExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlockDataQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_query";

    /// <summary>
    /// The query_statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStatement is required")]
    public required TerraformValue<string> QueryStatement
    {
        get => GetRequiredArgument<TerraformValue<string>>("query_statement");
        set => SetArgument("query_statement", value);
    }

    /// <summary>
    /// The table_configurations attribute.
    /// </summary>
    public TerraformMap<TerraformMap<string>>? TableConfigurations
    {
        get => GetArgument<TerraformMap<TerraformMap<string>>>("table_configurations");
        set => SetArgument("table_configurations", value);
    }

}

/// <summary>
/// Block type for destination_configurations in AwsBcmdataexportsExportExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_configurations";

    /// <summary>
    /// S3Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlock>? S3Destination
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlock>>("s3_destination");
        set => SetArgument("s3_destination", value);
    }

}

/// <summary>
/// Block type for s3_destination in AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_destination";

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Prefix is required")]
    public required TerraformValue<string> S3Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Region is required")]
    public required TerraformValue<string> S3Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_region");
        set => SetArgument("s3_region", value);
    }

    /// <summary>
    /// S3OutputConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlockS3OutputConfigurationsBlock>? S3OutputConfigurations
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlockS3OutputConfigurationsBlock>>("s3_output_configurations");
        set => SetArgument("s3_output_configurations", value);
    }

}

/// <summary>
/// Block type for s3_output_configurations in AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlockDestinationConfigurationsBlockS3DestinationBlockS3OutputConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_output_configurations";

    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    public required TerraformValue<string> Compression
    {
        get => GetRequiredArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    public required TerraformValue<string> OutputType
    {
        get => GetRequiredArgument<TerraformValue<string>>("output_type");
        set => SetArgument("output_type", value);
    }

    /// <summary>
    /// The overwrite attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Overwrite is required")]
    public required TerraformValue<string> Overwrite
    {
        get => GetRequiredArgument<TerraformValue<string>>("overwrite");
        set => SetArgument("overwrite", value);
    }

}

/// <summary>
/// Block type for refresh_cadence in AwsBcmdataexportsExportExportBlock.
/// Nesting mode: list
/// </summary>
public class AwsBcmdataexportsExportExportBlockRefreshCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "refresh_cadence";

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBcmdataexportsExport.
/// Nesting mode: single
/// </summary>
public class AwsBcmdataexportsExportTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bcmdataexports_export Terraform resource.
/// Manages a aws_bcmdataexports_export resource.
/// </summary>
public partial class AwsBcmdataexportsExport(string name) : TerraformResource("aws_bcmdataexports_export", name)
{
    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Export block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBcmdataexportsExportExportBlock>? Export
    {
        get => GetArgument<TerraformList<AwsBcmdataexportsExportExportBlock>>("export");
        set => SetArgument("export", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBcmdataexportsExportTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBcmdataexportsExportTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
