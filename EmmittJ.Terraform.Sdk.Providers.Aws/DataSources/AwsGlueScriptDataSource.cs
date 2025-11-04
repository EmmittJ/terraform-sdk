using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_script.
/// </summary>
public class AwsGlueScriptDataSource : TerraformDataSource
{
    public AwsGlueScriptDataSource(string name) : base("aws_glue_script", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("python_script");
        this.DeclareOutput("scala_code");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public string? Language
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language")?.Value;
        set => this.WithProperty("language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The python_script attribute.
    /// </summary>
    public TerraformExpression PythonScript => this["python_script"];

    /// <summary>
    /// The scala_code attribute.
    /// </summary>
    public TerraformExpression ScalaCode => this["scala_code"];

}
