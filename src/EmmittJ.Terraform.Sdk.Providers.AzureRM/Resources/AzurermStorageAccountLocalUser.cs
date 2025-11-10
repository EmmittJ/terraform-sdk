using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission_scope in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserPermissionScopeBlock : TerraformBlock
{
    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceName is required")]
    public required TerraformProperty<string> ResourceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_name");
        set => WithProperty("resource_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
    }

}

/// <summary>
/// Block type for ssh_authorized_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserSshAuthorizedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountLocalUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_account_local_user resource.
/// </summary>
public class AzurermStorageAccountLocalUser : TerraformResource
{
    public AzurermStorageAccountLocalUser(string name) : base("azurerm_storage_account_local_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("password");
        this.DeclareOutput("sid");
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformProperty<string>? HomeDirectory
    {
        get => GetProperty<TerraformProperty<string>>("home_directory");
        set => this.WithProperty("home_directory", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SshKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssh_key_enabled");
        set => this.WithProperty("ssh_key_enabled", value);
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SshPasswordEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssh_password_enabled");
        set => this.WithProperty("ssh_password_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for permission_scope.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountLocalUserPermissionScopeBlock>? PermissionScope
    {
        get => GetProperty<List<AzurermStorageAccountLocalUserPermissionScopeBlock>>("permission_scope");
        set => this.WithProperty("permission_scope", value);
    }

    /// <summary>
    /// Block for ssh_authorized_key.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>? SshAuthorizedKey
    {
        get => GetProperty<List<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>>("ssh_authorized_key");
        set => this.WithProperty("ssh_authorized_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountLocalUserTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountLocalUserTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformExpression Password => this["password"];

    /// <summary>
    /// The sid attribute.
    /// </summary>
    public TerraformExpression Sid => this["sid"];

}
