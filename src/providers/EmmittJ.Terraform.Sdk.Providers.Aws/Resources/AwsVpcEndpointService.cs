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
        get => GetRequiredArgument<TerraformValue<bool>>("acceptance_required");
        set => SetArgument("acceptance_required", value);
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public TerraformSet<string> AllowedPrincipals
    {
        get => GetArgument<TerraformSet<string>>("allowed_principals") ?? AsReference("allowed_principals");
        set => SetArgument("allowed_principals", value);
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string>? GatewayLoadBalancerArns
    {
        get => GetArgument<TerraformSet<string>>("gateway_load_balancer_arns");
        set => SetArgument("gateway_load_balancer_arns", value);
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
    /// The network_load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string>? NetworkLoadBalancerArns
    {
        get => GetArgument<TerraformSet<string>>("network_load_balancer_arns");
        set => SetArgument("network_load_balancer_arns", value);
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
    {
        get => GetArgument<TerraformValue<string>>("private_dns_name") ?? AsReference("private_dns_name");
        set => SetArgument("private_dns_name", value);
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
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformSet<string> SupportedIpAddressTypes
    {
        get => GetArgument<TerraformSet<string>>("supported_ip_address_types") ?? AsReference("supported_ip_address_types");
        set => SetArgument("supported_ip_address_types", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public TerraformSet<string> SupportedRegions
    {
        get => GetArgument<TerraformSet<string>>("supported_regions") ?? AsReference("supported_regions");
        set => SetArgument("supported_regions", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    public TerraformSet<string> BaseEndpointDnsNames
        => AsReference("base_endpoint_dns_names");

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    public TerraformValue<bool> ManagesVpcEndpoints
        => AsReference("manages_vpc_endpoints");

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameConfiguration
        => AsReference("private_dns_name_configuration");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
        => AsReference("service_name");

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string> ServiceType
        => AsReference("service_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
