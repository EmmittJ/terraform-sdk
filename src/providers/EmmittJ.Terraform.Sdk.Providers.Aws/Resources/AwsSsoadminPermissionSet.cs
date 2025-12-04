using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSsoadminPermissionSet.
/// Nesting mode: single
/// </summary>
public class AwsSsoadminPermissionSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_ssoadmin_permission_set Terraform resource.
/// Manages a aws_ssoadmin_permission_set resource.
/// </summary>
public partial class AwsSsoadminPermissionSet(string name) : TerraformResource("aws_ssoadmin_permission_set", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The relay_state attribute.
    /// </summary>
    public TerraformValue<string>? RelayState
    {
        get => GetArgument<TerraformValue<string>>("relay_state");
        set => SetArgument("relay_state", value);
    }

    /// <summary>
    /// The session_duration attribute.
    /// </summary>
    public TerraformValue<string>? SessionDuration
    {
        get => GetArgument<TerraformValue<string>>("session_duration");
        set => SetArgument("session_duration", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSsoadminPermissionSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSsoadminPermissionSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
