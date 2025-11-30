using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagementGroupDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_management_group Terraform data source.
/// Retrieves information about a azurerm_management_group.
/// </summary>
public partial class AzurermManagementGroupDataSource(string name) : TerraformDataSource("azurerm_management_group", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    public TerraformList<string> AllManagementGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "all_management_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    public TerraformList<string> AllSubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "all_subscription_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    public TerraformList<string> ManagementGroupIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "management_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformValue<string> ParentManagementGroupId
    {
        get => new TerraformReference<string>(this, "parent_management_group_id");
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformList<string> SubscriptionIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subscription_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformValue<string> TenantScopedId
    {
        get => new TerraformReference<string>(this, "tenant_scoped_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
