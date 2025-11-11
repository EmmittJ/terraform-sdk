using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagementGroupTemplateDeploymentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_management_group_template_deployment resource.
/// </summary>
public partial class AzurermManagementGroupTemplateDeployment : TerraformResource
{
    public AzurermManagementGroupTemplateDeployment(string name) : base("azurerm_management_group_template_deployment", name)
    {
    }

    /// <summary>
    /// The debug_level attribute.
    /// </summary>
    [TerraformProperty("debug_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DebugLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    [TerraformProperty("management_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagementGroupId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    [TerraformProperty("parameters_content")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParametersContent { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    [TerraformProperty("template_content")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateContent { get; set; }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    [TerraformProperty("template_spec_version_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateSpecVersionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermManagementGroupTemplateDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    [TerraformProperty("output_content")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutputContent { get; }

}
