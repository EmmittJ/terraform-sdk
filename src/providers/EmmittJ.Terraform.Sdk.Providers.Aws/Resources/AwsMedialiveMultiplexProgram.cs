using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_program_settings in AwsMedialiveMultiplexProgram.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiplex_program_settings";

    /// <summary>
    /// The preferred_channel_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredChannelPipeline is required")]
    public required TerraformValue<string> PreferredChannelPipeline
    {
        get => GetRequiredArgument<TerraformValue<string>>("preferred_channel_pipeline");
        set => SetArgument("preferred_channel_pipeline", value);
    }

    /// <summary>
    /// The program_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramNumber is required")]
    public required TerraformValue<double> ProgramNumber
    {
        get => GetRequiredArgument<TerraformValue<double>>("program_number");
        set => SetArgument("program_number", value);
    }

    /// <summary>
    /// ServiceDescriptor block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockServiceDescriptorBlock>? ServiceDescriptor
    {
        get => GetArgument<TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockServiceDescriptorBlock>>("service_descriptor");
        set => SetArgument("service_descriptor", value);
    }

    /// <summary>
    /// VideoSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlock>? VideoSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlock>>("video_settings");
        set => SetArgument("video_settings", value);
    }

}

/// <summary>
/// Block type for service_descriptor in AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockServiceDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_descriptor";

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformValue<string> ProviderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

}

/// <summary>
/// Block type for video_settings in AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_settings";

    /// <summary>
    /// The constant_bitrate attribute.
    /// </summary>
    public TerraformValue<double> ConstantBitrate
    {
        get => GetArgument<TerraformValue<double>>("constant_bitrate") ?? AsReference("constant_bitrate");
        set => SetArgument("constant_bitrate", value);
    }

    /// <summary>
    /// StatmuxSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlockStatmuxSettingsBlock>? StatmuxSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlockStatmuxSettingsBlock>>("statmux_settings");
        set => SetArgument("statmux_settings", value);
    }

}

/// <summary>
/// Block type for statmux_settings in AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlockVideoSettingsBlockStatmuxSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statmux_settings";

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    public TerraformValue<double> MaximumBitrate
    {
        get => GetArgument<TerraformValue<double>>("maximum_bitrate") ?? AsReference("maximum_bitrate");
        set => SetArgument("maximum_bitrate", value);
    }

    /// <summary>
    /// The minimum_bitrate attribute.
    /// </summary>
    public TerraformValue<double> MinimumBitrate
    {
        get => GetArgument<TerraformValue<double>>("minimum_bitrate") ?? AsReference("minimum_bitrate");
        set => SetArgument("minimum_bitrate", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority") ?? AsReference("priority");
        set => SetArgument("priority", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMedialiveMultiplexProgram.
/// Nesting mode: single
/// </summary>
public class AwsMedialiveMultiplexProgramTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_medialive_multiplex_program Terraform resource.
/// Manages a aws_medialive_multiplex_program resource.
/// </summary>
public partial class AwsMedialiveMultiplexProgram(string name) : TerraformResource("aws_medialive_multiplex_program", name)
{
    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    public required TerraformValue<string> MultiplexId
    {
        get => GetRequiredArgument<TerraformValue<string>>("multiplex_id");
        set => SetArgument("multiplex_id", value);
    }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    public required TerraformValue<string> ProgramName
    {
        get => GetRequiredArgument<TerraformValue<string>>("program_name");
        set => SetArgument("program_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// MultiplexProgramSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>? MultiplexProgramSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>>("multiplex_program_settings");
        set => SetArgument("multiplex_program_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMedialiveMultiplexProgramTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMedialiveMultiplexProgramTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
