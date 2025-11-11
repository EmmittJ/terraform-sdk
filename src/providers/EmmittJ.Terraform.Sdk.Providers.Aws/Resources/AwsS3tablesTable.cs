using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3tablesTableMetadataBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_s3tables_table resource.
/// </summary>
public partial class AwsS3tablesTable : TerraformResource
{
    public AwsS3tablesTable(string name) : base("aws_s3tables_table", name)
    {
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<object> EncryptionConfiguration { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    [TerraformProperty("maintenance_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<object> MaintenanceConfiguration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    [TerraformProperty("table_bucket_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableBucketArn { get; set; }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("metadata")]
    public partial TerraformList<TerraformBlock<AwsS3tablesTableMetadataBlock>>? Metadata { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The metadata_location attribute.
    /// </summary>
    [TerraformProperty("metadata_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MetadataLocation { get; }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformProperty("modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModifiedAt { get; }

    /// <summary>
    /// The modified_by attribute.
    /// </summary>
    [TerraformProperty("modified_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModifiedBy { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAccountId { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The version_token attribute.
    /// </summary>
    [TerraformProperty("version_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionToken { get; }

    /// <summary>
    /// The warehouse_location attribute.
    /// </summary>
    [TerraformProperty("warehouse_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WarehouseLocation { get; }

}
