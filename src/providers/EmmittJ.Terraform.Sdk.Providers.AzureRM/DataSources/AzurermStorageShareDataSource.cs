using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for acl in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageShareDataSourceAclBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acl";

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageShareDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_share Terraform data source.
/// Retrieves information about a azurerm_storage_share.
/// </summary>
public partial class AzurermStorageShareDataSource(string name) : TerraformDataSource("azurerm_storage_share", name)
{
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
    public TerraformValue<string>? StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The quota attribute.
    /// </summary>
    public TerraformValue<double> Quota
    {
        get => new TerraformReference<double>(this, "quota");
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
    /// Acl block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageShareDataSourceAclBlock>? Acl
    {
        get => GetArgument<TerraformList<AzurermStorageShareDataSourceAclBlock>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageShareDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageShareDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
