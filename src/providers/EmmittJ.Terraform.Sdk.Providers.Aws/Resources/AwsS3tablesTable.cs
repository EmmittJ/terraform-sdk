using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class AwsS3tablesTableMetadataBlock
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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<object> EncryptionConfiguration { get; set; } = default!;

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_configuration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<object> MaintenanceConfiguration { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformPropertyName("namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    [TerraformPropertyName("table_bucket_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableBucketArn { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("metadata")]
    public TerraformList<TerraformBlock<AwsS3tablesTableMetadataBlock>>? Metadata { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedBy => new TerraformReference(this, "created_by");

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    [TerraformPropertyName("metadata_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MetadataLocation => new TerraformReference(this, "metadata_location");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformPropertyName("modified_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModifiedAt => new TerraformReference(this, "modified_at");

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    [TerraformPropertyName("modified_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModifiedBy => new TerraformReference(this, "modified_by");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAccountId => new TerraformReference(this, "owner_account_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    [TerraformPropertyName("version_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionToken => new TerraformReference(this, "version_token");

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    [TerraformPropertyName("warehouse_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WarehouseLocation => new TerraformReference(this, "warehouse_location");

}
