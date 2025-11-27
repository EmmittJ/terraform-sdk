using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for column_groups in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_groups";

    /// <summary>
    /// GeoSpatialColumnGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoSpatialColumnGroup block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetColumnGroupsBlockGeoSpatialColumnGroupBlock>? GeoSpatialColumnGroup
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetColumnGroupsBlockGeoSpatialColumnGroupBlock>>("geo_spatial_column_group");
        set => SetArgument("geo_spatial_column_group", value);
    }

}

/// <summary>
/// Block type for geo_spatial_column_group in AwsQuicksightDataSetColumnGroupsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnGroupsBlockGeoSpatialColumnGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_spatial_column_group";

    /// <summary>
    /// The columns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Columns is required")]
    public TerraformList<string>? Columns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "columns").ResolveNodes(ctx));
        set => SetArgument("columns", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountryCode is required")]
    public required TerraformValue<string> CountryCode
    {
        get => new TerraformReference<string>(this, "country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for column_level_permission_rules in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnLevelPermissionRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_level_permission_rules";

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public TerraformList<string>? ColumnNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "column_names").ResolveNodes(ctx));
        set => SetArgument("column_names", value);
    }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    public TerraformList<string>? Principals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "principals").ResolveNodes(ctx));
        set => SetArgument("principals", value);
    }

}


/// <summary>
/// Block type for data_set_usage_configuration in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetDataSetUsageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_set_usage_configuration";

    /// <summary>
    /// The disable_use_as_direct_query_source attribute.
    /// </summary>
    public TerraformValue<bool> DisableUseAsDirectQuerySource
    {
        get => new TerraformReference<bool>(this, "disable_use_as_direct_query_source");
        set => SetArgument("disable_use_as_direct_query_source", value);
    }

    /// <summary>
    /// The disable_use_as_imported_source attribute.
    /// </summary>
    public TerraformValue<bool> DisableUseAsImportedSource
    {
        get => new TerraformReference<bool>(this, "disable_use_as_imported_source");
        set => SetArgument("disable_use_as_imported_source", value);
    }

}


/// <summary>
/// Block type for field_folders in AwsQuicksightDataSet.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetFieldFoldersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_folders";

    /// <summary>
    /// The columns attribute.
    /// </summary>
    public TerraformList<string>? Columns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "columns").ResolveNodes(ctx));
        set => SetArgument("columns", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The field_folders_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldFoldersId is required")]
    public required TerraformValue<string> FieldFoldersId
    {
        get => new TerraformReference<string>(this, "field_folders_id");
        set => SetArgument("field_folders_id", value);
    }

}


/// <summary>
/// Block type for logical_table_map in AwsQuicksightDataSet.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logical_table_map";

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// The logical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicalTableMapId is required")]
    public required TerraformValue<string> LogicalTableMapId
    {
        get => new TerraformReference<string>(this, "logical_table_map_id");
        set => SetArgument("logical_table_map_id", value);
    }

    /// <summary>
    /// DataTransforms block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2048, ErrorMessage = "Maximum 2048 DataTransforms block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock>? DataTransforms
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock>>("data_transforms");
        set => SetArgument("data_transforms", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for data_transforms in AwsQuicksightDataSetLogicalTableMapBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_transforms";

    /// <summary>
    /// CastColumnTypeOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CastColumnTypeOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCastColumnTypeOperationBlock>? CastColumnTypeOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCastColumnTypeOperationBlock>>("cast_column_type_operation");
        set => SetArgument("cast_column_type_operation", value);
    }

    /// <summary>
    /// CreateColumnsOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateColumnsOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlock>? CreateColumnsOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlock>>("create_columns_operation");
        set => SetArgument("create_columns_operation", value);
    }

    /// <summary>
    /// FilterOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockFilterOperationBlock>? FilterOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockFilterOperationBlock>>("filter_operation");
        set => SetArgument("filter_operation", value);
    }

    /// <summary>
    /// ProjectOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProjectOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockProjectOperationBlock>? ProjectOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockProjectOperationBlock>>("project_operation");
        set => SetArgument("project_operation", value);
    }

    /// <summary>
    /// RenameColumnOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RenameColumnOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockRenameColumnOperationBlock>? RenameColumnOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockRenameColumnOperationBlock>>("rename_column_operation");
        set => SetArgument("rename_column_operation", value);
    }

    /// <summary>
    /// TagColumnOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagColumnOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlock>? TagColumnOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlock>>("tag_column_operation");
        set => SetArgument("tag_column_operation", value);
    }

    /// <summary>
    /// UntagColumnOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UntagColumnOperation block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockUntagColumnOperationBlock>? UntagColumnOperation
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockUntagColumnOperationBlock>>("untag_column_operation");
        set => SetArgument("untag_column_operation", value);
    }

}

