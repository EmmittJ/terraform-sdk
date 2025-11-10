using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsDatabaseBlock : ITerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "catalog_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for lf_tag in .
/// Nesting mode: set
/// </summary>
public class AwsLakeformationResourceLfTagsLfTagBlock : ITerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "catalog_id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for table in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsTableBlock : ITerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "catalog_id");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "name");

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    [TerraformPropertyName("wildcard")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Wildcard { get; set; }

}

/// <summary>
/// Block type for table_with_columns in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationResourceLfTagsTableWithColumnsBlock : ITerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "catalog_id");

    /// <summary>
    /// The column_names attribute.
    /// </summary>
    [TerraformPropertyName("column_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ColumnNames { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The excluded_column_names attribute.
    /// </summary>
    [TerraformPropertyName("excluded_column_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludedColumnNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The wildcard attribute.
    /// </summary>
    [TerraformPropertyName("wildcard")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Wildcard { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLakeformationResourceLfTagsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_lakeformation_resource_lf_tags resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLakeformationResourceLfTags : TerraformResource
{
    public AwsLakeformationResourceLfTags(string name) : base("aws_lakeformation_resource_lf_tags", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "catalog_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Database block(s) allowed")]
    [TerraformPropertyName("database")]
    public TerraformList<TerraformBlock<AwsLakeformationResourceLfTagsDatabaseBlock>>? Database { get; set; } = new();

    /// <summary>
    /// Block for lf_tag.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LfTag is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LfTag block(s) required")]
    [TerraformPropertyName("lf_tag")]
    public TerraformSet<TerraformBlock<AwsLakeformationResourceLfTagsLfTagBlock>>? LfTag { get; set; } = new();

    /// <summary>
    /// Block for table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Table block(s) allowed")]
    [TerraformPropertyName("table")]
    public TerraformList<TerraformBlock<AwsLakeformationResourceLfTagsTableBlock>>? Table { get; set; } = new();

    /// <summary>
    /// Block for table_with_columns.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableWithColumns block(s) allowed")]
    [TerraformPropertyName("table_with_columns")]
    public TerraformList<TerraformBlock<AwsLakeformationResourceLfTagsTableWithColumnsBlock>>? TableWithColumns { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLakeformationResourceLfTagsTimeoutsBlock>? Timeouts { get; set; } = new();

}
