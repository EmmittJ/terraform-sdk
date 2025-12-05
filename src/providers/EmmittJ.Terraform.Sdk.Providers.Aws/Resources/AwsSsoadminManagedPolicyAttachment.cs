using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSsoadminManagedPolicyAttachment.
/// Nesting mode: single
/// </summary>
public class AwsSsoadminManagedPolicyAttachmentTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ssoadmin_managed_policy_attachment Terraform resource.
/// Manages a aws_ssoadmin_managed_policy_attachment resource.
/// </summary>
public partial class AwsSsoadminManagedPolicyAttachment(string name) : TerraformResource("aws_ssoadmin_managed_policy_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedPolicyArn is required")]
    public required TerraformValue<string> ManagedPolicyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_policy_arn");
        set => SetArgument("managed_policy_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    public required TerraformValue<string> PermissionSetArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("permission_set_arn");
        set => SetArgument("permission_set_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The managed_policy_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedPolicyName
        => CreateReference("managed_policy_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsoadminManagedPolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsoadminManagedPolicyAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
