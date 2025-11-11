using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    [TerraformPropertyName("certificate_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CertificatePermissions => new TerraformReference(this, "certificate_permissions");

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    [TerraformPropertyName("key_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> KeyPermissions => new TerraformReference(this, "key_permissions");

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    [TerraformPropertyName("secret_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecretPermissions => new TerraformReference(this, "secret_permissions");

}
