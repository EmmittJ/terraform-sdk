using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermChaosStudioCapabilityTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_chaos_studio_capability resource.
/// </summary>
public class AzurermChaosStudioCapability : TerraformResource
{
    public AzurermChaosStudioCapability(string name) : base("azurerm_chaos_studio_capability", name)
    {
    }

    /// <summary>
    /// The capability_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapabilityType is required")]
    [TerraformPropertyName("capability_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CapabilityType { get; set; }

    /// <summary>
    /// The chaos_studio_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetId is required")]
    [TerraformPropertyName("chaos_studio_target_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ChaosStudioTargetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermChaosStudioCapabilityTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The urn attribute.
    /// </summary>
    [TerraformPropertyName("urn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Urn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "urn");

}
