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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name") ?? CreateReference("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    public TerraformSet<string>? ServiceRegions
    {
        get => GetArgument<TerraformSet<string>>("service_regions");
        set => SetArgument("service_regions", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string> ServiceType
    {
        get => GetArgument<TerraformValue<string>>("service_type") ?? CreateReference("service_type");
        set => SetArgument("service_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    public TerraformValue<bool> AcceptanceRequired
        => CreateReference("acceptance_required");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => CreateReference("availability_zones");

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    public TerraformSet<string> BaseEndpointDnsNames
        => CreateReference("base_endpoint_dns_names");

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    public TerraformValue<bool> ManagesVpcEndpoints
        => CreateReference("manages_vpc_endpoints");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => CreateReference("owner");

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsName
        => CreateReference("private_dns_name");

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    public TerraformSet<string> PrivateDnsNames
        => CreateReference("private_dns_names");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceId
        => CreateReference("service_id");

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformValue<string> ServiceRegion
        => CreateReference("service_region");

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformSet<string> SupportedIpAddressTypes
        => CreateReference("supported_ip_address_types");

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    public TerraformValue<bool> VpcEndpointPolicySupported
        => CreateReference("vpc_endpoint_policy_supported");

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
