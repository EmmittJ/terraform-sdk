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
        set => SetProperty("read", value);
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
        SetOutput("recommendations");
        SetOutput("filter_by_category");
        SetOutput("filter_by_resource_groups");
        SetOutput("id");
    }

    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> FilterByCategory
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("filter_by_category");
        set => SetProperty("filter_by_category", value);
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> FilterByResourceGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("filter_by_resource_groups");
        set => SetProperty("filter_by_resource_groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAdvisorRecommendationsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    public TerraformExpression Recommendations => this["recommendations"];

}
