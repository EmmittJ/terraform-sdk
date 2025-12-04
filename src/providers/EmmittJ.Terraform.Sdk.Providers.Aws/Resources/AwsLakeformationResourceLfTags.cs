using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for database in AwsLakeformationResourceLfTags.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsDatabaseBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for lf_tag in AwsLakeformationResourceLfTags.
/// Nesting mode: set
/// </summary>
public class AwsLakeformationResourceLfTagsLfTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lf_tag";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for table in AwsLakeformationResourceLfTags.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsTableBlock : TerraformBlock
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
    /// The wildcard attribute.
    /// </summary>
    public TerraformValue<bool>? Wildcard
    {
        get => GetArgument<TerraformValue<bool>>("wildcard");
        set => SetArgument("wildcard", value);
    }

}


/// <summary>
/// Block type for table_with_columns in AwsLakeformationResourceLfTags.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsTableWithColumnsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("database_name");
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
/// Block type for timeouts in AwsLakeformationResourceLfTags.
/// Nesting mode: single
/// </summary>
public class AwsLakeformationResourceLfTagsTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_lakeformation_resource_lf_tags Terraform resource.
/// Manages a aws_lakeformation_resource_lf_tags resource.
/// </summary>
public partial class AwsLakeformationResourceLfTags(string name) : TerraformResource("aws_lakeformation_resource_lf_tags", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    public TerraformList<AwsLakeformationResourceLfTagsDatabaseBlock>? Database
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagsDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// LfTag block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LfTag is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LfTag block(s) required")]
    public required TerraformSet<AwsLakeformationResourceLfTagsLfTagBlock> LfTag
    {
        get => GetRequiredArgument<TerraformSet<AwsLakeformationResourceLfTagsLfTagBlock>>("lf_tag");
        set => SetArgument("lf_tag", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public TerraformList<AwsLakeformationResourceLfTagsTableBlock>? Table
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagsTableBlock>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// TableWithColumns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableWithColumns block(s) allowed")]
    public TerraformList<AwsLakeformationResourceLfTagsTableWithColumnsBlock>? TableWithColumns
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagsTableWithColumnsBlock>>("table_with_columns");
        set => SetArgument("table_with_columns", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLakeformationResourceLfTagsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLakeformationResourceLfTagsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
