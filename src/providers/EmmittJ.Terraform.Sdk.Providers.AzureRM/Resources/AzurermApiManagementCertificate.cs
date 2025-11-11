using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementCertificateTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_certificate resource.
/// </summary>
public partial class AzurermApiManagementCertificate : TerraformResource
{
    public AzurermApiManagementCertificate(string name) : base("azurerm_api_management_certificate", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The data attribute.
    /// </summary>
    [TerraformProperty("data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Data { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultIdentityClientId { get; set; }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expiration { get; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformProperty("subject")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Subject { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

}
