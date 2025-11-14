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
public class AzurermManagementGroupDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_management_group.
/// </summary>
public class AzurermManagementGroupDataSource : TerraformDataSource
{
    public AzurermManagementGroupDataSource(string name) : base("azurerm_management_group", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagementGroupDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    [TerraformArgument("all_management_group_ids")]
    public TerraformList<string> AllManagementGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "all_management_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    [TerraformArgument("all_subscription_ids")]
    public TerraformList<string> AllSubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "all_subscription_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    [TerraformArgument("management_group_ids")]
    public TerraformList<string> ManagementGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "management_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    [TerraformArgument("parent_management_group_id")]
    public TerraformValue<string> ParentManagementGroupId
    {
        get => new TerraformReference<string>(this, "parent_management_group_id");
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    [TerraformArgument("subscription_ids")]
    public TerraformList<string> SubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subscription_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    [TerraformArgument("tenant_scoped_id")]
    public TerraformValue<string> TenantScopedId
    {
        get => new TerraformReference<string>(this, "tenant_scoped_id");
    }

}
