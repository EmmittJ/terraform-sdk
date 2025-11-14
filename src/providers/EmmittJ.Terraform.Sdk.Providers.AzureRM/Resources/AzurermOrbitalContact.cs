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
public class AzurermOrbitalContactTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_orbital_contact resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermOrbitalContact : TerraformResource
{
    public AzurermOrbitalContact(string name) : base("azurerm_orbital_contact", name)
    {
    }

    /// <summary>
    /// The contact_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactProfileId is required")]
    [TerraformArgument("contact_profile_id")]
    public required TerraformValue<string> ContactProfileId
    {
        get => new TerraformReference<string>(this, "contact_profile_id");
        set => SetArgument("contact_profile_id", value);
    }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroundStationName is required")]
    [TerraformArgument("ground_station_name")]
    public required TerraformValue<string> GroundStationName
    {
        get => new TerraformReference<string>(this, "ground_station_name");
        set => SetArgument("ground_station_name", value);
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
    /// The reservation_end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationEndTime is required")]
    [TerraformArgument("reservation_end_time")]
    public required TerraformValue<string> ReservationEndTime
    {
        get => new TerraformReference<string>(this, "reservation_end_time");
        set => SetArgument("reservation_end_time", value);
    }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservationStartTime is required")]
    [TerraformArgument("reservation_start_time")]
    public required TerraformValue<string> ReservationStartTime
    {
        get => new TerraformReference<string>(this, "reservation_start_time");
        set => SetArgument("reservation_start_time", value);
    }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpacecraftId is required")]
    [TerraformArgument("spacecraft_id")]
    public required TerraformValue<string> SpacecraftId
    {
        get => new TerraformReference<string>(this, "spacecraft_id");
        set => SetArgument("spacecraft_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOrbitalContactTimeoutsBlock Timeouts { get; set; } = new();

}
