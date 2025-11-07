using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("recommendations");
    }

    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? FilterByCategory
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("filter_by_category");
        set => this.WithProperty("filter_by_category", value);
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? FilterByResourceGroups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("filter_by_resource_groups");
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
    /// The recommendations attribute.
    /// </summary>
    public TerraformExpression Recommendations => this["recommendations"];

}
