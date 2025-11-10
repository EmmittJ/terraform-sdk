using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for open_table_format_input in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOpenTableFormatInputBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for partition_index in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionIndexBlock : ITerraformBlock
{
    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformPropertyName("index_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IndexName { get; set; }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    [TerraformPropertyName("index_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IndexStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "index_status");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    [TerraformPropertyName("keys")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Keys { get; set; }

}

/// <summary>
/// Block type for partition_keys in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTablePartitionKeysBlock : ITerraformBlock
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableStorageDescriptorBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_locations attribute.
    /// </summary>
    [TerraformPropertyName("additional_locations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdditionalLocations { get; set; }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    [TerraformPropertyName("bucket_columns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? BucketColumns { get; set; }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    [TerraformPropertyName("compressed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Compressed { get; set; }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [TerraformPropertyName("input_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InputFormat { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfBuckets { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [TerraformPropertyName("output_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputFormat { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    [TerraformPropertyName("stored_as_sub_directories")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StoredAsSubDirectories { get; set; }

}

/// <summary>
/// Block type for target_table in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableTargetTableBlock : ITerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    [TerraformPropertyName("catalog_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CatalogId { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

}

/// <summary>
/// Manages a aws_glue_catalog_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueCatalogTable : TerraformResource
{
    public AwsGlueCatalogTable(string name) : base("aws_glue_catalog_table", name)
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
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Owner { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retention attribute.
    /// </summary>
    [TerraformPropertyName("retention")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Retention { get; set; }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    [TerraformPropertyName("table_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TableType { get; set; }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    [TerraformPropertyName("view_expanded_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ViewExpandedText { get; set; }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    [TerraformPropertyName("view_original_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ViewOriginalText { get; set; }

    /// <summary>
    /// Block for open_table_format_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenTableFormatInput block(s) allowed")]
    [TerraformPropertyName("open_table_format_input")]
    public TerraformList<TerraformBlock<AwsGlueCatalogTableOpenTableFormatInputBlock>>? OpenTableFormatInput { get; set; } = new();

    /// <summary>
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PartitionIndex block(s) allowed")]
    [TerraformPropertyName("partition_index")]
    public TerraformList<TerraformBlock<AwsGlueCatalogTablePartitionIndexBlock>>? PartitionIndex { get; set; } = new();

    /// <summary>
    /// Block for partition_keys.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("partition_keys")]
    public TerraformList<TerraformBlock<AwsGlueCatalogTablePartitionKeysBlock>>? PartitionKeys { get; set; } = new();

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    [TerraformPropertyName("storage_descriptor")]
    public TerraformList<TerraformBlock<AwsGlueCatalogTableStorageDescriptorBlock>>? StorageDescriptor { get; set; } = new();

    /// <summary>
    /// Block for target_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    [TerraformPropertyName("target_table")]
    public TerraformList<TerraformBlock<AwsGlueCatalogTableTargetTableBlock>>? TargetTable { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
