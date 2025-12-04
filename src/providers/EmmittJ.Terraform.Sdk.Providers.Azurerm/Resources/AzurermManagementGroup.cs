using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagementGroup.
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_management_group Terraform resource.
/// Manages a azurerm_management_group resource.
/// </summary>
public partial class AzurermManagementGroup(string name) : TerraformResource("azurerm_management_group", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentManagementGroupId
    {
        get => GetArgument<TerraformValue<string>>("parent_management_group_id");
        set => SetArgument("parent_management_group_id", value);
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubscriptionIds
    {
        get => GetArgument<TerraformSet<string>>("subscription_ids");
        set => SetArgument("subscription_ids", value);
    }

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformValue<string> TenantScopedId
        => AsReference("tenant_scoped_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
