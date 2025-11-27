using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_traffic_mirror_target Terraform resource.
/// Manages a aws_ec2_traffic_mirror_target resource.
/// </summary>
public partial class AwsEc2TrafficMirrorTarget(string name) : TerraformResource("aws_ec2_traffic_mirror_target", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The gateway_load_balancer_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? GatewayLoadBalancerEndpointId
    {
        get => new TerraformReference<string>(this, "gateway_load_balancer_endpoint_id");
        set => SetArgument("gateway_load_balancer_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string>? NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The network_load_balancer_arn attribute.
    /// </summary>
    public TerraformValue<string>? NetworkLoadBalancerArn
    {
        get => new TerraformReference<string>(this, "network_load_balancer_arn");
        set => SetArgument("network_load_balancer_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

}
