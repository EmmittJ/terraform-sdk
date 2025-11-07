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
    public TerraformLiteralProperty<string>? ContactProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_profile_id");
        set => this.WithProperty("contact_profile_id", value);
    }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroundStationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ground_station_name");
        set => this.WithProperty("ground_station_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The reservation_end_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReservationEndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation_end_time");
        set => this.WithProperty("reservation_end_time", value);
    }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReservationStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation_start_time");
        set => this.WithProperty("reservation_start_time", value);
    }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpacecraftId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spacecraft_id");
        set => this.WithProperty("spacecraft_id", value);
    }

}
