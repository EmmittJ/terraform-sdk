using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermManagedApplicationPlanBlock() : TerraformBlock("plan")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformProperty("product")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    [TerraformProperty("promotion_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PromotionCode { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

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
public partial class AzurermManagedApplicationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_managed_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermManagedApplication : TerraformResource
{
    public AzurermManagedApplication(string name) : base("azurerm_managed_application", name)
    {
    }

    /// <summary>
    /// The application_definition_id attribute.
    /// </summary>
    [TerraformProperty("application_definition_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationDefinitionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformProperty("kind")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedResourceGroupName is required")]
    [TerraformProperty("managed_resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameter_values attribute.
    /// </summary>
    [TerraformProperty("parameter_values")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParameterValues { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformList<AzurermManagedApplicationPlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermManagedApplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformProperty("outputs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Outputs { get; }

}
