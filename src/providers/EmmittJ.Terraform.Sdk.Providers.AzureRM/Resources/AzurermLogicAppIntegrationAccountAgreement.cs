using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for guest_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppIntegrationAccountAgreementGuestIdentityBlock() : TerraformBlock("guest_identity")
{
    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    [TerraformProperty("qualifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Qualifier { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for host_identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppIntegrationAccountAgreementHostIdentityBlock() : TerraformBlock("host_identity")
{
    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    [TerraformProperty("qualifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Qualifier { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppIntegrationAccountAgreementTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_logic_app_integration_account_agreement resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogicAppIntegrationAccountAgreement : TerraformResource
{
    public AzurermLogicAppIntegrationAccountAgreement(string name) : base("azurerm_logic_app_integration_account_agreement", name)
    {
    }

    /// <summary>
    /// The agreement_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgreementType is required")]
    [TerraformProperty("agreement_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgreementType { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The guest_partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestPartnerName is required")]
    [TerraformProperty("guest_partner_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GuestPartnerName { get; set; }

    /// <summary>
    /// The host_partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostPartnerName is required")]
    [TerraformProperty("host_partner_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostPartnerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    [TerraformProperty("integration_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntegrationAccountName { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for guest_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GuestIdentity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuestIdentity block(s) allowed")]
    [TerraformProperty("guest_identity")]
    public required TerraformList<AzurermLogicAppIntegrationAccountAgreementGuestIdentityBlock> GuestIdentity { get; set; } = new();

    /// <summary>
    /// Block for host_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HostIdentity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostIdentity block(s) allowed")]
    [TerraformProperty("host_identity")]
    public required TerraformList<AzurermLogicAppIntegrationAccountAgreementHostIdentityBlock> HostIdentity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLogicAppIntegrationAccountAgreementTimeoutsBlock Timeouts { get; set; } = new();

}
