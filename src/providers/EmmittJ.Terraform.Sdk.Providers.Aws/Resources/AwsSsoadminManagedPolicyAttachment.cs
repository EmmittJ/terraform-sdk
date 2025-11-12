using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSsoadminManagedPolicyAttachmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ssoadmin_managed_policy_attachment resource.
/// </summary>
public partial class AwsSsoadminManagedPolicyAttachment : TerraformResource
{
    public AwsSsoadminManagedPolicyAttachment(string name) : base("aws_ssoadmin_managed_policy_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformProperty("instance_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedPolicyArn is required")]
    [TerraformProperty("managed_policy_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedPolicyArn { get; set; }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    [TerraformProperty("permission_set_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PermissionSetArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsSsoadminManagedPolicyAttachmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The managed_policy_name attribute.
    /// </summary>
    [TerraformProperty("managed_policy_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagedPolicyName { get; }

}
