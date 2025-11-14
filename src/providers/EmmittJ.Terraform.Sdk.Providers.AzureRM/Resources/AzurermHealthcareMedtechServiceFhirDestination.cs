using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_healthcare_medtech_service_fhir_destination resource.
/// </summary>
public class AzurermHealthcareMedtechServiceFhirDestination : TerraformResource
{
    public AzurermHealthcareMedtechServiceFhirDestination(string name) : base("azurerm_healthcare_medtech_service_fhir_destination", name)
    {
    }

    /// <summary>
    /// The destination_fhir_mapping_json attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirMappingJson is required")]
    [TerraformArgument("destination_fhir_mapping_json")]
    public required TerraformValue<string> DestinationFhirMappingJson
    {
        get => new TerraformReference<string>(this, "destination_fhir_mapping_json");
        set => SetArgument("destination_fhir_mapping_json", value);
    }

    /// <summary>
    /// The destination_fhir_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFhirServiceId is required")]
    [TerraformArgument("destination_fhir_service_id")]
    public required TerraformValue<string> DestinationFhirServiceId
    {
        get => new TerraformReference<string>(this, "destination_fhir_service_id");
        set => SetArgument("destination_fhir_service_id", value);
    }

    /// <summary>
    /// The destination_identity_resolution_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIdentityResolutionType is required")]
    [TerraformArgument("destination_identity_resolution_type")]
    public required TerraformValue<string> DestinationIdentityResolutionType
    {
        get => new TerraformReference<string>(this, "destination_identity_resolution_type");
        set => SetArgument("destination_identity_resolution_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The medtech_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MedtechServiceId is required")]
    [TerraformArgument("medtech_service_id")]
    public required TerraformValue<string> MedtechServiceId
    {
        get => new TerraformReference<string>(this, "medtech_service_id");
        set => SetArgument("medtech_service_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareMedtechServiceFhirDestinationTimeoutsBlock Timeouts { get; set; } = new();

}
