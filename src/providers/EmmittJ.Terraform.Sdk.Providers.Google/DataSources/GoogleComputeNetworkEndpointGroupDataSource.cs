using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_network_endpoint_group Terraform data source.
/// Retrieves information about a google_compute_network_endpoint_group.
/// </summary>
public partial class GoogleComputeNetworkEndpointGroupDataSource(string name) : TerraformDataSource("google_compute_network_endpoint_group", name)
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string>? SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// Zone where the network endpoint group is located.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    public TerraformValue<double> DefaultPort
    {
        get => new TerraformReference<double>(this, "default_port");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The uniquely generated identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> GeneratedId
    {
        get => new TerraformReference<double>(this, "generated_id");
    }

    /// <summary>
    /// The network to which all network endpoints in the NEG belong.
    /// Uses &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group.
    /// NON_GCP_PRIVATE_IP_PORT is used for hybrid connectivity network
    /// endpoint groups (see https://cloud.google.com/load-balancing/docs/hybrid).
    /// Note that NON_GCP_PRIVATE_IP_PORT can only be used with Backend Services
    /// that 1) have the following load balancing schemes: EXTERNAL, EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED, and INTERNAL_SELF_MANAGED and 2) support the RATE or
    /// CONNECTION balancing modes.
    /// 
    /// Possible values include: GCE_VM_IP, GCE_VM_IP_PORT, NON_GCP_PRIVATE_IP_PORT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, SERVERLESS, and PRIVATE_SERVICE_CONNECT. Default value: &amp;quot;GCE_VM_IP_PORT&amp;quot; Possible values: [&amp;quot;GCE_VM_IP&amp;quot;, &amp;quot;GCE_VM_IP_PORT&amp;quot;, &amp;quot;NON_GCP_PRIVATE_IP_PORT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    public TerraformValue<string> NetworkEndpointType
    {
        get => new TerraformReference<string>(this, "network_endpoint_type");
    }

    /// <summary>
    /// Number of network endpoints in the network endpoint group.
    /// </summary>
    public TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
    }

    /// <summary>
    /// Optional subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
    }

}