/// <summary>
/// Block type for cast_column_type_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCastColumnTypeOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cast_column_type_operation";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The new_column_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NewColumnType is required")]
    public required TerraformValue<string> NewColumnType
    {
        get => new TerraformReference<string>(this, "new_column_type");
        set => SetArgument("new_column_type", value);
    }

}

/// <summary>
/// Block type for create_columns_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_columns_operation";

    /// <summary>
    /// Columns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Columns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Columns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(128, ErrorMessage = "Maximum 128 Columns block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlockColumnsBlock> Columns
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

}

/// <summary>
/// Block type for columns in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockCreateColumnsOperationBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// The column_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnId is required")]
    public required TerraformValue<string> ColumnId
    {
        get => new TerraformReference<string>(this, "column_id");
        set => SetArgument("column_id", value);
    }

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

}

/// <summary>
/// Block type for filter_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockFilterOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_operation";

    /// <summary>
    /// The condition_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionExpression is required")]
    public required TerraformValue<string> ConditionExpression
    {
        get => new TerraformReference<string>(this, "condition_expression");
        set => SetArgument("condition_expression", value);
    }

}

/// <summary>
/// Block type for project_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockProjectOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "project_operation";

    /// <summary>
    /// The projected_columns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectedColumns is required")]
    public TerraformList<string>? ProjectedColumns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "projected_columns").ResolveNodes(ctx));
        set => SetArgument("projected_columns", value);
    }

}

/// <summary>
/// Block type for rename_column_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockRenameColumnOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rename_column_operation";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The new_column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NewColumnName is required")]
    public required TerraformValue<string> NewColumnName
    {
        get => new TerraformReference<string>(this, "new_column_name");
        set => SetArgument("new_column_name", value);
    }

}

/// <summary>
/// Block type for tag_column_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_column_operation";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tags is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tags block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(16, ErrorMessage = "Maximum 16 Tags block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlock> Tags
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The column_geographic_role attribute.
    /// </summary>
    public TerraformValue<string> ColumnGeographicRole
    {
        get => new TerraformReference<string>(this, "column_geographic_role");
        set => SetArgument("column_geographic_role", value);
    }

    /// <summary>
    /// ColumnDescription block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ColumnDescription block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlockColumnDescriptionBlock>? ColumnDescription
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlockColumnDescriptionBlock>>("column_description");
        set => SetArgument("column_description", value);
    }

}

/// <summary>
/// Block type for column_description in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockTagColumnOperationBlockTagsBlockColumnDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_description";

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformValue<string> Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for untag_column_operation in AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockDataTransformsBlockUntagColumnOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "untag_column_operation";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The tag_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagNames is required")]
    public TerraformList<string>? TagNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tag_names").ResolveNodes(ctx));
        set => SetArgument("tag_names", value);
    }

}

/// <summary>
/// Block type for source in AwsQuicksightDataSetLogicalTableMapBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The data_set_arn attribute.
    /// </summary>
    public TerraformValue<string> DataSetArn
    {
        get => new TerraformReference<string>(this, "data_set_arn");
        set => SetArgument("data_set_arn", value);
    }

    /// <summary>
    /// The physical_table_id attribute.
    /// </summary>
    public TerraformValue<string> PhysicalTableId
    {
        get => new TerraformReference<string>(this, "physical_table_id");
        set => SetArgument("physical_table_id", value);
    }

    /// <summary>
    /// JoinInstruction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JoinInstruction block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlock>? JoinInstruction
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlock>>("join_instruction");
        set => SetArgument("join_instruction", value);
    }

}

