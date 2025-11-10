using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for model in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveDeploymentModelBlock : ITerraformBlock
{
    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Format { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveDeploymentSkuBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformPropertyName("family")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Family { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Size { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCognitiveDeploymentTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cognitive_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCognitiveDeployment : TerraformResource
{
    public AzurermCognitiveDeployment(string name) : base("azurerm_cognitive_deployment", name)
    {
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    [TerraformPropertyName("cognitive_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CognitiveAccountId { get; set; }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_throttling_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DynamicThrottlingEnabled { get; set; }

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
    /// The rai_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("rai_policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RaiPolicyName { get; set; }

    /// <summary>
    /// The version_upgrade_option attribute.
    /// </summary>
    [TerraformPropertyName("version_upgrade_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionUpgradeOption { get; set; }

    /// <summary>
    /// Block for model.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Model is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Model block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Model block(s) allowed")]
    [TerraformPropertyName("model")]
    public TerraformList<TerraformBlock<AzurermCognitiveDeploymentModelBlock>>? Model { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermCognitiveDeploymentSkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCognitiveDeploymentTimeoutsBlock>? Timeouts { get; set; } = new();

}
