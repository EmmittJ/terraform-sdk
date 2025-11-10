using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_network_endpoint_group.
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupDataSource : TerraformDataSource
{
    public GoogleComputeRegionNetworkEndpointGroupDataSource(string name) : base("google_compute_region_network_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_engine");
        this.WithOutput("cloud_function");
        this.WithOutput("cloud_run");
        this.WithOutput("description");
        this.WithOutput("network");
        this.WithOutput("network_endpoint_type");
        this.WithOutput("psc_data");
        this.WithOutput("psc_target_service");
        this.WithOutput("subnetwork");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformProperty<string>? SelfLink
    {
        get => GetProperty<TerraformProperty<string>>("self_link");
        set => this.WithProperty("self_link", value);
    }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformExpression AppEngine => this["app_engine"];

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformExpression CloudFunction => this["cloud_function"];

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    public TerraformExpression CloudRun => this["cloud_run"];

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    public TerraformExpression NetworkEndpointType => this["network_endpoint_type"];

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// </summary>
    public TerraformExpression PscData => this["psc_data"];

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    public TerraformExpression PscTargetService => this["psc_target_service"];

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    public TerraformExpression Subnetwork => this["subnetwork"];

}
