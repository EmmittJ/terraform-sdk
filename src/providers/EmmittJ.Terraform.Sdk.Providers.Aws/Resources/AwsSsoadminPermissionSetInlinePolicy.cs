using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSsoadminPermissionSetInlinePolicy.
/// Nesting mode: single
/// </summary>
public class AwsSsoadminPermissionSetInlinePolicyTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ssoadmin_permission_set_inline_policy Terraform resource.
/// Manages a aws_ssoadmin_permission_set_inline_policy resource.
/// </summary>
public partial class AwsSsoadminPermissionSetInlinePolicy(string name) : TerraformResource("aws_ssoadmin_permission_set_inline_policy", name)
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
    /// The inline_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InlinePolicy is required")]
    public required TerraformValue<string> InlinePolicy
    {
        get => GetArgument<TerraformValue<string>>("inline_policy");
        set => SetArgument("inline_policy", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsoadminPermissionSetInlinePolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsoadminPermissionSetInlinePolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
