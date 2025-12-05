using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for table_data in AwsLakeformationDataCellsFilter.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataCellsFilterTableDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_data";

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public TerraformSet<string> ColumnNames
    {
        get => GetArgument<TerraformSet<string>>("column_names") ?? CreateReference("column_names");
        set => SetArgument("column_names", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

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
    /// The table_catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableCatalogId is required")]
    public required TerraformValue<string> TableCatalogId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_catalog_id");
        set => SetArgument("table_catalog_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id") ?? CreateReference("version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// ColumnWildcard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationDataCellsFilterTableDataBlockColumnWildcardBlock>? ColumnWildcard
    {
        get => GetArgument<TerraformList<AwsLakeformationDataCellsFilterTableDataBlockColumnWildcardBlock>>("column_wildcard");
        set => SetArgument("column_wildcard", value);
    }

    /// <summary>
    /// RowFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlock>? RowFilter
    {
        get => GetArgument<TerraformList<AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlock>>("row_filter");
        set => SetArgument("row_filter", value);
    }

}

/// <summary>
/// Block type for column_wildcard in AwsLakeformationDataCellsFilterTableDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataCellsFilterTableDataBlockColumnWildcardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_wildcard";

    /// <summary>
    /// The excluded_column_names attribute.
    /// </summary>
    public TerraformList<string>? ExcludedColumnNames
    {
        get => GetArgument<TerraformList<string>>("excluded_column_names");
        set => SetArgument("excluded_column_names", value);
    }

}

/// <summary>
/// Block type for row_filter in AwsLakeformationDataCellsFilterTableDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "row_filter";

    /// <summary>
    /// The filter_expression attribute.
    /// </summary>
    public TerraformValue<string> FilterExpression
    {
        get => GetArgument<TerraformValue<string>>("filter_expression") ?? CreateReference("filter_expression");
        set => SetArgument("filter_expression", value);
    }

    /// <summary>
    /// AllRowsWildcard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlockAllRowsWildcardBlock>? AllRowsWildcard
    {
        get => GetArgument<TerraformList<AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlockAllRowsWildcardBlock>>("all_rows_wildcard");
        set => SetArgument("all_rows_wildcard", value);
    }

}

/// <summary>
/// Block type for all_rows_wildcard in AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationDataCellsFilterTableDataBlockRowFilterBlockAllRowsWildcardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all_rows_wildcard";

}


/// <summary>
/// Block type for timeouts in AwsLakeformationDataCellsFilter.
/// Nesting mode: single
/// </summary>
public class AwsLakeformationDataCellsFilterTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_lakeformation_data_cells_filter Terraform resource.
/// Manages a aws_lakeformation_data_cells_filter resource.
/// </summary>
public partial class AwsLakeformationDataCellsFilter(string name) : TerraformResource("aws_lakeformation_data_cells_filter", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// TableData block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationDataCellsFilterTableDataBlock>? TableData
    {
        get => GetArgument<TerraformList<AwsLakeformationDataCellsFilterTableDataBlock>>("table_data");
        set => SetArgument("table_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLakeformationDataCellsFilterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLakeformationDataCellsFilterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
