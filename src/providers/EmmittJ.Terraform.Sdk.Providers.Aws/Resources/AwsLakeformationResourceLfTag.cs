using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for database in AwsLakeformationResourceLfTag.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagDatabaseBlock : TerraformBlock
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
/// Block type for lf_tag in AwsLakeformationResourceLfTag.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagLfTagBlock : TerraformBlock
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
/// Block type for table in AwsLakeformationResourceLfTag.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagTableBlock : TerraformBlock
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
    public TerraformValue<string>? Name
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
/// Block type for table_with_columns in AwsLakeformationResourceLfTag.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagTableWithColumnsBlock : TerraformBlock
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ColumnWildcard block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationResourceLfTagTableWithColumnsBlockColumnWildcardBlock>? ColumnWildcard
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagTableWithColumnsBlockColumnWildcardBlock>>("column_wildcard");
        set => SetArgument("column_wildcard", value);
    }

}

/// <summary>
/// Block type for column_wildcard in AwsLakeformationResourceLfTagTableWithColumnsBlock.
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagTableWithColumnsBlockColumnWildcardBlock : TerraformBlock
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_column_names").ResolveNodes(ctx));
        set => SetArgument("excluded_column_names", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLakeformationResourceLfTag.
/// Nesting mode: single
/// </summary>
public class AwsLakeformationResourceLfTagTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_lakeformation_resource_lf_tag Terraform resource.
/// Manages a aws_lakeformation_resource_lf_tag resource.
/// </summary>
public partial class AwsLakeformationResourceLfTag(string name) : TerraformResource("aws_lakeformation_resource_lf_tag", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string>? CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationResourceLfTagDatabaseBlock>? Database
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// LfTag block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationResourceLfTagLfTagBlock>? LfTag
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagLfTagBlock>>("lf_tag");
        set => SetArgument("lf_tag", value);
    }

    /// <summary>
    /// Table block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationResourceLfTagTableBlock>? Table
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagTableBlock>>("table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// TableWithColumns block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLakeformationResourceLfTagTableWithColumnsBlock>? TableWithColumns
    {
        get => GetArgument<TerraformList<AwsLakeformationResourceLfTagTableWithColumnsBlock>>("table_with_columns");
        set => SetArgument("table_with_columns", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLakeformationResourceLfTagTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLakeformationResourceLfTagTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
