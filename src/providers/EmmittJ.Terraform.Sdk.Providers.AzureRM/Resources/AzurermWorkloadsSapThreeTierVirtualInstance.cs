using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for three_tier_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    [TerraformProperty("app_resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppResourceGroupName { get; set; }

    /// <summary>
    /// The high_availability_type attribute.
    /// </summary>
    [TerraformProperty("high_availability_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HighAvailabilityType { get; set; }

    /// <summary>
    /// The secondary_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("secondary_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SecondaryIpEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_workloads_sap_three_tier_virtual_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermWorkloadsSapThreeTierVirtualInstance : TerraformResource
{
    public AzurermWorkloadsSapThreeTierVirtualInstance(string name) : base("azurerm_workloads_sap_three_tier_virtual_instance", name)
    {
    }

    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    [TerraformProperty("app_location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppLocation { get; set; }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Environment { get; set; }

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
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    [TerraformProperty("managed_resources_network_access_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedResourcesNetworkAccessType { get; set; }

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
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    [TerraformProperty("sap_fqdn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SapFqdn { get; set; }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    [TerraformProperty("sap_product")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SapProduct { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for three_tier_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreeTierConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ThreeTierConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreeTierConfiguration block(s) allowed")]
    [TerraformProperty("three_tier_configuration")]
    public TerraformList<TerraformBlock<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock>>? ThreeTierConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock>? Timeouts { get; set; }

}
