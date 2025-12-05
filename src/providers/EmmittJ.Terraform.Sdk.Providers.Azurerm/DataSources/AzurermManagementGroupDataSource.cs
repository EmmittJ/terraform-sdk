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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    public TerraformList<string> AllManagementGroupIds
        => CreateReference("all_management_group_ids");

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    public TerraformList<string> AllSubscriptionIds
        => CreateReference("all_subscription_ids");

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    public TerraformList<string> ManagementGroupIds
        => CreateReference("management_group_ids");

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformValue<string> ParentManagementGroupId
        => CreateReference("parent_management_group_id");

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformList<string> SubscriptionIds
        => CreateReference("subscription_ids");

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformValue<string> TenantScopedId
        => CreateReference("tenant_scoped_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
