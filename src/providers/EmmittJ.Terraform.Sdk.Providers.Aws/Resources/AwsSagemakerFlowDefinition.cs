using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for human_loop_activation_config in AwsSagemakerFlowDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_loop_activation_config";

    /// <summary>
    /// HumanLoopActivationConditionsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopActivationConditionsConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlockHumanLoopActivationConditionsConfigBlock>? HumanLoopActivationConditionsConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlockHumanLoopActivationConditionsConfigBlock>>("human_loop_activation_conditions_config");
        set => SetArgument("human_loop_activation_conditions_config", value);
    }

}

/// <summary>
/// Block type for human_loop_activation_conditions_config in AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlockHumanLoopActivationConditionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_loop_activation_conditions_config";

    /// <summary>
    /// The human_loop_activation_conditions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanLoopActivationConditions is required")]
    public required TerraformValue<string> HumanLoopActivationConditions
    {
        get => GetRequiredArgument<TerraformValue<string>>("human_loop_activation_conditions");
        set => SetArgument("human_loop_activation_conditions", value);
    }

}


/// <summary>
/// Block type for human_loop_config in AwsSagemakerFlowDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_loop_config";

    /// <summary>
    /// The human_task_ui_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiArn is required")]
    public required TerraformValue<string> HumanTaskUiArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("human_task_ui_arn");
        set => SetArgument("human_task_ui_arn", value);
    }

    /// <summary>
    /// The task_availability_lifetime_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TaskAvailabilityLifetimeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("task_availability_lifetime_in_seconds");
        set => SetArgument("task_availability_lifetime_in_seconds", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskCount is required")]
    public required TerraformValue<double> TaskCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("task_count");
        set => SetArgument("task_count", value);
    }

    /// <summary>
    /// The task_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDescription is required")]
    public required TerraformValue<string> TaskDescription
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_description");
        set => SetArgument("task_description", value);
    }

    /// <summary>
    /// The task_keywords attribute.
    /// </summary>
    public TerraformSet<string>? TaskKeywords
    {
        get => GetArgument<TerraformSet<string>>("task_keywords");
        set => SetArgument("task_keywords", value);
    }

    /// <summary>
    /// The task_time_limit_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TaskTimeLimitInSeconds
    {
        get => GetArgument<TerraformValue<double>>("task_time_limit_in_seconds");
        set => SetArgument("task_time_limit_in_seconds", value);
    }

    /// <summary>
    /// The task_title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskTitle is required")]
    public required TerraformValue<string> TaskTitle
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_title");
        set => SetArgument("task_title", value);
    }

    /// <summary>
    /// The workteam_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamArn is required")]
    public required TerraformValue<string> WorkteamArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("workteam_arn");
        set => SetArgument("workteam_arn", value);
    }

    /// <summary>
    /// PublicWorkforceTaskPrice block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicWorkforceTaskPrice block(s) allowed")]
    public TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlock>? PublicWorkforceTaskPrice
    {
        get => GetArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlock>>("public_workforce_task_price");
        set => SetArgument("public_workforce_task_price", value);
    }

}

/// <summary>
/// Block type for public_workforce_task_price in AwsSagemakerFlowDefinitionHumanLoopConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_workforce_task_price";

    /// <summary>
    /// AmountInUsd block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmountInUsd block(s) allowed")]
    public TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlockAmountInUsdBlock>? AmountInUsd
    {
        get => GetArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlockAmountInUsdBlock>>("amount_in_usd");
        set => SetArgument("amount_in_usd", value);
    }

}

/// <summary>
/// Block type for amount_in_usd in AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopConfigBlockPublicWorkforceTaskPriceBlockAmountInUsdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amount_in_usd";

    /// <summary>
    /// The cents attribute.
    /// </summary>
    public TerraformValue<double>? Cents
    {
        get => GetArgument<TerraformValue<double>>("cents");
        set => SetArgument("cents", value);
    }

    /// <summary>
    /// The dollars attribute.
    /// </summary>
    public TerraformValue<double>? Dollars
    {
        get => GetArgument<TerraformValue<double>>("dollars");
        set => SetArgument("dollars", value);
    }

    /// <summary>
    /// The tenth_fractions_of_a_cent attribute.
    /// </summary>
    public TerraformValue<double>? TenthFractionsOfACent
    {
        get => GetArgument<TerraformValue<double>>("tenth_fractions_of_a_cent");
        set => SetArgument("tenth_fractions_of_a_cent", value);
    }

}


/// <summary>
/// Block type for human_loop_request_source in AwsSagemakerFlowDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "human_loop_request_source";

    /// <summary>
    /// The aws_managed_human_loop_request_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsManagedHumanLoopRequestSource is required")]
    public required TerraformValue<string> AwsManagedHumanLoopRequestSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("aws_managed_human_loop_request_source");
        set => SetArgument("aws_managed_human_loop_request_source", value);
    }

}


/// <summary>
/// Block type for output_config in AwsSagemakerFlowDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFlowDefinitionOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputPath is required")]
    public required TerraformValue<string> S3OutputPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_output_path");
        set => SetArgument("s3_output_path", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_flow_definition Terraform resource.
/// Manages a aws_sagemaker_flow_definition resource.
/// </summary>
public partial class AwsSagemakerFlowDefinition(string name) : TerraformResource("aws_sagemaker_flow_definition", name)
{
    /// <summary>
    /// The flow_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowDefinitionName is required")]
    public required TerraformValue<string> FlowDefinitionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("flow_definition_name");
        set => SetArgument("flow_definition_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// HumanLoopActivationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopActivationConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>? HumanLoopActivationConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopActivationConfigBlock>>("human_loop_activation_config");
        set => SetArgument("human_loop_activation_config", value);
    }

    /// <summary>
    /// HumanLoopConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanLoopConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HumanLoopConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlock> HumanLoopConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopConfigBlock>>("human_loop_config");
        set => SetArgument("human_loop_config", value);
    }

    /// <summary>
    /// HumanLoopRequestSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HumanLoopRequestSource block(s) allowed")]
    public TerraformList<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>? HumanLoopRequestSource
    {
        get => GetArgument<TerraformList<AwsSagemakerFlowDefinitionHumanLoopRequestSourceBlock>>("human_loop_request_source");
        set => SetArgument("human_loop_request_source", value);
    }

    /// <summary>
    /// OutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerFlowDefinitionOutputConfigBlock> OutputConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerFlowDefinitionOutputConfigBlock>>("output_config");
        set => SetArgument("output_config", value);
    }

}
