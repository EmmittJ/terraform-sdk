using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_healthcare_medtech_service_fhir_destination resource.
/// </summary>
public class AzurermHealthcareMedtechServiceFhirDestination : TerraformResource
{
    public AzurermHealthcareMedtechServiceFhirDestination(string name) : base("azurerm_healthcare_medtech_service_fhir_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("destination_fhir_mapping_json");
        SetOutput("destination_fhir_service_id");
        SetOutput("destination_identity_resolution_type");
        SetOutput("id");
        SetOutput("location");
        SetOutput("medtech_service_id");
        SetOutput("name");
    }

    /// <summary>
    /// The destination_fhir_mapping_json attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirMappingJson is required")]
    public required TerraformProperty<string> DestinationFhirMappingJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_fhir_mapping_json");
        set => SetProperty("destination_fhir_mapping_json", value);
    }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirServiceId is required")]
    public required TerraformProperty<string> DestinationFhirServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_fhir_service_id");
        set => SetProperty("destination_fhir_service_id", value);
    }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIdentityResolutionType is required")]
    public required TerraformProperty<string> DestinationIdentityResolutionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_identity_resolution_type");
        set => SetProperty("destination_identity_resolution_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MedtechServiceId is required")]
    public required TerraformProperty<string> MedtechServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("medtech_service_id");
        set => SetProperty("medtech_service_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
