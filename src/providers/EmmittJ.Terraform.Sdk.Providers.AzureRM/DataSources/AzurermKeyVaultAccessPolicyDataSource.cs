using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public partial class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
    {
    }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    [TerraformProperty("certificate_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> CertificatePermissions { get; }

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    [TerraformProperty("key_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> KeyPermissions { get; }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    [TerraformProperty("secret_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SecretPermissions { get; }

}
