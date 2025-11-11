using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry_cache_rule.
/// </summary>
public partial class AzurermContainerRegistryCacheRuleDataSource : TerraformDataSource
{
    public AzurermContainerRegistryCacheRuleDataSource(string name) : base("azurerm_container_registry_cache_rule", name)
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformProperty("container_registry_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerRegistryId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    [TerraformProperty("credential_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CredentialSetId { get; }

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    [TerraformProperty("source_repo")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceRepo { get; }

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    [TerraformProperty("target_repo")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetRepo { get; }

}
