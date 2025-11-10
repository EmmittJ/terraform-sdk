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
        set => SetProperty("resource_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        set => SetProperty("service", value);
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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("password");
        SetOutput("sid");
        SetOutput("home_directory");
        SetOutput("id");
        SetOutput("name");
        SetOutput("ssh_key_enabled");
        SetOutput("ssh_password_enabled");
        SetOutput("storage_account_id");
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformProperty<string> HomeDirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("home_directory");
        set => SetProperty("home_directory", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SshKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ssh_key_enabled");
        set => SetProperty("ssh_key_enabled", value);
    }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SshPasswordEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ssh_password_enabled");
        set => SetProperty("ssh_password_enabled", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for permission_scope.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountLocalUserPermissionScopeBlock>? PermissionScope
    {
        set => SetProperty("permission_scope", value);
    }

    /// <summary>
    /// Block for ssh_authorized_key.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>? SshAuthorizedKey
    {
        set => SetProperty("ssh_authorized_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountLocalUserTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
