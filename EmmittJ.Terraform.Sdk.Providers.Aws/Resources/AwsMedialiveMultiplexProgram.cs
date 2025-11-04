using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? MultiplexId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multiplex_id")?.Value;
        set => this.WithProperty("multiplex_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    public string? ProgramName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("program_name")?.Value;
        set => this.WithProperty("program_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
