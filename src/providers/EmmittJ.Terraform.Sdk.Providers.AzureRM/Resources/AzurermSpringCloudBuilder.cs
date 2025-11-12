using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for build_pack_group in .
/// Nesting mode: set
/// </summary>
public partial class AzurermSpringCloudBuilderBuildPackGroupBlock() : TerraformBlock("build_pack_group")
{
    /// <summary>
    /// The build_pack_ids attribute.
    /// </summary>
    [TerraformProperty("build_pack_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? BuildPackIds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for stack in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudBuilderStackBlock() : TerraformBlock("stack")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudBuilderTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_spring_cloud_builder resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudBuilder : TerraformResource
{
    public AzurermSpringCloudBuilder(string name) : base("azurerm_spring_cloud_builder", name)
    {
    }

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
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for build_pack_group.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BuildPackGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BuildPackGroup block(s) required")]
    [TerraformProperty("build_pack_group")]
    public required TerraformSet<AzurermSpringCloudBuilderBuildPackGroupBlock> BuildPackGroup { get; set; } = new();

    /// <summary>
    /// Block for stack.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stack is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Stack block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stack block(s) allowed")]
    [TerraformProperty("stack")]
    public required TerraformList<AzurermSpringCloudBuilderStackBlock> Stack { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudBuilderTimeoutsBlock Timeouts { get; set; } = new();

}
