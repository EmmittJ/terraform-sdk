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
    public string? ContactProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_profile_id")?.Value;
        set => this.WithProperty("contact_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ground_station_name attribute.
    /// </summary>
    public string? GroundStationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ground_station_name")?.Value;
        set => this.WithProperty("ground_station_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reservation_end_time attribute.
    /// </summary>
    public string? ReservationEndTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation_end_time")?.Value;
        set => this.WithProperty("reservation_end_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reservation_start_time attribute.
    /// </summary>
    public string? ReservationStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reservation_start_time")?.Value;
        set => this.WithProperty("reservation_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spacecraft_id attribute.
    /// </summary>
    public string? SpacecraftId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spacecraft_id")?.Value;
        set => this.WithProperty("spacecraft_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
