using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_s3tables_table resource.
/// </summary>
public class AwsS3tablesTable : TerraformResource
{
    public AwsS3tablesTable(string name) : base("aws_s3tables_table", name)
    {
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<object>> EncryptionConfiguration { get; set; } = new TerraformReferenceProperty<TerraformProperty<object>>(ResourceAddress, "encryption_configuration");

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Format { get; set; }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_configuration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<object>> MaintenanceConfiguration { get; set; } = new TerraformReferenceProperty<TerraformProperty<object>>(ResourceAddress, "maintenance_configuration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    [TerraformPropertyName("table_bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableBucketArn { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("metadata")]
    public TerraformList<TerraformBlock<AwsS3tablesTableMetadataBlock>>? Metadata { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_by");

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    [TerraformPropertyName("metadata_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MetadataLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metadata_location");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformPropertyName("modified_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModifiedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modified_at");

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    [TerraformPropertyName("modified_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModifiedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modified_by");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_account_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    [TerraformPropertyName("version_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_token");

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    [TerraformPropertyName("warehouse_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WarehouseLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "warehouse_location");

}
