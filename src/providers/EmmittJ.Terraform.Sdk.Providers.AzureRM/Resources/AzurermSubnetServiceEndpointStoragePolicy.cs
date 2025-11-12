using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSubnetServiceEndpointStoragePolicyDefinitionBlock() : TerraformBlock("definition")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [TerraformProperty("service")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// The service_resources attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResources is required")]
    [TerraformProperty("service_resources")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> ServiceResources { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSubnetServiceEndpointStoragePolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_subnet_service_endpoint_storage_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSubnetServiceEndpointStoragePolicy : TerraformResource
{
    public AzurermSubnetServiceEndpointStoragePolicy(string name) : base("azurerm_subnet_service_endpoint_storage_policy", name)
    {
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Definition block(s) allowed")]
    [TerraformProperty("definition")]
    public TerraformList<AzurermSubnetServiceEndpointStoragePolicyDefinitionBlock> Definition { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSubnetServiceEndpointStoragePolicyTimeoutsBlock Timeouts { get; set; } = new();

}
