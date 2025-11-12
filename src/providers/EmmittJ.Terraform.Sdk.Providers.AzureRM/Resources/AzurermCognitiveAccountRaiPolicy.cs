using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for content_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountRaiPolicyContentFilterBlock() : TerraformBlock("content_filter")
{
    /// <summary>
    /// The block_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlockEnabled is required")]
    [TerraformProperty("block_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> BlockEnabled { get; set; }

    /// <summary>
    /// The filter_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterEnabled is required")]
    [TerraformProperty("filter_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> FilterEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The severity_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeverityThreshold is required")]
    [TerraformProperty("severity_threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SeverityThreshold { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCognitiveAccountRaiPolicyTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_cognitive_account_rai_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCognitiveAccountRaiPolicy : TerraformResource
{
    public AzurermCognitiveAccountRaiPolicy(string name) : base("azurerm_cognitive_account_rai_policy", name)
    {
    }

    /// <summary>
    /// The base_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasePolicyName is required")]
    [TerraformProperty("base_policy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BasePolicyName { get; set; }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    [TerraformProperty("cognitive_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CognitiveAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for content_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentFilter block(s) required")]
    [TerraformProperty("content_filter")]
    public required TerraformList<AzurermCognitiveAccountRaiPolicyContentFilterBlock> ContentFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCognitiveAccountRaiPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
