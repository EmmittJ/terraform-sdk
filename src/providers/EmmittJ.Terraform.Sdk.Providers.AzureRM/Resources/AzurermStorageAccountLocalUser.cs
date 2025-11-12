using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permission_scope in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountLocalUserPermissionScopeBlock() : TerraformBlock("permission_scope")
{
    /// <summary>
    /// The resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceName is required")]
    [TerraformProperty("resource_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceName { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for ssh_authorized_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountLocalUserSshAuthorizedKeyBlock() : TerraformBlock("ssh_authorized_key")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountLocalUserTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_account_local_user resource.
/// </summary>
public partial class AzurermStorageAccountLocalUser : TerraformResource
{
    public AzurermStorageAccountLocalUser(string name) : base("azurerm_storage_account_local_user", name)
    {
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    [TerraformProperty("home_directory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HomeDirectory { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ssh_key_enabled attribute.
    /// </summary>
    [TerraformProperty("ssh_key_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SshKeyEnabled { get; set; }

    /// <summary>
    /// The ssh_password_enabled attribute.
    /// </summary>
    [TerraformProperty("ssh_password_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SshPasswordEnabled { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for permission_scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("permission_scope")]
    public TerraformList<AzurermStorageAccountLocalUserPermissionScopeBlock> PermissionScope { get; set; } = new();

    /// <summary>
    /// Block for ssh_authorized_key.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ssh_authorized_key")]
    public TerraformList<AzurermStorageAccountLocalUserSshAuthorizedKeyBlock> SshAuthorizedKey { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStorageAccountLocalUserTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Password { get; }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [TerraformProperty("sid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sid { get; }

}
