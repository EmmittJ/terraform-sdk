using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOrbitalContactTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a azurerm_orbital_contact resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermOrbitalContact : TerraformResource
{
    public AzurermOrbitalContact(string name) : base("azurerm_orbital_contact", name)
    {
    }

    /// <summary>
    /// The contact_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactProfileId is required")]
    [TerraformProperty("contact_profile_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContactProfileId { get; set; }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroundStationName is required")]
    [TerraformProperty("ground_station_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GroundStationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The reservation_end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationEndTime is required")]
    [TerraformProperty("reservation_end_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReservationEndTime { get; set; }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationStartTime is required")]
    [TerraformProperty("reservation_start_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReservationStartTime { get; set; }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpacecraftId is required")]
    [TerraformProperty("spacecraft_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpacecraftId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOrbitalContactTimeoutsBlock>? Timeouts { get; set; }

}