/// <summary>
/// Block type for join_instruction in AwsQuicksightDataSetLogicalTableMapBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "join_instruction";

    /// <summary>
    /// The left_operand attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LeftOperand is required")]
    public required TerraformValue<string> LeftOperand
    {
        get => new TerraformReference<string>(this, "left_operand");
        set => SetArgument("left_operand", value);
    }

    /// <summary>
    /// The on_clause attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnClause is required")]
    public required TerraformValue<string> OnClause
    {
        get => new TerraformReference<string>(this, "on_clause");
        set => SetArgument("on_clause", value);
    }

    /// <summary>
    /// The right_operand attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RightOperand is required")]
    public required TerraformValue<string> RightOperand
    {
        get => new TerraformReference<string>(this, "right_operand");
        set => SetArgument("right_operand", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// LeftJoinKeyProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LeftJoinKeyProperties block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockLeftJoinKeyPropertiesBlock>? LeftJoinKeyProperties
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockLeftJoinKeyPropertiesBlock>>("left_join_key_properties");
        set => SetArgument("left_join_key_properties", value);
    }

    /// <summary>
    /// RightJoinKeyProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RightJoinKeyProperties block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockRightJoinKeyPropertiesBlock>? RightJoinKeyProperties
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockRightJoinKeyPropertiesBlock>>("right_join_key_properties");
        set => SetArgument("right_join_key_properties", value);
    }

}

/// <summary>
/// Block type for left_join_key_properties in AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockLeftJoinKeyPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "left_join_key_properties";

    /// <summary>
    /// The unique_key attribute.
    /// </summary>
    public TerraformValue<bool> UniqueKey
    {
        get => new TerraformReference<bool>(this, "unique_key");
        set => SetArgument("unique_key", value);
    }

}

/// <summary>
/// Block type for right_join_key_properties in AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlockSourceBlockJoinInstructionBlockRightJoinKeyPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "right_join_key_properties";

    /// <summary>
    /// The unique_key attribute.
    /// </summary>
    public TerraformValue<bool> UniqueKey
    {
        get => new TerraformReference<bool>(this, "unique_key");
        set => SetArgument("unique_key", value);
    }

}


/// <summary>
/// Block type for permissions in AwsQuicksightDataSet.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "actions").ResolveNodes(ctx));
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => new TerraformReference<string>(this, "principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for physical_table_map in AwsQuicksightDataSet.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "physical_table_map";

    /// <summary>
    /// The physical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalTableMapId is required")]
    public required TerraformValue<string> PhysicalTableMapId
    {
        get => new TerraformReference<string>(this, "physical_table_map_id");
        set => SetArgument("physical_table_map_id", value);
    }

    /// <summary>
    /// CustomSql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSql block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlock>? CustomSql
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlock>>("custom_sql");
        set => SetArgument("custom_sql", value);
    }

    /// <summary>
    /// RelationalTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RelationalTable block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlock>? RelationalTable
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlock>>("relational_table");
        set => SetArgument("relational_table", value);
    }

    /// <summary>
    /// S3Source block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Source block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlock>? S3Source
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlock>>("s3_source");
        set => SetArgument("s3_source", value);
    }

}

/// <summary>
/// Block type for custom_sql in AwsQuicksightDataSetPhysicalTableMapBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_sql";

    /// <summary>
    /// The data_source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceArn is required")]
    public required TerraformValue<string> DataSourceArn
    {
        get => new TerraformReference<string>(this, "data_source_arn");
        set => SetArgument("data_source_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sql_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlQuery is required")]
    public required TerraformValue<string> SqlQuery
    {
        get => new TerraformReference<string>(this, "sql_query");
        set => SetArgument("sql_query", value);
    }

    /// <summary>
    /// Columns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2048, ErrorMessage = "Maximum 2048 Columns block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlockColumnsBlock>? Columns
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlockColumnsBlock>>("columns");
        set => SetArgument("columns", value);
    }

}

/// <summary>
/// Block type for columns in AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockCustomSqlBlockColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "columns";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for relational_table in AwsQuicksightDataSetPhysicalTableMapBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "relational_table";

    /// <summary>
    /// The catalog attribute.
    /// </summary>
    public TerraformValue<string>? Catalog
    {
        get => new TerraformReference<string>(this, "catalog");
        set => SetArgument("catalog", value);
    }

    /// <summary>
    /// The data_source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceArn is required")]
    public required TerraformValue<string> DataSourceArn
    {
        get => new TerraformReference<string>(this, "data_source_arn");
        set => SetArgument("data_source_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string>? Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// InputColumns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputColumns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputColumns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2048, ErrorMessage = "Maximum 2048 InputColumns block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlockInputColumnsBlock> InputColumns
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlockInputColumnsBlock>>("input_columns");
        set => SetArgument("input_columns", value);
    }

}

