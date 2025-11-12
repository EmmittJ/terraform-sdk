using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for admin in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultCertificateIssuerAdminBlock() : TerraformBlock("admin")
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformProperty("email_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformProperty("first_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformProperty("last_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    [TerraformProperty("phone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Phone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateIssuerTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_key_vault_certificate_issuer resource.
/// </summary>
public partial class AzurermKeyVaultCertificateIssuer : TerraformResource
{
    public AzurermKeyVaultCertificateIssuer(string name) : base("azurerm_key_vault_certificate_issuer", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformProperty("org_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrgId { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    [TerraformProperty("provider_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProviderName { get; set; }

    /// <summary>
    /// Block for admin.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("admin")]
    public TerraformList<AzurermKeyVaultCertificateIssuerAdminBlock> Admin { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultCertificateIssuerTimeoutsBlock Timeouts { get; set; } = new();

}
