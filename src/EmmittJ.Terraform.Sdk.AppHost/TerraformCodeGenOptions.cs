namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Configuration options for Terraform code generation.
/// </summary>
public class TerraformCodeGenOptions
{
    /// <summary>
    /// Gets or sets the output directory for generated provider code.
    /// </summary>
    public string OutputDirectory { get; set; } = "providers";

    /// <summary>
    /// Gets or sets the working directory for Terraform operations.
    /// </summary>
    public string WorkingDirectory { get; set; } = ".terraform-codegen";

    /// <summary>
    /// Gets or sets the templates directory containing Mustache templates.
    /// </summary>
    public string TemplatesDirectory { get; set; } = "Templates/Files";
}
