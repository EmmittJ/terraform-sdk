using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_tape_pool resource.
/// </summary>
public partial class AwsStoragegatewayTapePool : TerraformResource
{
    public AwsStoragegatewayTapePool(string name) : base("aws_storagegateway_tape_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformProperty("pool_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PoolName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_lock_time_in_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionLockTimeInDays { get; set; }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    [TerraformProperty("retention_lock_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RetentionLockType { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    [TerraformProperty("storage_class")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageClass { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
