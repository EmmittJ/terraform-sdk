using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for permission_scope in AzurermStorageAccountLocalUser.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserPermissionScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permission_scope";

    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceName is required")]
    public required TerraformValue<string> ResourceName
    {
        get => new TerraformReference<string>(this, "resource_name");
        set => SetArgument("resource_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public required TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlockPermissionsBlock> Permissions
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlockPermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

}

/// <summary>
/// Block type for permissions in AzurermStorageAccountLocalUserPermissionScopeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserPermissionScopeBlockPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<bool>? Create
    {
        get => new TerraformReference<bool>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<bool>? Delete
    {
        get => new TerraformReference<bool>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The list attribute.
    /// </summary>
    public TerraformValue<bool>? List
    {
        get => new TerraformReference<bool>(this, "list");
        set => SetArgument("list", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<bool>? Read
    {
        get => new TerraformReference<bool>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    public TerraformValue<bool>? Write
    {
        get => new TerraformReference<bool>(this, "write");
        set => SetArgument("write", value);
    }

}


/// <summary>
/// Block type for ssh_authorized_key in AzurermStorageAccountLocalUser.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserSshAuthorizedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssh_authorized_key";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccountLocalUser.
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountLocalUserTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_account_local_user Terraform resource.
/// Manages a azurerm_storage_account_local_user resource.
/// </summary>
public partial class AzurermStorageAccountLocalUser(string name) : TerraformResource("azurerm_storage_account_local_user", name)
{
    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformValue<string>? HomeDirectory
    {
        get => new TerraformReference<string>(this, "home_directory");
        set => SetArgument("home_directory", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SshKeyEnabled
    {
        get => new TerraformReference<bool>(this, "ssh_key_enabled");
        set => SetArgument("ssh_key_enabled", value);
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SshPasswordEnabled
    {
        get => new TerraformReference<bool>(this, "ssh_password_enabled");
        set => SetArgument("ssh_password_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformValue<string> Sid
    {
        get => new TerraformReference<string>(this, "sid");
    }

    /// <summary>
    /// PermissionScope block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlock>? PermissionScope
    {
        get => GetArgument<TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlock>>("permission_scope");
        set => SetArgument("permission_scope", value);
    }

    /// <summary>
    /// SshAuthorizedKey block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>? SshAuthorizedKey
    {
        get => GetArgument<TerraformList<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>>("ssh_authorized_key");
        set => SetArgument("ssh_authorized_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountLocalUserTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountLocalUserTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
