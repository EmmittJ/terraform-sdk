using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_link_access in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointResourceId is required")]
    [TerraformProperty("endpoint_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EndpointResourceId { get; set; }

    /// <summary>
    /// The endpoint_tenant_id attribute.
    /// </summary>
    [TerraformProperty("endpoint_tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EndpointTenantId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountNetworkRulesTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_storage_account_network_rules resource.
/// </summary>
public partial class AzurermStorageAccountNetworkRules : TerraformResource
{
    public AzurermStorageAccountNetworkRules(string name) : base("azurerm_storage_account_network_rules", name)
    {
    }

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformProperty("bypass")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Bypass { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformProperty("default_action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DefaultAction { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformProperty("ip_rules")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IpRules { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? VirtualNetworkSubnetIds { get; set; }

    /// <summary>
    /// Block for private_link_access.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("private_link_access")]
    public TerraformList<TerraformBlock<AzurermStorageAccountNetworkRulesPrivateLinkAccessBlock>>? PrivateLinkAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageAccountNetworkRulesTimeoutsBlock>? Timeouts { get; set; }

}
