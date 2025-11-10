using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission_scope in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserPermissionScopeBlock : ITerraformBlock
{
    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceName is required")]
    [TerraformPropertyName("resource_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceName { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

}

/// <summary>
/// Block type for ssh_authorized_key in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountLocalUserSshAuthorizedKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountLocalUserTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("home_directory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HomeDirectory { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ssh_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SshKeyEnabled { get; set; }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ssh_password_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SshPasswordEnabled { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// Block for permission_scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("permission_scope")]
    public TerraformList<TerraformBlock<AzurermStorageAccountLocalUserPermissionScopeBlock>>? PermissionScope { get; set; } = new();

    /// <summary>
    /// Block for ssh_authorized_key.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ssh_authorized_key")]
    public TerraformList<TerraformBlock<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock>>? SshAuthorizedKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountLocalUserTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Password => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "password");

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformPropertyName("sid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sid");

}
