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
        SetOutput("arns");
        SetOutput("names");
        SetOutput("types");
        SetOutput("values");
        SetOutput("id");
        SetOutput("path");
        SetOutput("recursive");
        SetOutput("region");
        SetOutput("with_decryption");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    public TerraformProperty<bool> Recursive
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("recursive");
        set => SetProperty("recursive", value);
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
    /// The with_decryption attribute.
    /// </summary>
    public TerraformProperty<bool> WithDecryption
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("with_decryption");
        set => SetProperty("with_decryption", value);
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
