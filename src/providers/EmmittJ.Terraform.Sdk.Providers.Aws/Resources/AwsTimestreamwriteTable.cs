using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for magnetic_store_write_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_magnetic_store_writes attribute.
    /// </summary>
    [TerraformPropertyName("enable_magnetic_store_writes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableMagneticStoreWrites { get; set; }

}

/// <summary>
/// Block type for retention_properties in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableRetentionPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The magnetic_store_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MagneticStoreRetentionPeriodInDays is required")]
    [TerraformPropertyName("magnetic_store_retention_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MagneticStoreRetentionPeriodInDays { get; set; }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    [TerraformPropertyName("memory_store_retention_period_in_hours")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MemoryStoreRetentionPeriodInHours { get; set; }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableSchemaBlock : ITerraformBlock
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for magnetic_store_write_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    [TerraformPropertyName("magnetic_store_write_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>>? MagneticStoreWriteProperties { get; set; } = new();

    /// <summary>
    /// Block for retention_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    [TerraformPropertyName("retention_properties")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableRetentionPropertiesBlock>>? RetentionProperties { get; set; } = new();

    /// <summary>
    /// Block for schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    [TerraformPropertyName("schema")]
    public TerraformList<TerraformBlock<AwsTimestreamwriteTableSchemaBlock>>? Schema { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
