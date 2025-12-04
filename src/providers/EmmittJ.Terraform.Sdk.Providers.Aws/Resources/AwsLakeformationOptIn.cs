using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in AwsLakeformationOptIn.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string> Expression
        => AsReference("expression");

}


/// <summary>
/// Block type for principal in AwsLakeformationOptIn.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal";

    /// <summary>
    /// The data_lake_principal_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLakePrincipalIdentifier is required")]
    public required TerraformValue<string> DataLakePrincipalIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_lake_principal_identifier");
        set => SetArgument("data_lake_principal_identifier", value);
    }

}


/// <summary>
/// Block type for resource_data in AwsLakeformationOptIn.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_data";

    /// <summary>
    /// Catalog block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockCatalogBlock>? Catalog
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockCatalogBlock>>("catalog");
        set => SetArgument("catalog", value);
    }

    /// <summary>
    /// DataCellsFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockDataCellsFilterBlock>? DataCellsFilter
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockDataCellsFilterBlock>>("data_cells_filter");
        set => SetArgument("data_cells_filter", value);
    }

    /// <summary>
    /// DataLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockDataLocationBlock>? DataLocation
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockDataLocationBlock>>("data_location");
        set => SetArgument("data_location", value);
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockDatabaseBlock>? Database
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// LfTag block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockLfTagBlock>? LfTag
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockLfTagBlock>>("lf_tag");
        set => SetArgument("lf_tag", value);
    }

    /// <summary>
    /// LfTagExpression block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockLfTagExpressionBlock>? LfTagExpression
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockLfTagExpressionBlock>>("lf_tag_expression");
        set => SetArgument("lf_tag_expression", value);
    }

    /// <summary>
    /// LfTagPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockLfTagPolicyBlock>? LfTagPolicy
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockLfTagPolicyBlock>>("lf_tag_policy");
        set => SetArgument("lf_tag_policy", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockTableBlock>? Table
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockTableBlock>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// TableWithColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockTableWithColumnsBlock>? TableWithColumns
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockTableWithColumnsBlock>>("table_with_columns");
        set => SetArgument("table_with_columns", value);
    }

}

/// <summary>
/// Block type for catalog in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockCatalogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for data_cells_filter in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockDataCellsFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_cells_filter";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The table_catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? TableCatalogId
    {
        get => GetArgument<TerraformValue<string>>("table_catalog_id");
        set => SetArgument("table_catalog_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string>? TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

}

/// <summary>
/// Block type for data_location in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockDataLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_location";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for database in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
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

}

/// <summary>
/// Block type for lf_tag in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockLfTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lf_tag";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for lf_tag_expression in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockLfTagExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lf_tag_expression";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
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

}

/// <summary>
/// Block type for lf_tag_policy in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockLfTagPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lf_tag_policy";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformList<string>? Expression
    {
        get => GetArgument<TerraformList<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The expression_name attribute.
    /// </summary>
    public TerraformValue<string>? ExpressionName
    {
        get => GetArgument<TerraformValue<string>>("expression_name");
        set => SetArgument("expression_name", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

}

/// <summary>
/// Block type for table in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
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
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    public TerraformValue<bool>? Wildcard
    {
        get => GetArgument<TerraformValue<bool>>("wildcard");
        set => SetArgument("wildcard", value);
    }

}

/// <summary>
/// Block type for table_with_columns in AwsLakeformationOptInResourceDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockTableWithColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_with_columns";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public TerraformSet<string>? ColumnNames
    {
        get => GetArgument<TerraformSet<string>>("column_names");
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
    /// ColumnWildcard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlockTableWithColumnsBlockColumnWildcardBlock>? ColumnWildcard
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlockTableWithColumnsBlockColumnWildcardBlock>>("column_wildcard");
        set => SetArgument("column_wildcard", value);
    }

}

/// <summary>
/// Block type for column_wildcard in AwsLakeformationOptInResourceDataBlockTableWithColumnsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlockTableWithColumnsBlockColumnWildcardBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_wildcard";

    /// <summary>
    /// The excluded_column_names attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedColumnNames
    {
        get => GetArgument<TerraformSet<string>>("excluded_column_names");
        set => SetArgument("excluded_column_names", value);
    }

}


/// <summary>
/// Represents a aws_lakeformation_opt_in Terraform resource.
/// Manages a aws_lakeformation_opt_in resource.
/// </summary>
public partial class AwsLakeformationOptIn(string name) : TerraformResource("aws_lakeformation_opt_in", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => AsReference("last_modified");

    /// <summary>
    /// The last_updated_by attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedBy
        => AsReference("last_updated_by");

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Principal block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInPrincipalBlock>? Principal
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInPrincipalBlock>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// ResourceData block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationOptInResourceDataBlock>? ResourceData
    {
        get => GetArgument<TerraformList<AwsLakeformationOptInResourceDataBlock>>("resource_data");
        set => SetArgument("resource_data", value);
    }

}
