using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmonitor_probe resource.
/// </summary>
public class AwsNetworkmonitorProbe : TerraformResource
{
    public AwsNetworkmonitorProbe(string name) : base("aws_networkmonitor_probe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_family");
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("probe_id");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public string? Destination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination")?.Value;
        set => this.WithProperty("destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public double? DestinationPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("destination_port")?.Value;
        set => this.WithProperty("destination_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    public string? MonitorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_name")?.Value;
        set => this.WithProperty("monitor_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The packet_size attribute.
    /// </summary>
    public double? PacketSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("packet_size")?.Value;
        set => this.WithProperty("packet_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public string? SourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arn")?.Value;
        set => this.WithProperty("source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The address_family attribute.
    /// </summary>
    public TerraformExpression AddressFamily => this["address_family"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    public TerraformExpression ProbeId => this["probe_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
