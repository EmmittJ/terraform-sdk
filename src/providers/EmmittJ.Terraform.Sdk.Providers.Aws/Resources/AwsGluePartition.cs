using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionStorageDescriptorBlock : ITerraformBlock
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
/// Manages a aws_glue_partition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGluePartition : TerraformResource
{
    public AwsGluePartition(string name) : base("aws_glue_partition", name)
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
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionValues is required")]
    [TerraformPropertyName("partition_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PartitionValues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    [TerraformPropertyName("storage_descriptor")]
    public TerraformList<TerraformBlock<AwsGluePartitionStorageDescriptorBlock>>? StorageDescriptor { get; set; } = new();

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The last_accessed_time attribute.
    /// </summary>
    [TerraformPropertyName("last_accessed_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastAccessedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_accessed_time");

    /// <summary>
    /// The last_analyzed_time attribute.
    /// </summary>
    [TerraformPropertyName("last_analyzed_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastAnalyzedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_analyzed_time");

}
