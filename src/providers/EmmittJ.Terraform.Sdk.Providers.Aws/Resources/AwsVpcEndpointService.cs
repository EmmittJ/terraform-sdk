using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcEndpointService.
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_endpoint_service Terraform resource.
/// Manages a aws_vpc_endpoint_service resource.
/// </summary>
public partial class AwsVpcEndpointService(string name) : TerraformResource("aws_vpc_endpoint_service", name)
{
    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    public required TerraformValue<bool> AcceptanceRequired
    {
        get => new TerraformReference<bool>(this, "acceptance_required");
        set => SetArgument("acceptance_required", value);
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public TerraformSet<string> AllowedPrincipals
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_principals").ResolveNodes(ctx));
        set => SetArgument("allowed_principals", value);
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string>? GatewayLoadBalancerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "gateway_load_balancer_arns").ResolveNodes(ctx));
        set => SetArgument("gateway_load_balancer_arns", value);
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
    /// The network_load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string>? NetworkLoadBalancerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_load_balancer_arns").ResolveNodes(ctx));
        set => SetArgument("network_load_balancer_arns", value);
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
    {
        get => new TerraformReference<string>(this, "private_dns_name");
        set => SetArgument("private_dns_name", value);
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
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformSet<string> SupportedIpAddressTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_ip_address_types").ResolveNodes(ctx));
        set => SetArgument("supported_ip_address_types", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public TerraformSet<string> SupportedRegions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_regions").ResolveNodes(ctx));
        set => SetArgument("supported_regions", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    public TerraformSet<string> BaseEndpointDnsNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "base_endpoint_dns_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    public TerraformValue<bool> ManagesVpcEndpoints
    {
        get => new TerraformReference<bool>(this, "manages_vpc_endpoints");
    }

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_dns_name_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string> ServiceType
    {
        get => new TerraformReference<string>(this, "service_type");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
