using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformValue<string> ParentManagementGroupId
    {
        get => new TerraformReference<string>(this, "parent_management_group_id");
        set => SetArgument("parent_management_group_id", value);
    }

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformSet<string> SubscriptionIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subscription_ids").ResolveNodes(ctx));
        set => SetArgument("subscription_ids", value);
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
    public AzurermManagementGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
