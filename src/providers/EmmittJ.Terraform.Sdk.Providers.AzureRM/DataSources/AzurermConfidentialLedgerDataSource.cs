using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermConfidentialLedgerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_confidential_ledger.
/// </summary>
public partial class AzurermConfidentialLedgerDataSource : TerraformDataSource
{
    public AzurermConfidentialLedgerDataSource(string name) : base("azurerm_confidential_ledger", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    public TerraformBlock<AzurermConfidentialLedgerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azuread_based_service_principal attribute.
    /// </summary>
    [TerraformProperty("azuread_based_service_principal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AzureadBasedServicePrincipal { get; }

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    [TerraformProperty("certificate_based_security_principal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertificateBasedSecurityPrincipal { get; }

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    [TerraformProperty("identity_service_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityServiceEndpoint { get; }

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    [TerraformProperty("ledger_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LedgerEndpoint { get; }

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    [TerraformProperty("ledger_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LedgerType { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
