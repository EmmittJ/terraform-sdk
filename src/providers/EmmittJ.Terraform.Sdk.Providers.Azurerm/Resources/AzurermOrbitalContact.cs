using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOrbitalContact.
/// Nesting mode: single
/// </summary>
public class AzurermOrbitalContactTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_orbital_contact Terraform resource.
/// Manages a azurerm_orbital_contact resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermOrbitalContact(string name) : TerraformResource("azurerm_orbital_contact", name)
{
    /// <summary>
    /// The contact_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactProfileId is required")]
    public required TerraformValue<string> ContactProfileId
    {
        get => new TerraformReference<string>(this, "contact_profile_id");
        set => SetArgument("contact_profile_id", value);
    }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroundStationName is required")]
    public required TerraformValue<string> GroundStationName
    {
        get => new TerraformReference<string>(this, "ground_station_name");
        set => SetArgument("ground_station_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The reservation_end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationEndTime is required")]
    public required TerraformValue<string> ReservationEndTime
    {
        get => new TerraformReference<string>(this, "reservation_end_time");
        set => SetArgument("reservation_end_time", value);
    }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationStartTime is required")]
    public required TerraformValue<string> ReservationStartTime
    {
        get => new TerraformReference<string>(this, "reservation_start_time");
        set => SetArgument("reservation_start_time", value);
    }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpacecraftId is required")]
    public required TerraformValue<string> SpacecraftId
    {
        get => new TerraformReference<string>(this, "spacecraft_id");
        set => SetArgument("spacecraft_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOrbitalContactTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOrbitalContactTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
