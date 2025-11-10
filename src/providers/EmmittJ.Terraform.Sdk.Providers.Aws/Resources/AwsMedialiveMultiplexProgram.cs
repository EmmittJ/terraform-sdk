using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_program_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The preferred_channel_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredChannelPipeline is required")]
    public required TerraformProperty<string> PreferredChannelPipeline
    {
        set => SetProperty("preferred_channel_pipeline", value);
    }

    /// <summary>
    /// The program_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramNumber is required")]
    public required TerraformProperty<double> ProgramNumber
    {
        set => SetProperty("program_number", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveMultiplexProgramTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_medialive_multiplex_program resource.
/// </summary>
public class AwsMedialiveMultiplexProgram : TerraformResource
{
    public AwsMedialiveMultiplexProgram(string name) : base("aws_medialive_multiplex_program", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("multiplex_id");
        SetOutput("program_name");
        SetOutput("region");
    }

    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    public required TerraformProperty<string> MultiplexId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multiplex_id");
        set => SetProperty("multiplex_id", value);
    }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    public required TerraformProperty<string> ProgramName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("program_name");
        set => SetProperty("program_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for multiplex_program_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>? MultiplexProgramSettings
    {
        set => SetProperty("multiplex_program_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveMultiplexProgramTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
