using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultAccessPolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_access_policy resource.
/// </summary>
public partial class AzurermKeyVaultAccessPolicy : TerraformResource
{
    public AzurermKeyVaultAccessPolicy(string name) : base("azurerm_key_vault_access_policy", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformProperty("application_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApplicationId { get; set; }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    [TerraformProperty("certificate_permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CertificatePermissions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    [TerraformProperty("key_permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? KeyPermissions { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformProperty("object_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    [TerraformProperty("secret_permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SecretPermissions { get; set; }

    /// <summary>
    /// The storage_permissions attribute.
    /// </summary>
    [TerraformProperty("storage_permissions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? StoragePermissions { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultAccessPolicyTimeoutsBlock>? Timeouts { get; set; }

}
