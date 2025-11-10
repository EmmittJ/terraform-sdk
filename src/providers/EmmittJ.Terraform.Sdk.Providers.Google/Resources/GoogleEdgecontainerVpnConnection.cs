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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("project_id", value);
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
        SetOutput("create_time");
        SetOutput("details");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("cluster");
        SetOutput("enable_high_availability");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("nat_gateway_ip");
        SetOutput("project");
        SetOutput("router");
        SetOutput("vpc");
    }

    /// <summary>
    /// The canonical Cluster name to connect to. It is in the form of projects/{project}/locations/{location}/clusters/{cluster}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// Whether this VPN connection has HA enabled on cluster side. If enabled, when creating VPN connection we will attempt to use 2 ANG floating IPs.
    /// </summary>
    public TerraformProperty<bool> EnableHighAvailability
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_high_availability");
        set => SetProperty("enable_high_availability", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels associated with this resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Google Cloud Platform location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of VPN connection
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// NAT gateway IP, or WAN IP address. If a customer has multiple NAT IPs, the customer needs to configure NAT such that only one external IP maps to the GMEC Anthos cluster.
    /// This is empty if NAT is not used.
    /// </summary>
    public TerraformProperty<string> NatGatewayIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nat_gateway_ip");
        set => SetProperty("nat_gateway_ip", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The VPN connection Cloud Router name.
    /// </summary>
    public TerraformProperty<string> Router
    {
        get => GetRequiredOutput<TerraformProperty<string>>("router");
        set => SetProperty("router", value);
    }

    /// <summary>
    /// The network ID of VPC to connect to.
    /// </summary>
    public TerraformProperty<string> Vpc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc");
        set => SetProperty("vpc", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleEdgecontainerVpnConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_project.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcProject block(s) allowed")]
    public List<GoogleEdgecontainerVpnConnectionVpcProjectBlock>? VpcProject
    {
        set => SetProperty("vpc_project", value);
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
