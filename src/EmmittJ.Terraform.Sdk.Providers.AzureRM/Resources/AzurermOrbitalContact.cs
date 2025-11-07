using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_orbital_contact resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermOrbitalContact : TerraformResource
{
    public AzurermOrbitalContact(string name) : base("azurerm_orbital_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The contact_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContactProfileId
    {
        get => GetProperty<TerraformProperty<string>>("contact_profile_id");
        set => this.WithProperty("contact_profile_id", value);
    }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    public TerraformProperty<string>? GroundStationName
    {
        get => GetProperty<TerraformProperty<string>>("ground_station_name");
        set => this.WithProperty("ground_station_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reservation_end_time attribute.
    /// </summary>
    public TerraformProperty<string>? ReservationEndTime
    {
        get => GetProperty<TerraformProperty<string>>("reservation_end_time");
        set => this.WithProperty("reservation_end_time", value);
    }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? ReservationStartTime
    {
        get => GetProperty<TerraformProperty<string>>("reservation_start_time");
        set => this.WithProperty("reservation_start_time", value);
    }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpacecraftId
    {
        get => GetProperty<TerraformProperty<string>>("spacecraft_id");
        set => this.WithProperty("spacecraft_id", value);
    }

}
