using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_subnetwork Terraform data source.
/// Retrieves information about a google_compute_subnetwork.
/// </summary>
public partial class GoogleComputeSubnetworkDataSource(string name) : TerraformDataSource("google_compute_subnetwork", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => GetArgument<TerraformValue<string>>("self_link") ?? CreateReference("self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The external_ipv6_prefix attribute.
    /// </summary>
    public TerraformValue<string> ExternalIpv6Prefix
        => CreateReference("external_ipv6_prefix");

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformValue<string> GatewayAddress
        => CreateReference("gateway_address");

    /// <summary>
    /// The internal_ipv6_prefix attribute.
    /// </summary>
    public TerraformValue<string> InternalIpv6Prefix
        => CreateReference("internal_ipv6_prefix");

    /// <summary>
    /// The ip_cidr_range attribute.
    /// </summary>
    public TerraformValue<string> IpCidrRange
        => CreateReference("ip_cidr_range");

    /// <summary>
    /// The ipv6_access_type attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AccessType
        => CreateReference("ipv6_access_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformValue<string> Network
        => CreateReference("network");

    /// <summary>
    /// The private_ip_google_access attribute.
    /// </summary>
    public TerraformValue<bool> PrivateIpGoogleAccess
        => CreateReference("private_ip_google_access");

    /// <summary>
    /// The secondary_ip_range attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecondaryIpRange
        => CreateReference("secondary_ip_range");

    /// <summary>
    /// The stack_type attribute.
    /// </summary>
    public TerraformValue<string> StackType
        => CreateReference("stack_type");

    /// <summary>
    /// The subnetwork_id attribute.
    /// </summary>
    public TerraformValue<double> SubnetworkId
        => CreateReference("subnetwork_id");

}
