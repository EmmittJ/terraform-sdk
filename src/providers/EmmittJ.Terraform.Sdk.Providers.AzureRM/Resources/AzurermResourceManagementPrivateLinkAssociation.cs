using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourceManagementPrivateLinkAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_resource_management_private_link_association resource.
/// </summary>
public partial class AzurermResourceManagementPrivateLinkAssociation : TerraformResource
{
    public AzurermResourceManagementPrivateLinkAssociation(string name) : base("azurerm_resource_management_private_link_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetworkAccessEnabled is required")]
    [TerraformProperty("public_network_access_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_management_private_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceManagementPrivateLinkId is required")]
    [TerraformProperty("resource_management_private_link_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceManagementPrivateLinkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermResourceManagementPrivateLinkAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
