using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for code_editor_app_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for jupyter_lab_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigJupyterLabImageConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for kernel_gateway_image_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_sagemaker_app_image_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerAppImageConfig : TerraformResource
{
    public AwsSagemakerAppImageConfig(string name) : base("aws_sagemaker_app_image_config", name)
    {
    }

    /// <summary>
    /// The app_image_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppImageConfigName is required")]
    [TerraformPropertyName("app_image_config_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppImageConfigName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for code_editor_app_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeEditorAppImageConfig block(s) allowed")]
    [TerraformPropertyName("code_editor_app_image_config")]
    public TerraformList<TerraformBlock<AwsSagemakerAppImageConfigCodeEditorAppImageConfigBlock>>? CodeEditorAppImageConfig { get; set; } = new();

    /// <summary>
    /// Block for jupyter_lab_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JupyterLabImageConfig block(s) allowed")]
    [TerraformPropertyName("jupyter_lab_image_config")]
    public TerraformList<TerraformBlock<AwsSagemakerAppImageConfigJupyterLabImageConfigBlock>>? JupyterLabImageConfig { get; set; } = new();

    /// <summary>
    /// Block for kernel_gateway_image_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KernelGatewayImageConfig block(s) allowed")]
    [TerraformPropertyName("kernel_gateway_image_config")]
    public TerraformList<TerraformBlock<AwsSagemakerAppImageConfigKernelGatewayImageConfigBlock>>? KernelGatewayImageConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
