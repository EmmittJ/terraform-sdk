using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_cells_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsDataCellsFilterBlock() : TerraformBlock("data_cells_filter")
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The table_catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableCatalogId is required")]
    [TerraformProperty("table_catalog_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableCatalogId { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Block type for data_location in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsDataLocationBlock() : TerraformBlock("data_location")
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

}

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsDatabaseBlock() : TerraformBlock("database")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for lf_tag in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsLfTagBlock() : TerraformBlock("lf_tag")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for lf_tag_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsLfTagPolicyBlock() : TerraformBlock("lf_tag_policy")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceType { get; set; }

}

/// <summary>
/// Block type for table in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsTableBlock() : TerraformBlock("table")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    [TerraformProperty("wildcard")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Wildcard { get; set; }

}

/// <summary>
/// Block type for table_with_columns in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationPermissionsTableWithColumnsBlock() : TerraformBlock("table_with_columns")
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    [TerraformProperty("column_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ColumnNames { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The excluded_column_names attribute.
    /// </summary>
    [TerraformProperty("excluded_column_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ExcludedColumnNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    [TerraformProperty("wildcard")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Wildcard { get; set; }

}

/// <summary>
/// Manages a aws_lakeformation_permissions resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLakeformationPermissions : TerraformResource
{
    public AwsLakeformationPermissions(string name) : base("aws_lakeformation_permissions", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The catalog_resource attribute.
    /// </summary>
    [TerraformProperty("catalog_resource")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CatalogResource { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    [TerraformProperty("permissions_with_grant_option")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> PermissionsWithGrantOption { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for data_cells_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCellsFilter block(s) allowed")]
    [TerraformProperty("data_cells_filter")]
    public TerraformList<AwsLakeformationPermissionsDataCellsFilterBlock> DataCellsFilter { get; set; } = new();

    /// <summary>
    /// Block for data_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataLocation block(s) allowed")]
    [TerraformProperty("data_location")]
    public TerraformList<AwsLakeformationPermissionsDataLocationBlock> DataLocation { get; set; } = new();

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    [TerraformProperty("database")]
    public TerraformList<AwsLakeformationPermissionsDatabaseBlock> Database { get; set; } = new();

    /// <summary>
    /// Block for lf_tag.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTag block(s) allowed")]
    [TerraformProperty("lf_tag")]
    public TerraformList<AwsLakeformationPermissionsLfTagBlock> LfTag { get; set; } = new();

    /// <summary>
    /// Block for lf_tag_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LfTagPolicy block(s) allowed")]
    [TerraformProperty("lf_tag_policy")]
    public TerraformList<AwsLakeformationPermissionsLfTagPolicyBlock> LfTagPolicy { get; set; } = new();

    /// <summary>
    /// Block for table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    [TerraformProperty("table")]
    public TerraformList<AwsLakeformationPermissionsTableBlock> Table { get; set; } = new();

    /// <summary>
    /// Block for table_with_columns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableWithColumns block(s) allowed")]
    [TerraformProperty("table_with_columns")]
    public TerraformList<AwsLakeformationPermissionsTableWithColumnsBlock> TableWithColumns { get; set; } = new();

}
