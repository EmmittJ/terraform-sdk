using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_policy_attachment resource.
/// </summary>
public partial class AwsOrganizationsPolicyAttachment : TerraformResource
{
    public AwsOrganizationsPolicyAttachment(string name) : base("aws_organizations_policy_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    [TerraformProperty("policy_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyId { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    [TerraformProperty("target_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetId { get; set; }

}
