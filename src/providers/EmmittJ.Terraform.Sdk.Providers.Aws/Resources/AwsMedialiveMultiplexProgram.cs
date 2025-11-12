using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_program_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock() : TerraformBlock("multiplex_program_settings")
{
    /// <summary>
    /// The preferred_channel_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredChannelPipeline is required")]
    [TerraformProperty("preferred_channel_pipeline")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PreferredChannelPipeline { get; set; }

    /// <summary>
    /// The program_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramNumber is required")]
    [TerraformProperty("program_number")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ProgramNumber { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMedialiveMultiplexProgramTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_medialive_multiplex_program resource.
/// </summary>
public partial class AwsMedialiveMultiplexProgram : TerraformResource
{
    public AwsMedialiveMultiplexProgram(string name) : base("aws_medialive_multiplex_program", name)
    {
    }

    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    [TerraformProperty("multiplex_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MultiplexId { get; set; }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    [TerraformProperty("program_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProgramName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for multiplex_program_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("multiplex_program_settings")]
    public TerraformList<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock> MultiplexProgramSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMedialiveMultiplexProgramTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
