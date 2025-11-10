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
        SetOutput("address_family");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("probe_id");
        SetOutput("tags_all");
        SetOutput("vpc_id");
        SetOutput("destination");
        SetOutput("destination_port");
        SetOutput("monitor_name");
        SetOutput("packet_size");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("source_arn");
        SetOutput("tags");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformProperty<double> DestinationPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("destination_port");
        set => SetProperty("destination_port", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformProperty<string> MonitorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_name");
        set => SetProperty("monitor_name", value);
    }

    /// <summary>
    /// The packet_size attribute.
    /// </summary>
    public TerraformProperty<double> PacketSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("packet_size");
        set => SetProperty("packet_size", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformProperty<string> SourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_arn");
        set => SetProperty("source_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
