using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_table_default_permission in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock : TerraformBlockBase
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Permissions { get; set; }

}

/// <summary>
/// Block type for federated_database in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogDatabaseFederatedDatabaseBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Identifier { get; set; }

}

/// <summary>
/// Block type for target_database in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogDatabaseTargetDatabaseBlock : TerraformBlockBase
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformProperty("catalog_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

}

/// <summary>
/// Manages a aws_glue_catalog_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueCatalogDatabase : TerraformResource
{
    public AwsGlueCatalogDatabase(string name) : base("aws_glue_catalog_database", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    [TerraformProperty("location_uri")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LocationUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for create_table_default_permission.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("create_table_default_permission")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>>? CreateTableDefaultPermission { get; set; }

    /// <summary>
    /// Block for federated_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FederatedDatabase block(s) allowed")]
    [TerraformProperty("federated_database")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogDatabaseFederatedDatabaseBlock>>? FederatedDatabase { get; set; }

    /// <summary>
    /// Block for target_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetDatabase block(s) allowed")]
    [TerraformProperty("target_database")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogDatabaseTargetDatabaseBlock>>? TargetDatabase { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
