using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultKeyDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public partial class AzurermKeyVaultKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultKeyDataSource(string name) : base("azurerm_key_vault_key", name)
    {
    }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermKeyVaultKeyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    [TerraformProperty("curve")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Curve { get; }

    /// <summary>
    /// The e attribute.
    /// </summary>
    [TerraformProperty("e")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> E { get; }

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    [TerraformProperty("key_opts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> KeyOpts { get; }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    [TerraformProperty("key_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> KeySize { get; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformProperty("key_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyType { get; }

    /// <summary>
    /// The n attribute.
    /// </summary>
    [TerraformProperty("n")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> N { get; }

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    [TerraformProperty("public_key_openssh")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKeyOpenssh { get; }

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    [TerraformProperty("public_key_pem")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKeyPem { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    [TerraformProperty("resource_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceVersionlessId { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformProperty("versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionlessId { get; }

    /// <summary>
    /// The x attribute.
    /// </summary>
    [TerraformProperty("x")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> X { get; }

    /// <summary>
    /// The y attribute.
    /// </summary>
    [TerraformProperty("y")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Y { get; }

}
