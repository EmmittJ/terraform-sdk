using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_config in AwsSagemakerEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_config";

    /// <summary>
    /// AutoRollbackConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoRollbackConfiguration block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlock>? AutoRollbackConfiguration
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlock>>("auto_rollback_configuration");
        set => SetArgument("auto_rollback_configuration", value);
    }

    /// <summary>
    /// BlueGreenUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlueGreenUpdatePolicy block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlock>? BlueGreenUpdatePolicy
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlock>>("blue_green_update_policy");
        set => SetArgument("blue_green_update_policy", value);
    }

    /// <summary>
    /// RollingUpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpdatePolicy block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlock>? RollingUpdatePolicy
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlock>>("rolling_update_policy");
        set => SetArgument("rolling_update_policy", value);
    }

}

/// <summary>
/// Block type for auto_rollback_configuration in AwsSagemakerEndpointDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_rollback_configuration";

    /// <summary>
    /// Alarms block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Alarms block(s) allowed")]
    public TerraformSet<AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlockAlarmsBlock>? Alarms
    {
        get => GetArgument<TerraformSet<AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlockAlarmsBlock>>("alarms");
        set => SetArgument("alarms", value);
    }

}

/// <summary>
/// Block type for alarms in AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockAutoRollbackConfigurationBlockAlarmsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alarms";

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => GetRequiredArgument<TerraformValue<string>>("alarm_name");
        set => SetArgument("alarm_name", value);
    }

}

/// <summary>
/// Block type for blue_green_update_policy in AwsSagemakerEndpointDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blue_green_update_policy";

    /// <summary>
    /// The maximum_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumExecutionTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_execution_timeout_in_seconds");
        set => SetArgument("maximum_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The termination_wait_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TerminationWaitInSeconds
    {
        get => GetArgument<TerraformValue<double>>("termination_wait_in_seconds");
        set => SetArgument("termination_wait_in_seconds", value);
    }

    /// <summary>
    /// TrafficRoutingConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficRoutingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TrafficRoutingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrafficRoutingConfiguration block(s) allowed")]
    public required TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlock> TrafficRoutingConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlock>>("traffic_routing_configuration");
        set => SetArgument("traffic_routing_configuration", value);
    }

}

/// <summary>
/// Block type for traffic_routing_configuration in AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_routing_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The wait_interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitIntervalInSeconds is required")]
    public required TerraformValue<double> WaitIntervalInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("wait_interval_in_seconds");
        set => SetArgument("wait_interval_in_seconds", value);
    }

    /// <summary>
    /// CanarySize block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySize block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockCanarySizeBlock>? CanarySize
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockCanarySizeBlock>>("canary_size");
        set => SetArgument("canary_size", value);
    }

    /// <summary>
    /// LinearStepSize block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinearStepSize block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockLinearStepSizeBlock>? LinearStepSize
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockLinearStepSizeBlock>>("linear_step_size");
        set => SetArgument("linear_step_size", value);
    }

}

/// <summary>
/// Block type for canary_size in AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockCanarySizeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "canary_size";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for linear_step_size in AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockBlueGreenUpdatePolicyBlockTrafficRoutingConfigurationBlockLinearStepSizeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linear_step_size";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for rolling_update_policy in AwsSagemakerEndpointDeploymentConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rolling_update_policy";

    /// <summary>
    /// The maximum_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumExecutionTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_execution_timeout_in_seconds");
        set => SetArgument("maximum_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The wait_interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WaitIntervalInSeconds is required")]
    public required TerraformValue<double> WaitIntervalInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("wait_interval_in_seconds");
        set => SetArgument("wait_interval_in_seconds", value);
    }

    /// <summary>
    /// MaximumBatchSize block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBatchSize is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MaximumBatchSize block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumBatchSize block(s) allowed")]
    public required TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockMaximumBatchSizeBlock> MaximumBatchSize
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockMaximumBatchSizeBlock>>("maximum_batch_size");
        set => SetArgument("maximum_batch_size", value);
    }

    /// <summary>
    /// RollbackMaximumBatchSize block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollbackMaximumBatchSize block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockRollbackMaximumBatchSizeBlock>? RollbackMaximumBatchSize
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockRollbackMaximumBatchSizeBlock>>("rollback_maximum_batch_size");
        set => SetArgument("rollback_maximum_batch_size", value);
    }

}

/// <summary>
/// Block type for maximum_batch_size in AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockMaximumBatchSizeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maximum_batch_size";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for rollback_maximum_batch_size in AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerEndpointDeploymentConfigBlockRollingUpdatePolicyBlockRollbackMaximumBatchSizeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollback_maximum_batch_size";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_endpoint Terraform resource.
/// Manages a aws_sagemaker_endpoint resource.
/// </summary>
public partial class AwsSagemakerEndpoint(string name) : TerraformResource("aws_sagemaker_endpoint", name)
{
    /// <summary>
    /// The endpoint_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointConfigName is required")]
    public required TerraformValue<string> EndpointConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint_config_name");
        set => SetArgument("endpoint_config_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DeploymentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentConfig block(s) allowed")]
    public TerraformList<AwsSagemakerEndpointDeploymentConfigBlock>? DeploymentConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerEndpointDeploymentConfigBlock>>("deployment_config");
        set => SetArgument("deployment_config", value);
    }

}
