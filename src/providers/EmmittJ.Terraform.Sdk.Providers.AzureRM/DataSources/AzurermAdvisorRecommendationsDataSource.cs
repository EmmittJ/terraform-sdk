using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAdvisorRecommendationsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_advisor_recommendations.
/// </summary>
public class AzurermAdvisorRecommendationsDataSource : TerraformDataSource
{
    public AzurermAdvisorRecommendationsDataSource(string name) : base("azurerm_advisor_recommendations", name)
    {
    }

    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    [TerraformPropertyName("filter_by_category")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? FilterByCategory { get; set; }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    [TerraformPropertyName("filter_by_resource_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? FilterByResourceGroups { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAdvisorRecommendationsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    [TerraformPropertyName("recommendations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Recommendations => new TerraformReference(this, "recommendations");

}
