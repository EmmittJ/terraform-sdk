using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permissions_boundary in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock : TerraformBlockBase
{
    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    [TerraformProperty("managed_policy_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedPolicyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_ssoadmin_permissions_boundary_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsoadminPermissionsBoundaryAttachment : TerraformResource
{
    public AwsSsoadminPermissionsBoundaryAttachment(string name) : base("aws_ssoadmin_permissions_boundary_attachment", name)
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
    /// Block for permissions_boundary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionsBoundary is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PermissionsBoundary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PermissionsBoundary block(s) allowed")]
    [TerraformProperty("permissions_boundary")]
    public partial TerraformList<TerraformBlock<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock>>? PermissionsBoundary { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock>? Timeouts { get; set; }

}
