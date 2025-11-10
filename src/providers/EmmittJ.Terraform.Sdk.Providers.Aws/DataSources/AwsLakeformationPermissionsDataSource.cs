using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_cells_filter in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataSourceDataCellsFilterBlock : TerraformBlock
{
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

    /// <summary>
    /// The table_catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableCatalogId is required")]
    public required TerraformProperty<string> TableCatalogId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_catalog_id");
        set => WithProperty("table_catalog_id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_name");
        set => WithProperty("table_name", value);
    }

}

/// <summary>
/// Block type for data_location in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataSourceDataLocationBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

}

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataSourceDatabaseBlock : TerraformBlock
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
public class AwsLakeformationPermissionsDataSourceLfTagBlock : TerraformBlock
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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for lf_tag_policy in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataSourceLfTagPolicyBlock : TerraformBlock
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

}

/// <summary>
/// Block type for table in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationPermissionsDataSourceTableBlock : TerraformBlock
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
public class AwsLakeformationPermissionsDataSourceTableWithColumnsBlock : TerraformBlock
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
    /// The excluded_column_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedColumnNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("excluded_column_names");
        set => WithProperty("excluded_column_names", value);
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
/// Retrieves information about a aws_lakeformation_permissions.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLakeformationPermissionsDataSource : TerraformDataSource
{
    public AwsLakeformationPermissionsDataSource(string name) : base("aws_lakeformation_permissions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("permissions");
        this.WithOutput("permissions_with_grant_option");
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
    /// The catalog_resource attribute.
    /// </summary>
    public TerraformProperty<bool>? CatalogResource
    {
        get => GetProperty<TerraformProperty<bool>>("catalog_resource");
        set => this.WithProperty("catalog_resource", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
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
    /// Block for data_cells_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCellsFilter block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceDataCellsFilterBlock>? DataCellsFilter
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceDataCellsFilterBlock>>("data_cells_filter");
        set => this.WithProperty("data_cells_filter", value);
    }

    /// <summary>
    /// Block for data_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataLocation block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceDataLocationBlock>? DataLocation
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceDataLocationBlock>>("data_location");
        set => this.WithProperty("data_location", value);
    }

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceDatabaseBlock>? Database
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceDatabaseBlock>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// Block for lf_tag.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTag block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceLfTagBlock>? LfTag
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceLfTagBlock>>("lf_tag");
        set => this.WithProperty("lf_tag", value);
    }

    /// <summary>
    /// Block for lf_tag_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTagPolicy block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceLfTagPolicyBlock>? LfTagPolicy
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceLfTagPolicyBlock>>("lf_tag_policy");
        set => this.WithProperty("lf_tag_policy", value);
    }

    /// <summary>
    /// Block for table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceTableBlock>? Table
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceTableBlock>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// Block for table_with_columns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableWithColumns block(s) allowed")]
    public List<AwsLakeformationPermissionsDataSourceTableWithColumnsBlock>? TableWithColumns
    {
        get => GetProperty<List<AwsLakeformationPermissionsDataSourceTableWithColumnsBlock>>("table_with_columns");
        set => this.WithProperty("table_with_columns", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public TerraformExpression PermissionsWithGrantOption => this["permissions_with_grant_option"];

}
