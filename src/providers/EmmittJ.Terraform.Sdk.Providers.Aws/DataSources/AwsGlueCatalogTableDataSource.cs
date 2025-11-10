using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_catalog_table.
/// </summary>
public class AwsGlueCatalogTableDataSource : TerraformDataSource
{
    public AwsGlueCatalogTableDataSource(string name) : base("aws_glue_catalog_table", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "catalog_id");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    [TerraformPropertyName("query_as_of_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryAsOfTime { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    [TerraformPropertyName("transaction_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TransactionId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    [TerraformPropertyName("partition_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PartitionIndex => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "partition_index");

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    [TerraformPropertyName("partition_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PartitionKeys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "partition_keys");

    /// <summary>
    /// The retention attribute.
    /// </summary>
    [TerraformPropertyName("retention")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Retention => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention");

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    [TerraformPropertyName("storage_descriptor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageDescriptor => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_descriptor");

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    [TerraformPropertyName("table_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TableType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "table_type");

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    [TerraformPropertyName("target_table")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TargetTable => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "target_table");

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    [TerraformPropertyName("view_expanded_text")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ViewExpandedText => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "view_expanded_text");

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    [TerraformPropertyName("view_original_text")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ViewOriginalText => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "view_original_text");

}
