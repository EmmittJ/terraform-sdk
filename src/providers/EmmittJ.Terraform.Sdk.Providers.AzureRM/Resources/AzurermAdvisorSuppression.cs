using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAdvisorSuppressionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_advisor_suppression resource.
/// </summary>
public partial class AzurermAdvisorSuppression : TerraformResource
{
    public AzurermAdvisorSuppression(string name) : base("azurerm_advisor_suppression", name)
    {
    }

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
    /// The recommendation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecommendationId is required")]
    [TerraformProperty("recommendation_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecommendationId { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ttl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAdvisorSuppressionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The suppression_id attribute.
    /// </summary>
    [TerraformProperty("suppression_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SuppressionId { get; }

}
