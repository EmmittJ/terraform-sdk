using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("filter_by_category")]
    public TerraformSet<string>? FilterByCategory
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_by_category").ResolveNodes(ctx));
        set => SetArgument("filter_by_category", value);
    }

    /// <summary>
    /// The filter_by_resource_groups attribute.
    /// </summary>
    [TerraformArgument("filter_by_resource_groups")]
    public TerraformSet<string>? FilterByResourceGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filter_by_resource_groups").ResolveNodes(ctx));
        set => SetArgument("filter_by_resource_groups", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAdvisorRecommendationsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The recommendations attribute.
    /// </summary>
    [TerraformArgument("recommendations")]
    public TerraformList<object> Recommendations
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "recommendations").ResolveNodes(ctx));
    }

}
