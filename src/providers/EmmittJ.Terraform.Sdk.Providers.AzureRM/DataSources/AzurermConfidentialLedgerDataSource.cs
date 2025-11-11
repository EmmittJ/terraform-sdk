using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConfidentialLedgerDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_confidential_ledger.
/// </summary>
public class AzurermConfidentialLedgerDataSource : TerraformDataSource
{
    public AzurermConfidentialLedgerDataSource(string name) : base("azurerm_confidential_ledger", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermConfidentialLedgerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azuread_based_service_principal attribute.
    /// </summary>
    [TerraformPropertyName("azuread_based_service_principal")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AzureadBasedServicePrincipal => new TerraformReference(this, "azuread_based_service_principal");

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    [TerraformPropertyName("certificate_based_security_principal")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificateBasedSecurityPrincipal => new TerraformReference(this, "certificate_based_security_principal");

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("identity_service_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdentityServiceEndpoint => new TerraformReference(this, "identity_service_endpoint");

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("ledger_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LedgerEndpoint => new TerraformReference(this, "ledger_endpoint");

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    [TerraformPropertyName("ledger_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LedgerType => new TerraformReference(this, "ledger_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
