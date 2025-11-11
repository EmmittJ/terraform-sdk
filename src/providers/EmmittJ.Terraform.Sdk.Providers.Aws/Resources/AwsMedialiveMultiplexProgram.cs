using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_program_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock
{
    /// <summary>
    /// The preferred_channel_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredChannelPipeline is required")]
    [TerraformPropertyName("preferred_channel_pipeline")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PreferredChannelPipeline { get; set; }

    /// <summary>
    /// The program_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramNumber is required")]
    [TerraformPropertyName("program_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ProgramNumber { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveMultiplexProgramTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_medialive_multiplex_program resource.
/// </summary>
public class AwsMedialiveMultiplexProgram : TerraformResource
{
    public AwsMedialiveMultiplexProgram(string name) : base("aws_medialive_multiplex_program", name)
    {
    }

    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    [TerraformPropertyName("multiplex_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MultiplexId { get; set; }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    [TerraformPropertyName("program_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProgramName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for multiplex_program_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multiplex_program_settings")]
    public TerraformList<TerraformBlock<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>>? MultiplexProgramSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMedialiveMultiplexProgramTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
