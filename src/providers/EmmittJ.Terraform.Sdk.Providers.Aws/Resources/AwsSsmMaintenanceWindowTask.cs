using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for targets in AwsSsmMaintenanceWindowTask.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "targets";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for task_invocation_parameters in AwsSsmMaintenanceWindowTask.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_invocation_parameters";

    /// <summary>
    /// AutomationParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomationParameters block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlock>? AutomationParameters
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlock>>("automation_parameters");
        set => SetArgument("automation_parameters", value);
    }

    /// <summary>
    /// LambdaParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaParameters block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockLambdaParametersBlock>? LambdaParameters
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockLambdaParametersBlock>>("lambda_parameters");
        set => SetArgument("lambda_parameters", value);
    }

    /// <summary>
    /// RunCommandParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunCommandParameters block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock>? RunCommandParameters
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock>>("run_command_parameters");
        set => SetArgument("run_command_parameters", value);
    }

    /// <summary>
    /// StepFunctionsParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepFunctionsParameters block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockStepFunctionsParametersBlock>? StepFunctionsParameters
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockStepFunctionsParametersBlock>>("step_functions_parameters");
        set => SetArgument("step_functions_parameters", value);
    }

}

/// <summary>
/// Block type for automation_parameters in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automation_parameters";

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentVersion
    {
        get => GetArgument<TerraformValue<string>>("document_version");
        set => SetArgument("document_version", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockAutomationParametersBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for lambda_parameters in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockLambdaParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_parameters";

    /// <summary>
    /// The client_context attribute.
    /// </summary>
    public TerraformValue<string>? ClientContext
    {
        get => GetArgument<TerraformValue<string>>("client_context");
        set => SetArgument("client_context", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => GetArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
    }

}

/// <summary>
/// Block type for run_command_parameters in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run_command_parameters";

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The document_hash attribute.
    /// </summary>
    public TerraformValue<string>? DocumentHash
    {
        get => GetArgument<TerraformValue<string>>("document_hash");
        set => SetArgument("document_hash", value);
    }

    /// <summary>
    /// The document_hash_type attribute.
    /// </summary>
    public TerraformValue<string>? DocumentHashType
    {
        get => GetArgument<TerraformValue<string>>("document_hash_type");
        set => SetArgument("document_hash_type", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string>? DocumentVersion
    {
        get => GetArgument<TerraformValue<string>>("document_version");
        set => SetArgument("document_version", value);
    }

    /// <summary>
    /// The output_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? OutputS3Bucket
    {
        get => GetArgument<TerraformValue<string>>("output_s3_bucket");
        set => SetArgument("output_s3_bucket", value);
    }

    /// <summary>
    /// The output_s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? OutputS3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("output_s3_key_prefix");
        set => SetArgument("output_s3_key_prefix", value);
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceRoleArn
    {
        get => GetArgument<TerraformValue<string>>("service_role_arn");
        set => SetArgument("service_role_arn", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// CloudwatchConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchConfig block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockCloudwatchConfigBlock>? CloudwatchConfig
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockCloudwatchConfigBlock>>("cloudwatch_config");
        set => SetArgument("cloudwatch_config", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for cloudwatch_config in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockCloudwatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_config";

    /// <summary>
    /// The cloudwatch_log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchLogGroupName
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_log_group_name");
        set => SetArgument("cloudwatch_log_group_name", value);
    }

    /// <summary>
    /// The cloudwatch_output_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CloudwatchOutputEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cloudwatch_output_enabled");
        set => SetArgument("cloudwatch_output_enabled", value);
    }

}

/// <summary>
/// Block type for notification_config in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// The notification_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationArn
    {
        get => GetArgument<TerraformValue<string>>("notification_arn");
        set => SetArgument("notification_arn", value);
    }

    /// <summary>
    /// The notification_events attribute.
    /// </summary>
    public TerraformList<string>? NotificationEvents
    {
        get => GetArgument<TerraformList<string>>("notification_events");
        set => SetArgument("notification_events", value);
    }

    /// <summary>
    /// The notification_type attribute.
    /// </summary>
    public TerraformValue<string>? NotificationType
    {
        get => GetArgument<TerraformValue<string>>("notification_type");
        set => SetArgument("notification_type", value);
    }

}

/// <summary>
/// Block type for parameter in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlock.
/// Nesting mode: set
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockRunCommandParametersBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for step_functions_parameters in AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlockStepFunctionsParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_functions_parameters";

    /// <summary>
    /// The input attribute.
    /// </summary>
    public TerraformValue<string>? Input
    {
        get => GetArgument<TerraformValue<string>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a aws_ssm_maintenance_window_task Terraform resource.
/// Manages a aws_ssm_maintenance_window_task resource.
/// </summary>
public partial class AwsSsmMaintenanceWindowTask(string name) : TerraformResource("aws_ssm_maintenance_window_task", name)
{
    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    public TerraformValue<string>? CutoffBehavior
    {
        get => GetArgument<TerraformValue<string>>("cutoff_behavior");
        set => SetArgument("cutoff_behavior", value);
    }

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
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformValue<string>? MaxConcurrency
    {
        get => GetArgument<TerraformValue<string>>("max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformValue<string>? MaxErrors
    {
        get => GetArgument<TerraformValue<string>>("max_errors");
        set => SetArgument("max_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceRoleArn
    {
        get => GetArgument<TerraformValue<string>>("service_role_arn");
        set => SetArgument("service_role_arn", value);
    }

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskArn is required")]
    public required TerraformValue<string> TaskArn
    {
        get => GetArgument<TerraformValue<string>>("task_arn");
        set => SetArgument("task_arn", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformValue<string> TaskType
    {
        get => GetArgument<TerraformValue<string>>("task_type");
        set => SetArgument("task_type", value);
    }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    public required TerraformValue<string> WindowId
    {
        get => GetArgument<TerraformValue<string>>("window_id");
        set => SetArgument("window_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The window_task_id attribute.
    /// </summary>
    public TerraformValue<string> WindowTaskId
        => AsReference("window_task_id");

    /// <summary>
    /// Targets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTargetsBlock>? Targets
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTargetsBlock>>("targets");
        set => SetArgument("targets", value);
    }

    /// <summary>
    /// TaskInvocationParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskInvocationParameters block(s) allowed")]
    public TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>? TaskInvocationParameters
    {
        get => GetArgument<TerraformList<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>>("task_invocation_parameters");
        set => SetArgument("task_invocation_parameters", value);
    }

}
