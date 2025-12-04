using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for links in AzurermOrbitalContactProfile.
/// Nesting mode: list
/// </summary>
public class AzurermOrbitalContactProfileLinksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "links";

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
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
    /// The polarization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Polarization is required")]
    public required TerraformValue<string> Polarization
    {
        get => GetArgument<TerraformValue<string>>("polarization");
        set => SetArgument("polarization", value);
    }

    /// <summary>
    /// Channels block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Channels is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Channels block(s) required")]
    public required TerraformList<AzurermOrbitalContactProfileLinksBlockChannelsBlock> Channels
    {
        get => GetRequiredArgument<TerraformList<AzurermOrbitalContactProfileLinksBlockChannelsBlock>>("channels");
        set => SetArgument("channels", value);
    }

}

/// <summary>
/// Block type for channels in AzurermOrbitalContactProfileLinksBlock.
/// Nesting mode: list
/// </summary>
public class AzurermOrbitalContactProfileLinksBlockChannelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "channels";

    /// <summary>
    /// The bandwidth_mhz attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthMhz is required")]
    public required TerraformValue<double> BandwidthMhz
    {
        get => GetArgument<TerraformValue<double>>("bandwidth_mhz");
        set => SetArgument("bandwidth_mhz", value);
    }

    /// <summary>
    /// The center_frequency_mhz attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CenterFrequencyMhz is required")]
    public required TerraformValue<double> CenterFrequencyMhz
    {
        get => GetArgument<TerraformValue<double>>("center_frequency_mhz");
        set => SetArgument("center_frequency_mhz", value);
    }

    /// <summary>
    /// The demodulation_configuration attribute.
    /// </summary>
    public TerraformValue<string>? DemodulationConfiguration
    {
        get => GetArgument<TerraformValue<string>>("demodulation_configuration");
        set => SetArgument("demodulation_configuration", value);
    }

    /// <summary>
    /// The modulation_configuration attribute.
    /// </summary>
    public TerraformValue<string>? ModulationConfiguration
    {
        get => GetArgument<TerraformValue<string>>("modulation_configuration");
        set => SetArgument("modulation_configuration", value);
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
    /// EndPoint block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndPoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndPoint block(s) required")]
    public required TerraformSet<AzurermOrbitalContactProfileLinksBlockChannelsBlockEndPointBlock> EndPoint
    {
        get => GetRequiredArgument<TerraformSet<AzurermOrbitalContactProfileLinksBlockChannelsBlockEndPointBlock>>("end_point");
        set => SetArgument("end_point", value);
    }

}

/// <summary>
/// Block type for end_point in AzurermOrbitalContactProfileLinksBlockChannelsBlock.
/// Nesting mode: set
/// </summary>
public class AzurermOrbitalContactProfileLinksBlockChannelsBlockEndPointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_point";

    /// <summary>
    /// The end_point_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndPointName is required")]
    public required TerraformValue<string> EndPointName
    {
        get => GetArgument<TerraformValue<string>>("end_point_name");
        set => SetArgument("end_point_name", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermOrbitalContactProfile.
/// Nesting mode: single
/// </summary>
public class AzurermOrbitalContactProfileTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_orbital_contact_profile Terraform resource.
/// Manages a azurerm_orbital_contact_profile resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermOrbitalContactProfile(string name) : TerraformResource("azurerm_orbital_contact_profile", name)
{
    /// <summary>
    /// The auto_tracking attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoTracking is required")]
    public required TerraformValue<string> AutoTracking
    {
        get => GetArgument<TerraformValue<string>>("auto_tracking");
        set => SetArgument("auto_tracking", value);
    }

    /// <summary>
    /// The event_hub_uri attribute.
    /// </summary>
    public TerraformValue<string>? EventHubUri
    {
        get => GetArgument<TerraformValue<string>>("event_hub_uri");
        set => SetArgument("event_hub_uri", value);
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
    /// The minimum_elevation_degrees attribute.
    /// </summary>
    public TerraformValue<double>? MinimumElevationDegrees
    {
        get => GetArgument<TerraformValue<double>>("minimum_elevation_degrees");
        set => SetArgument("minimum_elevation_degrees", value);
    }

    /// <summary>
    /// The minimum_variable_contact_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumVariableContactDuration is required")]
    public required TerraformValue<string> MinimumVariableContactDuration
    {
        get => GetArgument<TerraformValue<string>>("minimum_variable_contact_duration");
        set => SetArgument("minimum_variable_contact_duration", value);
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
    /// The network_configuration_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfigurationSubnetId is required")]
    public required TerraformValue<string> NetworkConfigurationSubnetId
    {
        get => GetArgument<TerraformValue<string>>("network_configuration_subnet_id");
        set => SetArgument("network_configuration_subnet_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Links block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Links is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Links block(s) required")]
    public required TerraformList<AzurermOrbitalContactProfileLinksBlock> Links
    {
        get => GetRequiredArgument<TerraformList<AzurermOrbitalContactProfileLinksBlock>>("links");
        set => SetArgument("links", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOrbitalContactProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOrbitalContactProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
