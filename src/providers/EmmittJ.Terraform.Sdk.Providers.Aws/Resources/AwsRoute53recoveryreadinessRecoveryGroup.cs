using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53recoveryreadinessRecoveryGroup.
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_route53recoveryreadiness_recovery_group Terraform resource.
/// Manages a aws_route53recoveryreadiness_recovery_group resource.
/// </summary>
public partial class AwsRoute53recoveryreadinessRecoveryGroup(string name) : TerraformResource("aws_route53recoveryreadiness_recovery_group", name)
{
    /// <summary>
    /// The cells attribute.
    /// </summary>
    public TerraformList<string>? Cells
    {
        get => GetArgument<TerraformList<string>>("cells");
        set => SetArgument("cells", value);
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
    /// The recovery_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryGroupName is required")]
    public required TerraformValue<string> RecoveryGroupName
    {
        get => GetArgument<TerraformValue<string>>("recovery_group_name");
        set => SetArgument("recovery_group_name", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53recoveryreadinessRecoveryGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
