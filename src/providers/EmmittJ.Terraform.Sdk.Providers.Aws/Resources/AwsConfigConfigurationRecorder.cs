using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recording_group in AwsConfigConfigurationRecorder.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recording_group";

    /// <summary>
    /// The all_supported attribute.
    /// </summary>
    public TerraformValue<bool>? AllSupported
    {
        get => GetArgument<TerraformValue<bool>>("all_supported");
        set => SetArgument("all_supported", value);
    }

    /// <summary>
    /// The include_global_resource_types attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeGlobalResourceTypes
    {
        get => GetArgument<TerraformValue<bool>>("include_global_resource_types");
        set => SetArgument("include_global_resource_types", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformSet<string>? ResourceTypes
    {
        get => GetArgument<TerraformSet<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// ExclusionByResourceTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlockExclusionByResourceTypesBlock>? ExclusionByResourceTypes
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlockExclusionByResourceTypesBlock>>("exclusion_by_resource_types");
        set => SetArgument("exclusion_by_resource_types", value);
    }

    /// <summary>
    /// RecordingStrategy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlockRecordingStrategyBlock>? RecordingStrategy
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlockRecordingStrategyBlock>>("recording_strategy");
        set => SetArgument("recording_strategy", value);
    }

}

/// <summary>
/// Block type for exclusion_by_resource_types in AwsConfigConfigurationRecorderRecordingGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlockExclusionByResourceTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_by_resource_types";

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformSet<string>? ResourceTypes
    {
        get => GetArgument<TerraformSet<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

}

/// <summary>
/// Block type for recording_strategy in AwsConfigConfigurationRecorderRecordingGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingGroupBlockRecordingStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recording_strategy";

    /// <summary>
    /// The use_only attribute.
    /// </summary>
    public TerraformValue<string>? UseOnly
    {
        get => GetArgument<TerraformValue<string>>("use_only");
        set => SetArgument("use_only", value);
    }

}


/// <summary>
/// Block type for recording_mode in AwsConfigConfigurationRecorder.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recording_mode";

    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    public TerraformValue<string>? RecordingFrequency
    {
        get => GetArgument<TerraformValue<string>>("recording_frequency");
        set => SetArgument("recording_frequency", value);
    }

    /// <summary>
    /// RecordingModeOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingModeOverride block(s) allowed")]
    public TerraformList<AwsConfigConfigurationRecorderRecordingModeBlockRecordingModeOverrideBlock>? RecordingModeOverride
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationRecorderRecordingModeBlockRecordingModeOverrideBlock>>("recording_mode_override");
        set => SetArgument("recording_mode_override", value);
    }

}

/// <summary>
/// Block type for recording_mode_override in AwsConfigConfigurationRecorderRecordingModeBlock.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationRecorderRecordingModeBlockRecordingModeOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recording_mode_override";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The recording_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordingFrequency is required")]
    public required TerraformValue<string> RecordingFrequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("recording_frequency");
        set => SetArgument("recording_frequency", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypes is required")]
    public required TerraformSet<string> ResourceTypes
    {
        get => GetRequiredArgument<TerraformSet<string>>("resource_types");
        set => SetArgument("resource_types", value);
    }

}


/// <summary>
/// Represents a aws_config_configuration_recorder Terraform resource.
/// Manages a aws_config_configuration_recorder resource.
/// </summary>
public partial class AwsConfigConfigurationRecorder(string name) : TerraformResource("aws_config_configuration_recorder", name)
{
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
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// RecordingGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingGroup block(s) allowed")]
    public TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlock>? RecordingGroup
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationRecorderRecordingGroupBlock>>("recording_group");
        set => SetArgument("recording_group", value);
    }

    /// <summary>
    /// RecordingMode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordingMode block(s) allowed")]
    public TerraformList<AwsConfigConfigurationRecorderRecordingModeBlock>? RecordingMode
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationRecorderRecordingModeBlock>>("recording_mode");
        set => SetArgument("recording_mode", value);
    }

}
