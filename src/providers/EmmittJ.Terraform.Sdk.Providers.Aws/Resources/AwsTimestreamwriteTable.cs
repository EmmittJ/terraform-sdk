using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for magnetic_store_write_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_magnetic_store_writes attribute.
    /// </summary>
    [TerraformProperty("enable_magnetic_store_writes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableMagneticStoreWrites { get; set; }

}

/// <summary>
/// Block type for retention_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamwriteTableRetentionPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The magnetic_store_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MagneticStoreRetentionPeriodInDays is required")]
    [TerraformProperty("magnetic_store_retention_period_in_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MagneticStoreRetentionPeriodInDays { get; set; }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    [TerraformProperty("memory_store_retention_period_in_hours")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MemoryStoreRetentionPeriodInHours { get; set; }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public partial class AwsTimestreamwriteTableSchemaBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_timestreamwrite_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsTimestreamwriteTable : TerraformResource
{
    public AwsTimestreamwriteTable(string name) : base("aws_timestreamwrite_table", name)
    {
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for magnetic_store_write_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    [TerraformProperty("magnetic_store_write_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>>? MagneticStoreWriteProperties { get; set; }

    /// <summary>
    /// Block for retention_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    [TerraformProperty("retention_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableRetentionPropertiesBlock>>? RetentionProperties { get; set; }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformProperty("schema")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableSchemaBlock>>? Schema { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