/// <summary>
/// Block type for input_columns in AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockRelationalTableBlockInputColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_columns";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for s3_source in AwsQuicksightDataSetPhysicalTableMapBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_source";

    /// <summary>
    /// The data_source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceArn is required")]
    public required TerraformValue<string> DataSourceArn
    {
        get => new TerraformReference<string>(this, "data_source_arn");
        set => SetArgument("data_source_arn", value);
    }

    /// <summary>
    /// InputColumns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputColumns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputColumns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2048, ErrorMessage = "Maximum 2048 InputColumns block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockInputColumnsBlock> InputColumns
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockInputColumnsBlock>>("input_columns");
        set => SetArgument("input_columns", value);
    }

    /// <summary>
    /// UploadSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UploadSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UploadSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UploadSettings block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockUploadSettingsBlock> UploadSettings
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockUploadSettingsBlock>>("upload_settings");
        set => SetArgument("upload_settings", value);
    }

}

/// <summary>
/// Block type for input_columns in AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockInputColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_columns";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for upload_settings in AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlockS3SourceBlockUploadSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upload_settings";

    /// <summary>
    /// The contains_header attribute.
    /// </summary>
    public TerraformValue<bool> ContainsHeader
    {
        get => new TerraformReference<bool>(this, "contains_header");
        set => SetArgument("contains_header", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformValue<string> Delimiter
    {
        get => new TerraformReference<string>(this, "delimiter");
        set => SetArgument("delimiter", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The start_from_row attribute.
    /// </summary>
    public TerraformValue<double> StartFromRow
    {
        get => new TerraformReference<double>(this, "start_from_row");
        set => SetArgument("start_from_row", value);
    }

    /// <summary>
    /// The text_qualifier attribute.
    /// </summary>
    public TerraformValue<string> TextQualifier
    {
        get => new TerraformReference<string>(this, "text_qualifier");
        set => SetArgument("text_qualifier", value);
    }

}


/// <summary>
/// Block type for refresh_properties in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "refresh_properties";

    /// <summary>
    /// RefreshConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RefreshConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshConfiguration block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlock> RefreshConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlock>>("refresh_configuration");
        set => SetArgument("refresh_configuration", value);
    }

}

/// <summary>
/// Block type for refresh_configuration in AwsQuicksightDataSetRefreshPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "refresh_configuration";

    /// <summary>
    /// IncrementalRefresh block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncrementalRefresh is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncrementalRefresh block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalRefresh block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlock> IncrementalRefresh
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlock>>("incremental_refresh");
        set => SetArgument("incremental_refresh", value);
    }

}

/// <summary>
/// Block type for incremental_refresh in AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incremental_refresh";

    /// <summary>
    /// LookbackWindow block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LookbackWindow is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LookbackWindow block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LookbackWindow block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlockLookbackWindowBlock> LookbackWindow
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlockLookbackWindowBlock>>("lookback_window");
        set => SetArgument("lookback_window", value);
    }

}

/// <summary>
/// Block type for lookback_window in AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlockRefreshConfigurationBlockIncrementalRefreshBlockLookbackWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lookback_window";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The size_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeUnit is required")]
    public required TerraformValue<string> SizeUnit
    {
        get => new TerraformReference<string>(this, "size_unit");
        set => SetArgument("size_unit", value);
    }

}


