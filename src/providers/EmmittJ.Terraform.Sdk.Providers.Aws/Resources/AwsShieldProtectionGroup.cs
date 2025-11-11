using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_protection_group resource.
/// </summary>
public partial class AwsShieldProtectionGroup : TerraformResource
{
    public AwsShieldProtectionGroup(string name) : base("aws_shield_protection_group", name)
    {
    }

    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformProperty("aggregation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Aggregation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformProperty("members")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Members { get; set; }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformProperty("pattern")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Pattern { get; set; }

    /// <summary>
    /// The protection_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionGroupId is required")]
    [TerraformProperty("protection_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProtectionGroupId { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceType { get; set; }

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
    /// The protection_group_arn attribute.
    /// </summary>
    [TerraformProperty("protection_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProtectionGroupArn { get; }

}
