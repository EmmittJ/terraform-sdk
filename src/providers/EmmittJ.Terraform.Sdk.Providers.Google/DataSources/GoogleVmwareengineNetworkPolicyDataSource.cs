using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vmwareengine_network_policy Terraform data source.
/// Retrieves information about a google_vmwareengine_network_policy.
/// </summary>
public partial class GoogleVmwareengineNetworkPolicyDataSource(string name) : TerraformDataSource("google_vmwareengine_network_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name of the location (region) to create the new network policy in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the Network Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// User-provided description for this network policy.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// IP address range in CIDR notation used to create internet access and external IP access.
    /// An RFC 1918 CIDR block, with a &amp;quot;/26&amp;quot; prefix, is required. The range cannot overlap with any
    /// prefixes either in the consumer VPC network or in use by the private clouds attached to that VPC network.
    /// </summary>
    public TerraformValue<string> EdgeServicesCidr
        => AsReference("edge_services_cidr");

    /// <summary>
    /// Network service that allows External IP addresses to be assigned to VMware workloads.
    /// This service can only be enabled when internetAccess is also enabled.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalIp
        => AsReference("external_ip");

    /// <summary>
    /// Network service that allows VMware workloads to access the internet.
    /// </summary>
    public TerraformList<TerraformMap<object>> InternetAccess
        => AsReference("internet_access");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    public TerraformValue<string> VmwareEngineNetwork
        => AsReference("vmware_engine_network");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    public TerraformValue<string> VmwareEngineNetworkCanonical
        => AsReference("vmware_engine_network_canonical");

}
