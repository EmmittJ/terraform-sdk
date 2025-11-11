using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_healthcare_medtech_service_fhir_destination resource.
/// </summary>
public partial class AzurermHealthcareMedtechServiceFhirDestination : TerraformResource
{
    public AzurermHealthcareMedtechServiceFhirDestination(string name) : base("azurerm_healthcare_medtech_service_fhir_destination", name)
    {
    }

    /// <summary>
    /// The destination_fhir_mapping_json attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirMappingJson is required")]
    [TerraformProperty("destination_fhir_mapping_json")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationFhirMappingJson { get; set; }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirServiceId is required")]
    [TerraformProperty("destination_fhir_service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationFhirServiceId { get; set; }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIdentityResolutionType is required")]
    [TerraformProperty("destination_identity_resolution_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationIdentityResolutionType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MedtechServiceId is required")]
    [TerraformProperty("medtech_service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MedtechServiceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock>? Timeouts { get; set; }

}
