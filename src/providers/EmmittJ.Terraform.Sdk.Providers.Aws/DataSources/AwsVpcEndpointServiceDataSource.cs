using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcEndpointServiceDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointServiceDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcEndpointServiceDataSource.
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_vpc_endpoint_service Terraform data source.
/// Retrieves information about a aws_vpc_endpoint_service.
/// </summary>
public partial class AwsVpcEndpointServiceDataSource(string name) : TerraformDataSource("aws_vpc_endpoint_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    public TerraformSet<string>? ServiceRegions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "service_regions").ResolveNodes(ctx));
        set => SetArgument("service_regions", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string> ServiceType
    {
        get => new TerraformReference<string>(this, "service_type");
        set => SetArgument("service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    public TerraformValue<bool> AcceptanceRequired
    {
        get => new TerraformReference<bool>(this, "acceptance_required");
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
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
    {
        get => new TerraformReference<string>(this, "private_dns_name");
    }

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    public TerraformSet<string> PrivateDnsNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "private_dns_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
    }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformValue<string> ServiceRegion
    {
        get => new TerraformReference<string>(this, "service_region");
    }

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformSet<string> SupportedIpAddressTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_ip_address_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    public TerraformValue<bool> VpcEndpointPolicySupported
    {
        get => new TerraformReference<bool>(this, "vpc_endpoint_policy_supported");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcEndpointServiceDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcEndpointServiceDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
