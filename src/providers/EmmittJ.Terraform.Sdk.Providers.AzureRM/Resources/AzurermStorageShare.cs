using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for acl in AzurermStorageShare.
/// Nesting mode: set
/// </summary>
public class AzurermStorageShareAclBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acl";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// AccessPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageShareAclBlockAccessPolicyBlock>? AccessPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageShareAclBlockAccessPolicyBlock>>("access_policy");
        set => SetArgument("access_policy", value);
    }

}

/// <summary>
/// Block type for access_policy in AzurermStorageShareAclBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageShareAclBlockAccessPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_policy";

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformValue<string>? Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformValue<string> Permissions
    {
        get => new TerraformReference<string>(this, "permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    public TerraformValue<string>? Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageShare.
/// Nesting mode: single
/// </summary>
public class AzurermStorageShareTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_share Terraform resource.
/// Manages a azurerm_storage_share resource.
/// </summary>
public partial class AzurermStorageShare(string name) : TerraformResource("azurerm_storage_share", name)
{
    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The enabled_protocol attribute.
    /// </summary>
    public TerraformValue<string>? EnabledProtocol
    {
        get => new TerraformReference<string>(this, "enabled_protocol");
        set => SetArgument("enabled_protocol", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The quota attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quota is required")]
    public required TerraformValue<double> Quota
    {
        get => new TerraformReference<double>(this, "quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

    /// <summary>
    /// Acl block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermStorageShareAclBlock>? Acl
    {
        get => GetArgument<TerraformSet<AzurermStorageShareAclBlock>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageShareTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageShareTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
