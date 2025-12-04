using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHealthcareMedtechServiceFhirDestination.
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_healthcare_medtech_service_fhir_destination Terraform resource.
/// Manages a azurerm_healthcare_medtech_service_fhir_destination resource.
/// </summary>
public partial class AzurermHealthcareMedtechServiceFhirDestination(string name) : TerraformResource("azurerm_healthcare_medtech_service_fhir_destination", name)
{
    /// <summary>
    /// The destination_fhir_mapping_json attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirMappingJson is required")]
    public required TerraformValue<string> DestinationFhirMappingJson
    {
        get => GetArgument<TerraformValue<string>>("destination_fhir_mapping_json");
        set => SetArgument("destination_fhir_mapping_json", value);
    }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirServiceId is required")]
    public required TerraformValue<string> DestinationFhirServiceId
    {
        get => GetArgument<TerraformValue<string>>("destination_fhir_service_id");
        set => SetArgument("destination_fhir_service_id", value);
    }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIdentityResolutionType is required")]
    public required TerraformValue<string> DestinationIdentityResolutionType
    {
        get => GetArgument<TerraformValue<string>>("destination_identity_resolution_type");
        set => SetArgument("destination_identity_resolution_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MedtechServiceId is required")]
    public required TerraformValue<string> MedtechServiceId
    {
        get => GetArgument<TerraformValue<string>>("medtech_service_id");
        set => SetArgument("medtech_service_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
