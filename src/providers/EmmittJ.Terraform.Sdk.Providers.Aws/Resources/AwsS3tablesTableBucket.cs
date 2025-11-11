using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_table_bucket resource.
/// </summary>
public partial class AwsS3tablesTableBucket : TerraformResource
{
    public AwsS3tablesTableBucket(string name) : base("aws_s3tables_table_bucket", name)
    {
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<object>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ForceDestroy { get; set; }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    [TerraformProperty("maintenance_configuration")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<object> MaintenanceConfiguration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerAccountId { get; }

}
