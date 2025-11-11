using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for elasticity_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxReadyCapacity is required")]
    [TerraformProperty("max_ready_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxReadyCapacity { get; set; }

    /// <summary>
    /// The min_ready_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinReadyCapacity is required")]
    [TerraformProperty("min_ready_capacity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinReadyCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set_standby_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualMachineScaleSetStandbyPool : TerraformResource
{
    public AzurermVirtualMachineScaleSetStandbyPool(string name) : base("azurerm_virtual_machine_scale_set_standby_pool", name)
    {
    }

    /// <summary>
    /// The attached_virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedVirtualMachineScaleSetId is required")]
    [TerraformProperty("attached_virtual_machine_scale_set_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AttachedVirtualMachineScaleSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineState is required")]
    [TerraformProperty("virtual_machine_state")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualMachineState { get; set; }

    /// <summary>
    /// Block for elasticity_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticityProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ElasticityProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticityProfile block(s) allowed")]
    [TerraformProperty("elasticity_profile")]
    public TerraformList<TerraformBlock<AzurermVirtualMachineScaleSetStandbyPoolElasticityProfileBlock>>? ElasticityProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualMachineScaleSetStandbyPoolTimeoutsBlock>? Timeouts { get; set; }

}
