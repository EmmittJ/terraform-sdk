using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupTemplateDeploymentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_resource_group_template_deployment resource.
/// </summary>
public class AzurermResourceGroupTemplateDeployment : TerraformResource
{
    public AzurermResourceGroupTemplateDeployment(string name) : base("azurerm_resource_group_template_deployment", name)
    {
    }

    /// <summary>
    /// The debug_level attribute.
    /// </summary>
    [TerraformPropertyName("debug_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DebugLevel { get; set; }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentMode is required")]
    [TerraformPropertyName("deployment_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    [TerraformPropertyName("parameters_content")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParametersContent { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameters_content");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    [TerraformPropertyName("template_content")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TemplateContent { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_content");

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    [TerraformPropertyName("template_spec_version_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateSpecVersionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermResourceGroupTemplateDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    [TerraformPropertyName("output_content")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutputContent => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_content");

}
