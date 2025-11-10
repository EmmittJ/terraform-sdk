using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_traffic_mirror_target resource.
/// </summary>
public class AwsEc2TrafficMirrorTarget : TerraformResource
{
    public AwsEc2TrafficMirrorTarget(string name) : base("aws_ec2_traffic_mirror_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("description");
        SetOutput("gateway_load_balancer_endpoint_id");
        SetOutput("id");
        SetOutput("network_interface_id");
        SetOutput("network_load_balancer_arn");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The gateway_load_balancer_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> GatewayLoadBalancerEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_load_balancer_endpoint_id");
        set => SetProperty("gateway_load_balancer_endpoint_id", value);
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
    public TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The network_load_balancer_arn attribute.
    /// </summary>
    public TerraformProperty<string> NetworkLoadBalancerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_load_balancer_arn");
        set => SetProperty("network_load_balancer_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
