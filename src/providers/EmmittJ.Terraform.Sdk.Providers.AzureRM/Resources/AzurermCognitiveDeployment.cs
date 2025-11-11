using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for model in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveDeploymentModelBlock : TerraformBlockBase
{
    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Format { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveDeploymentSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformProperty("family")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Family { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Size { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCognitiveDeploymentTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cognitive_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCognitiveDeployment : TerraformResource
{
    public AzurermCognitiveDeployment(string name) : base("azurerm_cognitive_deployment", name)
    {
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    [TerraformProperty("cognitive_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CognitiveAccountId { get; set; }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_throttling_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicThrottlingEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The rai_policy_name attribute.
    /// </summary>
    [TerraformProperty("rai_policy_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RaiPolicyName { get; set; }

    /// <summary>
    /// The version_upgrade_option attribute.
    /// </summary>
    [TerraformProperty("version_upgrade_option")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionUpgradeOption { get; set; }

    /// <summary>
    /// Block for model.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Model is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Model block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Model block(s) allowed")]
    [TerraformProperty("model")]
    public TerraformList<TerraformBlock<AzurermCognitiveDeploymentModelBlock>>? Model { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public TerraformList<TerraformBlock<AzurermCognitiveDeploymentSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCognitiveDeploymentTimeoutsBlock>? Timeouts { get; set; }

}
