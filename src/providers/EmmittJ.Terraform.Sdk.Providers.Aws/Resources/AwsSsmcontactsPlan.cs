using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stage in AwsSsmcontactsPlan.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsPlanStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stage";

    /// <summary>
    /// The duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInMinutes is required")]
    public required TerraformValue<double> DurationInMinutes
    {
        get => GetArgument<TerraformValue<double>>("duration_in_minutes");
        set => SetArgument("duration_in_minutes", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmcontactsPlanStageBlockTargetBlock>? Target
    {
        get => GetArgument<TerraformList<AwsSsmcontactsPlanStageBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for target in AwsSsmcontactsPlanStageBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsPlanStageBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// ChannelTargetInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ChannelTargetInfo block(s) allowed")]
    public TerraformList<AwsSsmcontactsPlanStageBlockTargetBlockChannelTargetInfoBlock>? ChannelTargetInfo
    {
        get => GetArgument<TerraformList<AwsSsmcontactsPlanStageBlockTargetBlockChannelTargetInfoBlock>>("channel_target_info");
        set => SetArgument("channel_target_info", value);
    }

    /// <summary>
    /// ContactTargetInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContactTargetInfo block(s) allowed")]
    public TerraformList<AwsSsmcontactsPlanStageBlockTargetBlockContactTargetInfoBlock>? ContactTargetInfo
    {
        get => GetArgument<TerraformList<AwsSsmcontactsPlanStageBlockTargetBlockContactTargetInfoBlock>>("contact_target_info");
        set => SetArgument("contact_target_info", value);
    }

}

/// <summary>
/// Block type for channel_target_info in AwsSsmcontactsPlanStageBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsPlanStageBlockTargetBlockChannelTargetInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "channel_target_info";

    /// <summary>
    /// The contact_channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactChannelId is required")]
    public required TerraformValue<string> ContactChannelId
    {
        get => GetArgument<TerraformValue<string>>("contact_channel_id");
        set => SetArgument("contact_channel_id", value);
    }

    /// <summary>
    /// The retry_interval_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? RetryIntervalInMinutes
    {
        get => GetArgument<TerraformValue<double>>("retry_interval_in_minutes");
        set => SetArgument("retry_interval_in_minutes", value);
    }

}

/// <summary>
/// Block type for contact_target_info in AwsSsmcontactsPlanStageBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsPlanStageBlockTargetBlockContactTargetInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "contact_target_info";

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    public TerraformValue<string>? ContactId
    {
        get => GetArgument<TerraformValue<string>>("contact_id");
        set => SetArgument("contact_id", value);
    }

    /// <summary>
    /// The is_essential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsEssential is required")]
    public required TerraformValue<bool> IsEssential
    {
        get => GetArgument<TerraformValue<bool>>("is_essential");
        set => SetArgument("is_essential", value);
    }

}


/// <summary>
/// Represents a aws_ssmcontacts_plan Terraform resource.
/// Manages a aws_ssmcontacts_plan resource.
/// </summary>
public partial class AwsSsmcontactsPlan(string name) : TerraformResource("aws_ssmcontacts_plan", name)
{
    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    public required TerraformValue<string> ContactId
    {
        get => GetArgument<TerraformValue<string>>("contact_id");
        set => SetArgument("contact_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Stage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Stage block(s) required")]
    public required TerraformList<AwsSsmcontactsPlanStageBlock> Stage
    {
        get => GetRequiredArgument<TerraformList<AwsSsmcontactsPlanStageBlock>>("stage");
        set => SetArgument("stage", value);
    }

}
