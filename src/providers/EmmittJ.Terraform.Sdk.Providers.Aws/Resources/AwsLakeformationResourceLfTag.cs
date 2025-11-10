using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for lf_tag in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagLfTagBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for table in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagTableBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    public TerraformProperty<bool>? Wildcard
    {
        get => GetProperty<TerraformProperty<bool>>("wildcard");
        set => WithProperty("wildcard", value);
    }

}

/// <summary>
/// Block type for table_with_columns in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagTableWithColumnsBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ColumnNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("column_names");
        set => WithProperty("column_names", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLakeformationResourceLfTagTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_lakeformation_resource_lf_tag resource.
/// </summary>
public class AwsLakeformationResourceLfTag : TerraformResource
{
    public AwsLakeformationResourceLfTag(string name) : base("aws_lakeformation_resource_lf_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationResourceLfTagDatabaseBlock>? Database
    {
        get => GetProperty<List<AwsLakeformationResourceLfTagDatabaseBlock>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// Block for lf_tag.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationResourceLfTagLfTagBlock>? LfTag
    {
        get => GetProperty<List<AwsLakeformationResourceLfTagLfTagBlock>>("lf_tag");
        set => this.WithProperty("lf_tag", value);
    }

    /// <summary>
    /// Block for table.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationResourceLfTagTableBlock>? Table
    {
        get => GetProperty<List<AwsLakeformationResourceLfTagTableBlock>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// Block for table_with_columns.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLakeformationResourceLfTagTableWithColumnsBlock>? TableWithColumns
    {
        get => GetProperty<List<AwsLakeformationResourceLfTagTableWithColumnsBlock>>("table_with_columns");
        set => this.WithProperty("table_with_columns", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLakeformationResourceLfTagTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLakeformationResourceLfTagTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
