using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for open_table_format_input in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogTableOpenTableFormatInputBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for partition_index in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogTablePartitionIndexBlock : TerraformBlockBase
{
    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    [TerraformProperty("index_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexName { get; set; }


    /// <summary>
    /// The keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keys is required")]
    [TerraformProperty("keys")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Keys { get; set; }

}

/// <summary>
/// Block type for partition_keys in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogTablePartitionKeysBlock : TerraformBlockBase
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

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
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogTableStorageDescriptorBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_locations attribute.
    /// </summary>
    [TerraformProperty("additional_locations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdditionalLocations { get; set; }

    /// <summary>
    /// The bucket_columns attribute.
    /// </summary>
    [TerraformProperty("bucket_columns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? BucketColumns { get; set; }

    /// <summary>
    /// The compressed attribute.
    /// </summary>
    [TerraformProperty("compressed")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Compressed { get; set; }

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    [TerraformProperty("input_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InputFormat { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The number_of_buckets attribute.
    /// </summary>
    [TerraformProperty("number_of_buckets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfBuckets { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [TerraformProperty("output_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutputFormat { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The stored_as_sub_directories attribute.
    /// </summary>
    [TerraformProperty("stored_as_sub_directories")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StoredAsSubDirectories { get; set; }

}

/// <summary>
/// Block type for target_table in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCatalogTableTargetTableBlock : TerraformBlockBase
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

}

/// <summary>
/// Manages a aws_glue_catalog_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueCatalogTable : TerraformResource
{
    public AwsGlueCatalogTable(string name) : base("aws_glue_catalog_table", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Owner { get; set; }

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
    /// The retention attribute.
    /// </summary>
    [TerraformProperty("retention")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Retention { get; set; }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    [TerraformProperty("table_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableType { get; set; }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    [TerraformProperty("view_expanded_text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ViewExpandedText { get; set; }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    [TerraformProperty("view_original_text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ViewOriginalText { get; set; }

    /// <summary>
    /// Block for open_table_format_input.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenTableFormatInput block(s) allowed")]
    [TerraformProperty("open_table_format_input")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogTableOpenTableFormatInputBlock>>? OpenTableFormatInput { get; set; }

    /// <summary>
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PartitionIndex block(s) allowed")]
    [TerraformProperty("partition_index")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogTablePartitionIndexBlock>>? PartitionIndex { get; set; }

    /// <summary>
    /// Block for partition_keys.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("partition_keys")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogTablePartitionKeysBlock>>? PartitionKeys { get; set; }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    [TerraformProperty("storage_descriptor")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogTableStorageDescriptorBlock>>? StorageDescriptor { get; set; }

    /// <summary>
    /// Block for target_table.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTable block(s) allowed")]
    [TerraformProperty("target_table")]
    public partial TerraformList<TerraformBlock<AwsGlueCatalogTableTargetTableBlock>>? TargetTable { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
