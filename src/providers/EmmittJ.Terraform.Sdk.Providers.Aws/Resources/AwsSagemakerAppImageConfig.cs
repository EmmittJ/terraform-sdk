using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for code_editor_app_image_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for jupyter_lab_image_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerAppImageConfigJupyterLabImageConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for kernel_gateway_image_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_sagemaker_app_image_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerAppImageConfig : TerraformResource
{
    public AwsSagemakerAppImageConfig(string name) : base("aws_sagemaker_app_image_config", name)
    {
    }

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    [TerraformProperty("app_image_config_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppImageConfigName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for code_editor_app_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppImageConfig block(s) allowed")]
    [TerraformProperty("code_editor_app_image_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>>? CodeEditorAppImageConfig { get; set; }

    /// <summary>
    /// Block for jupyter_lab_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabImageConfig block(s) allowed")]
    [TerraformProperty("jupyter_lab_image_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>>? JupyterLabImageConfig { get; set; }

    /// <summary>
    /// Block for kernel_gateway_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayImageConfig block(s) allowed")]
    [TerraformProperty("kernel_gateway_image_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>>? KernelGatewayImageConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
