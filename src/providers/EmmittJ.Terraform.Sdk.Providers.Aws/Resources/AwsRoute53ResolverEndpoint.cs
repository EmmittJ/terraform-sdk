using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_address in AwsRoute53ResolverEndpoint.
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverEndpointIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_address";

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformValue<string> Ip
    {
        get => GetArgument<TerraformValue<string>>("ip") ?? AsReference("ip");
        set => SetArgument("ip", value);
    }

    /// <summary>
    /// The ip_id attribute.
    /// </summary>
    public TerraformValue<string> IpId
        => AsReference("ip_id");

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformValue<string> Ipv6
    {
        get => GetArgument<TerraformValue<string>>("ipv6") ?? AsReference("ipv6");
        set => SetArgument("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53ResolverEndpoint.
/// Nesting mode: single
/// </summary>
public class AwsRoute53ResolverEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53_resolver_endpoint Terraform resource.
/// Manages a aws_route53_resolver_endpoint resource.
/// </summary>
public partial class AwsRoute53ResolverEndpoint(string name) : TerraformResource("aws_route53_resolver_endpoint", name)
{
    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetRequiredArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string> Protocols
    {
        get => GetArgument<TerraformSet<string>>("protocols") ?? AsReference("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> ResolverEndpointType
    {
        get => GetArgument<TerraformValue<string>>("resolver_endpoint_type") ?? AsReference("resolver_endpoint_type");
        set => SetArgument("resolver_endpoint_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The host_vpc_id attribute.
    /// </summary>
    public TerraformValue<string> HostVpcId
        => AsReference("host_vpc_id");

    /// <summary>
    /// IpAddress block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 IpAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 IpAddress block(s) allowed")]
    public TerraformSet<AwsRoute53ResolverEndpointIpAddressBlock>? IpAddress
    {
        get => GetArgument<TerraformSet<AwsRoute53ResolverEndpointIpAddressBlock>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53ResolverEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53ResolverEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
