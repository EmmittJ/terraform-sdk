using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoClusterCustomerManagedKeyTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_kusto_cluster_customer_managed_key resource.
/// </summary>
public partial class AzurermKustoClusterCustomerManagedKey : TerraformResource
{
    public AzurermKustoClusterCustomerManagedKey(string name) : base("azurerm_kusto_cluster_customer_managed_key", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultId { get; set; }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    [TerraformProperty("key_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVersion { get; set; }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [TerraformProperty("managed_hsm_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedHsmKeyId { get; set; }

    /// <summary>
    /// The user_identity attribute.
    /// </summary>
    [TerraformProperty("user_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserIdentity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKustoClusterCustomerManagedKeyTimeoutsBlock>? Timeouts { get; set; }

}
