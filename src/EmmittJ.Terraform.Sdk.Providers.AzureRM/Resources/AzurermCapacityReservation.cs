using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_capacity_reservation resource.
/// </summary>
public class AzurermCapacityReservation : TerraformResource
{
    public AzurermCapacityReservation(string name) : base("azurerm_capacity_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public string? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id")?.Value;
        set => this.WithProperty("capacity_reservation_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
