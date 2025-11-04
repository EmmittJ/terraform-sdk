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
    public HashSet<string>? FilterByCategory
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("filter_by_category")?.Value;
        set => this.WithProperty("filter_by_category", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    public HashSet<string>? FilterByResourceGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("filter_by_resource_groups")?.Value;
        set => this.WithProperty("filter_by_resource_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    public TerraformExpression Recommendations => this["recommendations"];

}
