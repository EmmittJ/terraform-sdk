using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_network Terraform data source.
/// Retrieves information about a google_compute_network.
/// </summary>
public partial class GoogleComputeNetworkDataSource(string name) : TerraformDataSource("google_compute_network", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_profile attribute.
    /// </summary>
    public TerraformValue<string>? NetworkProfile
    {
        get => GetArgument<TerraformValue<string>>("network_profile");
        set => SetArgument("network_profile", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    public TerraformValue<string> GatewayIpv4
        => CreateReference("gateway_ipv4");

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    public TerraformValue<string> InternalIpv6Range
        => CreateReference("internal_ipv6_range");

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    public TerraformValue<double> NetworkId
        => CreateReference("network_id");

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NumericId
        => CreateReference("numeric_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    public TerraformList<string> SubnetworksSelfLinks
        => CreateReference("subnetworks_self_links");

}
