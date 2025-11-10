using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_bucket resource.
/// </summary>
public class AwsS3tablesTableBucket : TerraformResource
{
    public AwsS3tablesTableBucket(string name) : base("aws_s3tables_table_bucket", name)
    {
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<object>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ForceDestroy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "force_destroy");

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
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_account_id");

}
