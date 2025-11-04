using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_parameters_by_path.
/// </summary>
public class AwsSsmParametersByPathDataSource : TerraformDataSource
{
    public AwsSsmParametersByPathDataSource(string name) : base("aws_ssm_parameters_by_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arns");
        this.DeclareOutput("names");
        this.DeclareOutput("types");
        this.DeclareOutput("values");
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
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    public bool? Recursive
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("recursive")?.Value;
        set => this.WithProperty("recursive", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The with_decryption attribute.
    /// </summary>
    public bool? WithDecryption
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("with_decryption")?.Value;
        set => this.WithProperty("with_decryption", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

    /// <summary>
    /// The types attribute.
    /// </summary>
    public TerraformExpression Types => this["types"];

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformExpression Values => this["values"];

}
