using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for acl in AzurermStorageTable.
/// Nesting mode: set
/// </summary>
public class AzurermStorageTableAclBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// AccessPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageTableAclBlockAccessPolicyBlock>? AccessPolicy
    {
        get => GetArgument<TerraformList<AzurermStorageTableAclBlockAccessPolicyBlock>>("access_policy");
        set => SetArgument("access_policy", value);
    }

}

/// <summary>
/// Block type for access_policy in AzurermStorageTableAclBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageTableAclBlockAccessPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_policy";

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiry is required")]
    public required TerraformValue<string> Expiry
    {
        get => GetRequiredArgument<TerraformValue<string>>("expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformValue<string> Permissions
    {
        get => GetRequiredArgument<TerraformValue<string>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => GetRequiredArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageTable.
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_table Terraform resource.
/// Manages a azurerm_storage_table resource.
/// </summary>
public partial class AzurermStorageTable(string name) : TerraformResource("azurerm_storage_table", name)
{
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The Resource Manager ID of this Storage Table.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
        => CreateReference("resource_manager_id");

    /// <summary>
    /// Acl block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermStorageTableAclBlock>? Acl
    {
        get => GetArgument<TerraformSet<AzurermStorageTableAclBlock>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
