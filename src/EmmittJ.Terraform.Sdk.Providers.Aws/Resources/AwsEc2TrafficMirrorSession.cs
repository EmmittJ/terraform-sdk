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
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// The packet_length attribute.
    /// </summary>
    public TerraformProperty<double>? PacketLength
    {
        get => GetProperty<TerraformProperty<double>>("packet_length");
        set => this.WithProperty("packet_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The session_number attribute.
    /// </summary>
    public TerraformProperty<double>? SessionNumber
    {
        get => GetProperty<TerraformProperty<double>>("session_number");
        set => this.WithProperty("session_number", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficMirrorFilterId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_mirror_filter_id");
        set => this.WithProperty("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The traffic_mirror_target_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficMirrorTargetId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_mirror_target_id");
        set => this.WithProperty("traffic_mirror_target_id", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<double>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<double>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
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
