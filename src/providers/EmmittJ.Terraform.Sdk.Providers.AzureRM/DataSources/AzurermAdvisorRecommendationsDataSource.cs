using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAdvisorRecommendationsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_advisor_recommendations.
/// </summary>
public partial class AzurermAdvisorRecommendationsDataSource : TerraformDataSource
{
    public AzurermAdvisorRecommendationsDataSource(string name) : base("azurerm_advisor_recommendations", name)
    {
    }

    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    [TerraformProperty("filter_by_category")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? FilterByCategory { get; set; }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    [TerraformProperty("filter_by_resource_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? FilterByResourceGroups { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermAdvisorRecommendationsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    [TerraformProperty("recommendations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Recommendations { get; }

}
