using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry_cache_rule.
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSource : TerraformDataSource
{
    public AzurermContainerRegistryCacheRuleDataSource(string name) : base("azurerm_container_registry_cache_rule", name)
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    [TerraformPropertyName("container_registry_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerRegistryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    [TerraformPropertyName("credential_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CredentialSetId => new TerraformReference(this, "credential_set_id");

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    [TerraformPropertyName("source_repo")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceRepo => new TerraformReference(this, "source_repo");

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    [TerraformPropertyName("target_repo")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TargetRepo => new TerraformReference(this, "target_repo");

}
