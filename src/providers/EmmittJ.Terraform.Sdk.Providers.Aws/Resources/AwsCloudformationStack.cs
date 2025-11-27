using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsCloudformationStack.
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cloudformation_stack Terraform resource.
/// Manages a aws_cloudformation_stack resource.
/// </summary>
public partial class AwsCloudformationStack(string name) : TerraformResource("aws_cloudformation_stack", name)
{
    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformSet<string>? Capabilities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "capabilities").ResolveNodes(ctx));
        set => SetArgument("capabilities", value);
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformValue<bool>? DisableRollback
    {
        get => new TerraformReference<bool>(this, "disable_rollback");
        set => SetArgument("disable_rollback", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

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
    /// The notification_arns attribute.
    /// </summary>
    public TerraformSet<string>? NotificationArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "notification_arns").ResolveNodes(ctx));
        set => SetArgument("notification_arns", value);
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformValue<string>? OnFailure
    {
        get => new TerraformReference<string>(this, "on_failure");
        set => SetArgument("on_failure", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public TerraformValue<string> PolicyBody
    {
        get => new TerraformReference<string>(this, "policy_body");
        set => SetArgument("policy_body", value);
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public TerraformValue<string>? PolicyUrl
    {
        get => new TerraformReference<string>(this, "policy_url");
        set => SetArgument("policy_url", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string> TemplateBody
    {
        get => new TerraformReference<string>(this, "template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string>? TemplateUrl
    {
        get => new TerraformReference<string>(this, "template_url");
        set => SetArgument("template_url", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformMap<string> Outputs
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "outputs").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudformationStackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudformationStackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
