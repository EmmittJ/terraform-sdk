using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for magnetic_store_write_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock
{
    /// <summary>
    /// The enable_magnetic_store_writes attribute.
    /// </summary>
    [TerraformPropertyName("enable_magnetic_store_writes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableMagneticStoreWrites { get; set; }

}

/// <summary>
/// Block type for retention_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableRetentionPropertiesBlock
{
    /// <summary>
    /// The magnetic_store_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MagneticStoreRetentionPeriodInDays is required")]
    [TerraformPropertyName("magnetic_store_retention_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MagneticStoreRetentionPeriodInDays { get; set; }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    [TerraformPropertyName("memory_store_retention_period_in_hours")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MemoryStoreRetentionPeriodInHours { get; set; }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableSchemaBlock
{
}

/// <summary>
/// Manages a aws_timestreamwrite_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTimestreamwriteTable : TerraformResource
{
    public AwsTimestreamwriteTable(string name) : base("aws_timestreamwrite_table", name)
    {
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for magnetic_store_write_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    [TerraformPropertyName("magnetic_store_write_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>>? MagneticStoreWriteProperties { get; set; }

    /// <summary>
    /// Block for retention_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    [TerraformPropertyName("retention_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableRetentionPropertiesBlock>>? RetentionProperties { get; set; }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformPropertyName("schema")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableSchemaBlock>>? Schema { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
