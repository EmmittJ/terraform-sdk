using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for code_editor_app_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for jupyter_lab_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigJupyterLabImageConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for kernel_gateway_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_sagemaker_app_image_config resource.
/// </summary>
public class AwsSagemakerAppImageConfig : TerraformResource
{
    public AwsSagemakerAppImageConfig(string name) : base("aws_sagemaker_app_image_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    public required TerraformProperty<string> AppImageConfigName
    {
        get => GetProperty<TerraformProperty<string>>("app_image_config_name");
        set => this.WithProperty("app_image_config_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for code_editor_app_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppImageConfig block(s) allowed")]
    public List<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>? CodeEditorAppImageConfig
    {
        get => GetProperty<List<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>>("code_editor_app_image_config");
        set => this.WithProperty("code_editor_app_image_config", value);
    }

    /// <summary>
    /// Block for jupyter_lab_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabImageConfig block(s) allowed")]
    public List<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>? JupyterLabImageConfig
    {
        get => GetProperty<List<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>>("jupyter_lab_image_config");
        set => this.WithProperty("jupyter_lab_image_config", value);
    }

    /// <summary>
    /// Block for kernel_gateway_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayImageConfig block(s) allowed")]
    public List<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>? KernelGatewayImageConfig
    {
        get => GetProperty<List<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>>("kernel_gateway_image_config");
        set => this.WithProperty("kernel_gateway_image_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
