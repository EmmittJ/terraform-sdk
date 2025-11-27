using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_network_endpoint_group Terraform data source.
/// Retrieves information about a google_compute_region_network_endpoint_group.
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupDataSource(string name) : TerraformDataSource("google_compute_region_network_endpoint_group", name)
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
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> AppEngine
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "app_engine").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudFunction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cloud_function").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudRun
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cloud_run").ResolveNodes(ctx));
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
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    public TerraformValue<string> NetworkEndpointType
    {
        get => new TerraformReference<string>(this, "network_endpoint_type");
    }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscData
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_data").ResolveNodes(ctx));
    }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    public TerraformValue<string> PscTargetService
    {
        get => new TerraformReference<string>(this, "psc_target_service");
    }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
    }

}
