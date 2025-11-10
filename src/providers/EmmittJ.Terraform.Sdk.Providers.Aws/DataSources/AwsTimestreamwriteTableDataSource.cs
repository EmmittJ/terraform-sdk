using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_timestreamwrite_table.
/// </summary>
public class AwsTimestreamwriteTableDataSource : TerraformDataSource
{
    public AwsTimestreamwriteTableDataSource(string name) : base("aws_timestreamwrite_table", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_time");

    /// <summary>
    /// The magnetic_store_write_properties attribute.
    /// </summary>
    [TerraformPropertyName("magnetic_store_write_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MagneticStoreWriteProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "magnetic_store_write_properties");

    /// <summary>
    /// The retention_properties attribute.
    /// </summary>
    [TerraformPropertyName("retention_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RetentionProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "retention_properties");

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Schema => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schema");

    /// <summary>
    /// The table_status attribute.
    /// </summary>
    [TerraformPropertyName("table_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TableStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "table_status");

}
