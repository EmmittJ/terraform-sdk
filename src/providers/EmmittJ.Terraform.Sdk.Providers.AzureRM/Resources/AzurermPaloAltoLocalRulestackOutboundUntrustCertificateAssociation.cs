using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation : TerraformResource
{
    public AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation(string name) : base("azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association", name)
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformProperty("certificate_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CertificateId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
