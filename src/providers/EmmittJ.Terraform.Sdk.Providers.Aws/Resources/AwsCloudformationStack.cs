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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformSet<string>>("capabilities");
        set => SetArgument("capabilities", value);
    }

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    public TerraformValue<bool>? DisableRollback
    {
        get => GetArgument<TerraformValue<bool>>("disable_rollback");
        set => SetArgument("disable_rollback", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

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
    /// The notification_arns attribute.
    /// </summary>
    public TerraformSet<string>? NotificationArns
    {
        get => GetArgument<TerraformSet<string>>("notification_arns");
        set => SetArgument("notification_arns", value);
    }

    /// <summary>
    /// The on_failure attribute.
    /// </summary>
    public TerraformValue<string>? OnFailure
    {
        get => GetArgument<TerraformValue<string>>("on_failure");
        set => SetArgument("on_failure", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_body attribute.
    /// </summary>
    public TerraformValue<string>? PolicyBody
    {
        get => GetArgument<TerraformValue<string>>("policy_body");
        set => SetArgument("policy_body", value);
    }

    /// <summary>
    /// The policy_url attribute.
    /// </summary>
    public TerraformValue<string>? PolicyUrl
    {
        get => GetArgument<TerraformValue<string>>("policy_url");
        set => SetArgument("policy_url", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string>? TemplateBody
    {
        get => GetArgument<TerraformValue<string>>("template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string>? TemplateUrl
    {
        get => GetArgument<TerraformValue<string>>("template_url");
        set => SetArgument("template_url", value);
    }

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("timeout_in_minutes");
        set => SetArgument("timeout_in_minutes", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformMap<string> Outputs
        => AsReference("outputs");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudformationStackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudformationStackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
