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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    public TerraformProperty<bool>? Recursive
    {
        get => GetProperty<TerraformProperty<bool>>("recursive");
        set => this.WithProperty("recursive", value);
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
    /// The with_decryption attribute.
    /// </summary>
    public TerraformProperty<bool>? WithDecryption
    {
        get => GetProperty<TerraformProperty<bool>>("with_decryption");
        set => this.WithProperty("with_decryption", value);
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
