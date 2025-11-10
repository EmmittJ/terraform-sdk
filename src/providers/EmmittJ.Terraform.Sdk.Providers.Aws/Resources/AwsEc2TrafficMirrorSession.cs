using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_traffic_mirror_session resource.
/// </summary>
public class AwsEc2TrafficMirrorSession : TerraformResource
{
    public AwsEc2TrafficMirrorSession(string name) : base("aws_ec2_traffic_mirror_session", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("network_interface_id");
        SetOutput("packet_length");
        SetOutput("region");
        SetOutput("session_number");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("traffic_mirror_filter_id");
        SetOutput("traffic_mirror_target_id");
        SetOutput("virtual_network_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The packet_length attribute.
    /// </summary>
    public TerraformProperty<double> PacketLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("packet_length");
        set => SetProperty("packet_length", value);
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
    /// The session_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionNumber is required")]
    public required TerraformProperty<double> SessionNumber
    {
        get => GetRequiredOutput<TerraformProperty<double>>("session_number");
        set => SetProperty("session_number", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    public required TerraformProperty<string> TrafficMirrorFilterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_mirror_filter_id");
        set => SetProperty("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The traffic_mirror_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorTargetId is required")]
    public required TerraformProperty<string> TrafficMirrorTargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_mirror_target_id");
        set => SetProperty("traffic_mirror_target_id", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<double> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<double>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
