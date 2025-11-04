using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The destination_fhir_mapping_json attribute.
    /// </summary>
    public string? DestinationFhirMappingJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_fhir_mapping_json")?.Value;
        set => this.WithProperty("destination_fhir_mapping_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    public string? DestinationFhirServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_fhir_service_id")?.Value;
        set => this.WithProperty("destination_fhir_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    public string? DestinationIdentityResolutionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_identity_resolution_type")?.Value;
        set => this.WithProperty("destination_identity_resolution_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    public string? MedtechServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("medtech_service_id")?.Value;
        set => this.WithProperty("medtech_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
