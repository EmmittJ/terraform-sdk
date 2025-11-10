using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleEdgecontainerVpnConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_project in .
/// Nesting mode: list
/// </summary>
public class GoogleEdgecontainerVpnConnectionVpcProjectBlock : TerraformBlock
{
    /// <summary>
    /// The project of the VPC to connect to. If not specified, it is the same as the cluster project.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

}

/// <summary>
/// Manages a google_edgecontainer_vpn_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleEdgecontainerVpnConnection : TerraformResource
{
    public GoogleEdgecontainerVpnConnection(string name) : base("google_edgecontainer_vpn_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("details");
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The canonical Cluster name to connect to. It is in the form of projects/{project}/locations/{location}/clusters/{cluster}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// Whether this VPN connection has HA enabled on cluster side. If enabled, when creating VPN connection we will attempt to use 2 ANG floating IPs.
    /// </summary>
    public TerraformProperty<bool>? EnableHighAvailability
    {
        get => GetProperty<TerraformProperty<bool>>("enable_high_availability");
        set => this.WithProperty("enable_high_availability", value);
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
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Google Cloud Platform location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of VPN connection
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// NAT gateway IP, or WAN IP address. If a customer has multiple NAT IPs, the customer needs to configure NAT such that only one external IP maps to the GMEC Anthos cluster.
    /// This is empty if NAT is not used.
    /// </summary>
    public TerraformProperty<string>? NatGatewayIp
    {
        get => GetProperty<TerraformProperty<string>>("nat_gateway_ip");
        set => this.WithProperty("nat_gateway_ip", value);
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
    /// The VPN connection Cloud Router name.
    /// </summary>
    public TerraformProperty<string>? Router
    {
        get => GetProperty<TerraformProperty<string>>("router");
        set => this.WithProperty("router", value);
    }

    /// <summary>
    /// The network ID of VPC to connect to.
    /// </summary>
    public TerraformProperty<string>? Vpc
    {
        get => GetProperty<TerraformProperty<string>>("vpc");
        set => this.WithProperty("vpc", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEdgecontainerVpnConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleEdgecontainerVpnConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_project.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcProject block(s) allowed")]
    public List<GoogleEdgecontainerVpnConnectionVpcProjectBlock>? VpcProject
    {
        get => GetProperty<List<GoogleEdgecontainerVpnConnectionVpcProjectBlock>>("vpc_project");
        set => this.WithProperty("vpc_project", value);
    }

    /// <summary>
    /// The time when the VPN connection was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// A nested object resource.
    /// </summary>
    public TerraformExpression Details => this["details"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time when the VPN connection was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
