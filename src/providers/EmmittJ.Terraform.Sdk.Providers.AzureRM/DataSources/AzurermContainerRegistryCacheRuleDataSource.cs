using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> ContainerRegistryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerRegistryCacheRuleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The credential_set_id attribute.
    /// </summary>
    [TerraformPropertyName("credential_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CredentialSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "credential_set_id");

    /// <summary>
    /// The source_repo attribute.
    /// </summary>
    [TerraformPropertyName("source_repo")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceRepo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_repo");

    /// <summary>
    /// The target_repo attribute.
    /// </summary>
    [TerraformPropertyName("target_repo")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetRepo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_repo");

}
