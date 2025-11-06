using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_pubsub_lite_reservation resource.
/// </summary>
public class GooglePubsubLiteReservation : TerraformResource
{
    public GooglePubsubLiteReservation(string name) : base("google_pubsub_lite_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Name of the reservation.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region of the pubsub lite reservation.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reserved throughput capacity. Every unit of throughput capacity is
    /// equivalent to 1 MiB/s of published messages or 2 MiB/s of subscribed
    /// messages.
    /// </summary>
    public double? ThroughputCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_capacity")?.Value;
        set => this.WithProperty("throughput_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
