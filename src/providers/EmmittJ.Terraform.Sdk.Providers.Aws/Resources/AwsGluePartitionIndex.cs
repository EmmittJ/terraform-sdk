using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for partition_index in .
/// Nesting mode: list
/// </summary>
public class AwsGluePartitionIndexPartitionIndexBlock : ITerraformBlock
{
    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [TerraformPropertyName("index_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IndexName { get; set; }

    /// <summary>
    /// The index_status attribute.
    /// </summary>
    [TerraformPropertyName("index_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IndexStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "index_status");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [TerraformPropertyName("keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Keys { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGluePartitionIndexTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_glue_partition_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGluePartitionIndex : TerraformResource
{
    public AwsGluePartitionIndex(string name) : base("aws_glue_partition_index", name)
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
    /// Block for partition_index.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionIndex is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartitionIndex block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionIndex block(s) allowed")]
    [TerraformPropertyName("partition_index")]
    public TerraformList<TerraformBlock<AwsGluePartitionIndexPartitionIndexBlock>>? PartitionIndex { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGluePartitionIndexTimeoutsBlock>? Timeouts { get; set; } = new();

}
