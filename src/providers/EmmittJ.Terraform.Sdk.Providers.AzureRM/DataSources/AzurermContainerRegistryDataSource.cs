using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerRegistryDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry.
/// </summary>
public partial class AzurermContainerRegistryDataSource : TerraformDataSource
{
    public AzurermContainerRegistryDataSource(string name) : base("azurerm_container_registry", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermContainerRegistryDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformProperty("admin_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AdminEnabled { get; }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminPassword { get; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminUsername { get; }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("data_endpoint_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DataEndpointEnabled { get; }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformProperty("data_endpoint_host_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DataEndpointHostNames { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [TerraformProperty("login_server")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoginServer { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
