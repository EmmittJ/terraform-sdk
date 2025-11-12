using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateEndpointApplicationSecurityGroupAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_private_endpoint_application_security_group_association resource.
/// </summary>
public partial class AzurermPrivateEndpointApplicationSecurityGroupAssociation : TerraformResource
{
    public AzurermPrivateEndpointApplicationSecurityGroupAssociation(string name) : base("azurerm_private_endpoint_application_security_group_association", name)
    {
    }

    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSecurityGroupId is required")]
    [TerraformProperty("application_security_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationSecurityGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    [TerraformProperty("private_endpoint_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateEndpointId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPrivateEndpointApplicationSecurityGroupAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
