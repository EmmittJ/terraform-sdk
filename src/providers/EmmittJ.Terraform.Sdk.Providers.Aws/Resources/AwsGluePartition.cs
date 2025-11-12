using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_descriptor in .
/// Nesting mode: list
/// </summary>
public partial class AwsGluePartitionStorageDescriptorBlock() : TerraformBlock("storage_descriptor")
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
/// Manages a aws_glue_partition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGluePartition : TerraformResource
{
    public AwsGluePartition(string name) : base("aws_glue_partition", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The partition_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionValues is required")]
    [TerraformProperty("partition_values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PartitionValues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// Block for storage_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    [TerraformProperty("storage_descriptor")]
    public TerraformList<AwsGluePartitionStorageDescriptorBlock> StorageDescriptor { get; set; } = new();

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The last_accessed_time attribute.
    /// </summary>
    [TerraformProperty("last_accessed_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastAccessedTime { get; }

    /// <summary>
    /// The last_analyzed_time attribute.
    /// </summary>
    [TerraformProperty("last_analyzed_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastAnalyzedTime { get; }

}
