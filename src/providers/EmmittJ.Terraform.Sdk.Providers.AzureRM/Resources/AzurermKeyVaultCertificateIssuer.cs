using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for admin in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateIssuerAdminBlock
{
    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [TerraformPropertyName("first_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [TerraformPropertyName("last_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastName { get; set; }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    [TerraformPropertyName("phone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Phone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateIssuerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_certificate_issuer resource.
/// </summary>
public class AzurermKeyVaultCertificateIssuer : TerraformResource
{
    public AzurermKeyVaultCertificateIssuer(string name) : base("azurerm_key_vault_certificate_issuer", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrgId { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    [TerraformPropertyName("provider_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProviderName { get; set; }

    /// <summary>
    /// Block for admin.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("admin")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateIssuerAdminBlock>>? Admin { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateIssuerTimeoutsBlock>? Timeouts { get; set; }

}
