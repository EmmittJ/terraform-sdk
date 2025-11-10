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
        get => GetRequiredProperty<TerraformProperty<string>>("preferred_channel_pipeline");
        set => WithProperty("preferred_channel_pipeline", value);
    }

    /// <summary>
    /// The program_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramNumber is required")]
    public required TerraformProperty<double> ProgramNumber
    {
        get => GetRequiredProperty<TerraformProperty<double>>("program_number");
        set => WithProperty("program_number", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    public required TerraformProperty<string> MultiplexId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("multiplex_id");
        set => this.WithProperty("multiplex_id", value);
    }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    public required TerraformProperty<string> ProgramName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("program_name");
        set => this.WithProperty("program_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for multiplex_program_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>? MultiplexProgramSettings
    {
        get => GetProperty<List<AwsMedialiveMultiplexProgramMultiplexProgramSettingsBlock>>("multiplex_program_settings");
        set => this.WithProperty("multiplex_program_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveMultiplexProgramTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMedialiveMultiplexProgramTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
