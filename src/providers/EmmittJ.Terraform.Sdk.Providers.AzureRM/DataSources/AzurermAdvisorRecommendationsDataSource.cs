using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAdvisorRecommendationsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_advisor_recommendations.
/// </summary>
public class AzurermAdvisorRecommendationsDataSource : TerraformDataSource
{
    public AzurermAdvisorRecommendationsDataSource(string name) : base("azurerm_advisor_recommendations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("recommendations");
    }

    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FilterByCategory
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("filter_by_category");
        set => this.WithProperty("filter_by_category", value);
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FilterByResourceGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("filter_by_resource_groups");
        set => this.WithProperty("filter_by_resource_groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAdvisorRecommendationsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAdvisorRecommendationsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    public TerraformExpression Recommendations => this["recommendations"];

}
