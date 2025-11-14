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
public class AzurermSubscriptionsDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_subscriptions.
/// </summary>
public class AzurermSubscriptionsDataSource : TerraformDataSource
{
    public AzurermSubscriptionsDataSource(string name) : base("azurerm_subscriptions", name)
    {
    }

    /// <summary>
    /// The display_name_contains attribute.
    /// </summary>
    [TerraformArgument("display_name_contains")]
    public TerraformValue<string>? DisplayNameContains
    {
        get => new TerraformReference<string>(this, "display_name_contains");
        set => SetArgument("display_name_contains", value);
    }

    /// <summary>
    /// The display_name_prefix attribute.
    /// </summary>
    [TerraformArgument("display_name_prefix")]
    public TerraformValue<string>? DisplayNamePrefix
    {
        get => new TerraformReference<string>(this, "display_name_prefix");
        set => SetArgument("display_name_prefix", value);
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
    public AzurermSubscriptionsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The subscriptions attribute.
    /// </summary>
    [TerraformArgument("subscriptions")]
    public TerraformList<object> Subscriptions
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "subscriptions").ResolveNodes(ctx));
    }

}
