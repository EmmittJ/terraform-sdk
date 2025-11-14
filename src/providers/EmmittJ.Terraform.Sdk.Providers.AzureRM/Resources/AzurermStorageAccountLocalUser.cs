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
/// Block type for permission_scope in .
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
    [TerraformArgument("resource_name")]
    public required TerraformValue<string> ResourceName
    {
        get => new TerraformReference<string>(this, "resource_name");
        set => SetArgument("resource_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformArgument("service")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for ssh_authorized_key in .
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
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformArgument("key")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_account_local_user resource.
/// </summary>
public class AzurermStorageAccountLocalUser : TerraformResource
{
    public AzurermStorageAccountLocalUser(string name) : base("azurerm_storage_account_local_user", name)
    {
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    [TerraformArgument("home_directory")]
    public TerraformValue<string>? HomeDirectory
    {
        get => new TerraformReference<string>(this, "home_directory");
        set => SetArgument("home_directory", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    [TerraformArgument("ssh_key_enabled")]
    public TerraformValue<bool>? SshKeyEnabled
    {
        get => new TerraformReference<bool>(this, "ssh_key_enabled");
        set => SetArgument("ssh_key_enabled", value);
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    [TerraformArgument("ssh_password_enabled")]
    public TerraformValue<bool>? SshPasswordEnabled
    {
        get => new TerraformReference<bool>(this, "ssh_password_enabled");
        set => SetArgument("ssh_password_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Block for permission_scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("permission_scope")]
    public TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlock> PermissionScope { get; set; } = new();

    /// <summary>
    /// Block for ssh_authorized_key.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ssh_authorized_key")]
    public TerraformList<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock> SshAuthorizedKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountLocalUserTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformArgument("sid")]
    public TerraformValue<string> Sid
    {
        get => new TerraformReference<string>(this, "sid");
    }

}
