using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for customer_managed_policy_reference in AwsSsoadminCustomerManagedPolicyAttachment.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminCustomerManagedPolicyAttachmentCustomerManagedPolicyReferenceBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSsoadminCustomerManagedPolicyAttachment.
/// Nesting mode: single
/// </summary>
public class AwsSsoadminCustomerManagedPolicyAttachmentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ssoadmin_customer_managed_policy_attachment Terraform resource.
/// Manages a aws_ssoadmin_customer_managed_policy_attachment resource.
/// </summary>
public partial class AwsSsoadminCustomerManagedPolicyAttachment(string name) : TerraformResource("aws_ssoadmin_customer_managed_policy_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => new TerraformReference<string>(this, "instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    public required TerraformValue<string> PermissionSetArn
    {
        get => new TerraformReference<string>(this, "permission_set_arn");
        set => SetArgument("permission_set_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// CustomerManagedPolicyReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerManagedPolicyReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CustomerManagedPolicyReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedPolicyReference block(s) allowed")]
    public required TerraformList<AwsSsoadminCustomerManagedPolicyAttachmentCustomerManagedPolicyReferenceBlock> CustomerManagedPolicyReference
    {
        get => GetRequiredArgument<TerraformList<AwsSsoadminCustomerManagedPolicyAttachmentCustomerManagedPolicyReferenceBlock>>("customer_managed_policy_reference");
        set => SetArgument("customer_managed_policy_reference", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsoadminCustomerManagedPolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsoadminCustomerManagedPolicyAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
