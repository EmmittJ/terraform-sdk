using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permissions_boundary in AwsSsoadminPermissionsBoundaryAttachment.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions_boundary";

    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    public TerraformValue<string>? ManagedPolicyArn
    {
        get => GetArgument<TerraformValue<string>>("managed_policy_arn");
        set => SetArgument("managed_policy_arn", value);
    }

    /// <summary>
    /// CustomerManagedPolicyReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedPolicyReference block(s) allowed")]
    public TerraformList<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlockCustomerManagedPolicyReferenceBlock>? CustomerManagedPolicyReference
    {
        get => GetArgument<TerraformList<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlockCustomerManagedPolicyReferenceBlock>>("customer_managed_policy_reference");
        set => SetArgument("customer_managed_policy_reference", value);
    }

}

/// <summary>
/// Block type for customer_managed_policy_reference in AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlockCustomerManagedPolicyReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_policy_reference";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSsoadminPermissionsBoundaryAttachment.
/// Nesting mode: single
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ssoadmin_permissions_boundary_attachment Terraform resource.
/// Manages a aws_ssoadmin_permissions_boundary_attachment resource.
/// </summary>
public partial class AwsSsoadminPermissionsBoundaryAttachment(string name) : TerraformResource("aws_ssoadmin_permissions_boundary_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    public required TerraformValue<string> PermissionSetArn
    {
        get => GetArgument<TerraformValue<string>>("permission_set_arn");
        set => SetArgument("permission_set_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// PermissionsBoundary block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionsBoundary is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PermissionsBoundary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PermissionsBoundary block(s) allowed")]
    public required TerraformList<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock> PermissionsBoundary
    {
        get => GetRequiredArgument<TerraformList<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock>>("permissions_boundary");
        set => SetArgument("permissions_boundary", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
