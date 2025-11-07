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
    public TerraformLiteralProperty<string>? DestinationFhirMappingJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_fhir_mapping_json");
        set => this.WithProperty("destination_fhir_mapping_json", value);
    }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationFhirServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_fhir_service_id");
        set => this.WithProperty("destination_fhir_service_id", value);
    }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationIdentityResolutionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_identity_resolution_type");
        set => this.WithProperty("destination_identity_resolution_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MedtechServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("medtech_service_id");
        set => this.WithProperty("medtech_service_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
