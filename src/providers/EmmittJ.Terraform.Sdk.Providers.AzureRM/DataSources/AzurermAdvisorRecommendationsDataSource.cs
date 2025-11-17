using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAdvisorRecommendationsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAdvisorRecommendationsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_advisor_recommendations Terraform data source.
/// Retrieves information about a azurerm_advisor_recommendations.
/// </summary>
public partial class AzurermAdvisorRecommendationsDataSource(string name) : TerraformDataSource("azurerm_advisor_recommendations", name)
{
    /// <summary>
    /// The filter_by_category attribute.
    /// </summary>
    public TerraformSet<string>? FilterByCategory
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_by_category").ResolveNodes(ctx));
        set => SetArgument("filter_by_category", value);
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    public TerraformSet<string>? FilterByResourceGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_by_resource_groups").ResolveNodes(ctx));
        set => SetArgument("filter_by_resource_groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Recommendations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "recommendations").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAdvisorRecommendationsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAdvisorRecommendationsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
