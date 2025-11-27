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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    public TerraformValue<bool>? Wildcard
    {
        get => new TerraformReference<bool>(this, "wildcard");
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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public TerraformSet<string>? ColumnNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "column_names").ResolveNodes(ctx));
        set => SetArgument("column_names", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The excluded_column_names attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedColumnNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_column_names").ResolveNodes(ctx));
        set => SetArgument("excluded_column_names", value);
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
    /// The wildcard attribute.
    /// </summary>
    public TerraformValue<bool>? Wildcard
    {
        get => new TerraformReference<bool>(this, "wildcard");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
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
