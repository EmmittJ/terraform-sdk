using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAdvisorRecommendationsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformProperty<HashSet<TerraformProperty<string>>>? FilterByCategory { get; set; }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    [TerraformPropertyName("filter_by_resource_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? FilterByResourceGroups { get; set; }

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
    public TerraformBlock<AzurermAdvisorRecommendationsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    [TerraformPropertyName("recommendations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Recommendations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "recommendations");

}
