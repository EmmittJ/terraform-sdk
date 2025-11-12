using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for launch in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudBuildPackBindingLaunchBlock() : TerraformBlock("launch")
{
    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    [TerraformProperty("secrets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Secrets { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudBuildPackBindingTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_spring_cloud_build_pack_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudBuildPackBinding : TerraformResource
{
    public AzurermSpringCloudBuildPackBinding(string name) : base("azurerm_spring_cloud_build_pack_binding", name)
    {
    }

    /// <summary>
    /// The binding_type attribute.
    /// </summary>
    [TerraformProperty("binding_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BindingType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudBuilderId is required")]
    [TerraformProperty("spring_cloud_builder_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudBuilderId { get; set; }

    /// <summary>
    /// Block for launch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Launch block(s) allowed")]
    [TerraformProperty("launch")]
    public TerraformList<AzurermSpringCloudBuildPackBindingLaunchBlock> Launch { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudBuildPackBindingTimeoutsBlock Timeouts { get; set; } = new();

}
