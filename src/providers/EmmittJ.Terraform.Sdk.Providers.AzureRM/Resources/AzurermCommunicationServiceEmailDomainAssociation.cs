using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_communication_service_email_domain_association resource.
/// </summary>
public partial class AzurermCommunicationServiceEmailDomainAssociation : TerraformResource
{
    public AzurermCommunicationServiceEmailDomainAssociation(string name) : base("azurerm_communication_service_email_domain_association", name)
    {
    }

    /// <summary>
    /// The communication_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommunicationServiceId is required")]
    [TerraformProperty("communication_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CommunicationServiceId { get; set; }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceDomainId is required")]
    [TerraformProperty("email_service_domain_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailServiceDomainId { get; set; }

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
    public partial TerraformBlock<AzurermCommunicationServiceEmailDomainAssociationTimeoutsBlock>? Timeouts { get; set; }

}