/// <summary>
/// Block type for row_level_permission_data_set in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionDataSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "row_level_permission_data_set";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    public TerraformValue<string>? FormatVersion
    {
        get => new TerraformReference<string>(this, "format_version");
        set => SetArgument("format_version", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The permission_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionPolicy is required")]
    public required TerraformValue<string> PermissionPolicy
    {
        get => new TerraformReference<string>(this, "permission_policy");
        set => SetArgument("permission_policy", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Block type for row_level_permission_tag_configuration in AwsQuicksightDataSet.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "row_level_permission_tag_configuration";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// TagRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TagRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 TagRules block(s) allowed")]
    public required TerraformList<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlockTagRulesBlock> TagRules
    {
        get => GetRequiredArgument<TerraformList<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlockTagRulesBlock>>("tag_rules");
        set => SetArgument("tag_rules", value);
    }

}

/// <summary>
/// Block type for tag_rules in AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlockTagRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_rules";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The match_all_value attribute.
    /// </summary>
    public TerraformValue<string>? MatchAllValue
    {
        get => new TerraformReference<string>(this, "match_all_value");
        set => SetArgument("match_all_value", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformValue<string> TagKey
    {
        get => new TerraformReference<string>(this, "tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The tag_multi_value_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? TagMultiValueDelimiter
    {
        get => new TerraformReference<string>(this, "tag_multi_value_delimiter");
        set => SetArgument("tag_multi_value_delimiter", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_data_set Terraform resource.
/// Manages a aws_quicksight_data_set resource.
/// </summary>
public partial class AwsQuicksightDataSet(string name) : TerraformResource("aws_quicksight_data_set", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => new TerraformReference<string>(this, "data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMode is required")]
    public required TerraformValue<string> ImportMode
    {
        get => new TerraformReference<string>(this, "import_mode");
        set => SetArgument("import_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The output_columns attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutputColumns
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "output_columns").ResolveNodes(ctx));
    }

    /// <summary>
    /// ColumnGroups block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 ColumnGroups block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetColumnGroupsBlock>? ColumnGroups
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetColumnGroupsBlock>>("column_groups");
        set => SetArgument("column_groups", value);
    }

    /// <summary>
    /// ColumnLevelPermissionRules block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>? ColumnLevelPermissionRules
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>>("column_level_permission_rules");
        set => SetArgument("column_level_permission_rules", value);
    }

    /// <summary>
    /// DataSetUsageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSetUsageConfiguration block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetDataSetUsageConfigurationBlock>? DataSetUsageConfiguration
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetDataSetUsageConfigurationBlock>>("data_set_usage_configuration");
        set => SetArgument("data_set_usage_configuration", value);
    }

    /// <summary>
    /// FieldFolders block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FieldFolders block(s) allowed")]
    public TerraformSet<AwsQuicksightDataSetFieldFoldersBlock>? FieldFolders
    {
        get => GetArgument<TerraformSet<AwsQuicksightDataSetFieldFoldersBlock>>("field_folders");
        set => SetArgument("field_folders", value);
    }

    /// <summary>
    /// LogicalTableMap block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 LogicalTableMap block(s) allowed")]
    public TerraformSet<AwsQuicksightDataSetLogicalTableMapBlock>? LogicalTableMap
    {
        get => GetArgument<TerraformSet<AwsQuicksightDataSetLogicalTableMapBlock>>("logical_table_map");
        set => SetArgument("logical_table_map", value);
    }

    /// <summary>
    /// Permissions block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    public TerraformSet<AwsQuicksightDataSetPermissionsBlock>? Permissions
    {
        get => GetArgument<TerraformSet<AwsQuicksightDataSetPermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// PhysicalTableMap block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(32, ErrorMessage = "Maximum 32 PhysicalTableMap block(s) allowed")]
    public TerraformSet<AwsQuicksightDataSetPhysicalTableMapBlock>? PhysicalTableMap
    {
        get => GetArgument<TerraformSet<AwsQuicksightDataSetPhysicalTableMapBlock>>("physical_table_map");
        set => SetArgument("physical_table_map", value);
    }

    /// <summary>
    /// RefreshProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshProperties block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetRefreshPropertiesBlock>? RefreshProperties
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetRefreshPropertiesBlock>>("refresh_properties");
        set => SetArgument("refresh_properties", value);
    }

    /// <summary>
    /// RowLevelPermissionDataSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionDataSet block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>? RowLevelPermissionDataSet
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>>("row_level_permission_data_set");
        set => SetArgument("row_level_permission_data_set", value);
    }

    /// <summary>
    /// RowLevelPermissionTagConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionTagConfiguration block(s) allowed")]
    public TerraformList<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>? RowLevelPermissionTagConfiguration
    {
        get => GetArgument<TerraformList<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>>("row_level_permission_tag_configuration");
        set => SetArgument("row_level_permission_tag_configuration", value);
    }

}
