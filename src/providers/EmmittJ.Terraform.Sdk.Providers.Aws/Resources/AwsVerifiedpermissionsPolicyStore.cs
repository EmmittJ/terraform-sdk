using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validation_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock() : TerraformBlock("validation_settings")
{
    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Manages a aws_verifiedpermissions_policy_store resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicyStore : TerraformResource
{
    public AwsVerifiedpermissionsPolicyStore(string name) : base("aws_verifiedpermissions_policy_store", name)
    {
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeletionProtection { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for validation_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("validation_settings")]
    public TerraformList<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock> ValidationSettings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [TerraformProperty("policy_store_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyStoreId { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
