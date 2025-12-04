using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_cells_filter in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataCellsFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_cells_filter";

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

}


/// <summary>
/// Block type for data_location in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_location";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
    }

}


/// <summary>
/// Block type for database in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
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
/// Block type for lf_tag in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsLfTagBlock : TerraformBlock
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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for lf_tag_policy in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsLfTagPolicyBlock : TerraformBlock
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// Expression block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Expression block(s) required")]
    public required TerraformSet<AwsLakeformationPermissionsLfTagPolicyBlockExpressionBlock> Expression
    {
        get => GetRequiredArgument<TerraformSet<AwsLakeformationPermissionsLfTagPolicyBlockExpressionBlock>>("expression");
        set => SetArgument("expression", value);
    }

}

/// <summary>
/// Block type for expression in AwsLakeformationPermissionsLfTagPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsLakeformationPermissionsLfTagPolicyBlockExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expression";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for table in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
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
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
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
/// Block type for table_with_columns in AwsLakeformationPermissions.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsTableWithColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_with_columns";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
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
    /// The excluded_column_names attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedColumnNames
    {
        get => GetArgument<TerraformSet<string>>("excluded_column_names");
        set => SetArgument("excluded_column_names", value);
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
    /// The wildcard attribute.
    /// </summary>
    public TerraformValue<bool>? Wildcard
    {
        get => GetArgument<TerraformValue<bool>>("wildcard");
        set => SetArgument("wildcard", value);
    }

}


/// <summary>
/// Represents a aws_lakeformation_permissions Terraform resource.
/// Manages a aws_lakeformation_permissions resource.
/// </summary>
public partial class AwsLakeformationPermissions(string name) : TerraformResource("aws_lakeformation_permissions", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The catalog_resource attribute.
    /// </summary>
    public TerraformValue<bool>? CatalogResource
    {
        get => GetArgument<TerraformValue<bool>>("catalog_resource");
        set => SetArgument("catalog_resource", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformSet<string> Permissions
    {
        get => GetRequiredArgument<TerraformSet<string>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public TerraformSet<string> PermissionsWithGrantOption
    {
        get => GetArgument<TerraformSet<string>>("permissions_with_grant_option") ?? AsReference("permissions_with_grant_option");
        set => SetArgument("permissions_with_grant_option", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// DataCellsFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCellsFilter block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsDataCellsFilterBlock>? DataCellsFilter
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsDataCellsFilterBlock>>("data_cells_filter");
        set => SetArgument("data_cells_filter", value);
    }

    /// <summary>
    /// DataLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataLocation block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsDataLocationBlock>? DataLocation
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsDataLocationBlock>>("data_location");
        set => SetArgument("data_location", value);
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsDatabaseBlock>? Database
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// LfTag block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTag block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsLfTagBlock>? LfTag
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsLfTagBlock>>("lf_tag");
        set => SetArgument("lf_tag", value);
    }

    /// <summary>
    /// LfTagPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTagPolicy block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsLfTagPolicyBlock>? LfTagPolicy
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsLfTagPolicyBlock>>("lf_tag_policy");
        set => SetArgument("lf_tag_policy", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsTableBlock>? Table
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsTableBlock>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// TableWithColumns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableWithColumns block(s) allowed")]
    public TerraformList<AwsLakeformationPermissionsTableWithColumnsBlock>? TableWithColumns
    {
        get => GetArgument<TerraformList<AwsLakeformationPermissionsTableWithColumnsBlock>>("table_with_columns");
        set => SetArgument("table_with_columns", value);
    }

}
