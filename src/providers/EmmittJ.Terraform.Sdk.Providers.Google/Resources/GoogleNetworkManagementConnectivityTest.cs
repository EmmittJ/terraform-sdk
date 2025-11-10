using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestDestinationBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    public TerraformProperty<string>? CloudSqlInstance
    {
        set => SetProperty("cloud_sql_instance", value);
    }

    /// <summary>
    /// Forwarding rule URI. Forwarding rules are frontends for load balancers,
    /// PSC endpoints, and Protocol Forwarding.
    /// </summary>
    public TerraformProperty<string>? ForwardingRule
    {
        set => SetProperty("forwarding_rule", value);
    }

    /// <summary>
    /// A DNS endpoint of Google Kubernetes Engine cluster control plane.
    /// Requires gke_master_cluster to be set, can&#39;t be used simultaneoulsly with
    /// ip_address or network. Applicable only to destination endpoint.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        set => SetProperty("fqdn", value);
    }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    public TerraformProperty<string>? GkeMasterCluster
    {
        set => SetProperty("gke_master_cluster", value);
    }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Project ID where the endpoint is located.
    /// The project ID can be derived from the URI if you provide a endpoint or
    /// network URI.
    /// The following are two cases where you may need to provide the project ID:
    /// 1. Only the IP address is specified, and the IP address is within a Google
    /// Cloud project.
    /// 2. When you are using Shared VPC and the IP address that you provide is
    /// from the service project. In this case, the network that the IP address
    /// resides in is defined in the host project.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

    /// <summary>
    /// A Redis Cluster URI.
    /// </summary>
    public TerraformProperty<string>? RedisCluster
    {
        set => SetProperty("redis_cluster", value);
    }

    /// <summary>
    /// A Redis Instance URI.
    /// </summary>
    public TerraformProperty<string>? RedisInstance
    {
        set => SetProperty("redis_instance", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    public TerraformProperty<string>? CloudSqlInstance
    {
        set => SetProperty("cloud_sql_instance", value);
    }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    public TerraformProperty<string>? GkeMasterCluster
    {
        set => SetProperty("gke_master_cluster", value);
    }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Type of the network where the endpoint is located. Possible values: [&amp;quot;GCP_NETWORK&amp;quot;, &amp;quot;NON_GCP_NETWORK&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NetworkType
    {
        set => SetProperty("network_type", value);
    }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Project ID where the endpoint is located.
    /// The project ID can be derived from the URI if you provide a endpoint or
    /// network URI.
    /// The following are two cases where you may need to provide the project ID:
    /// 1. Only the IP address is specified, and the IP address is within a Google
    /// Cloud project.
    /// 2. When you are using Shared VPC and the IP address that you provide is
    /// from the service project. In this case, the network that the IP address
    /// resides in is defined in the host project.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementConnectivityTestTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_management_connectivity_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkManagementConnectivityTest : TerraformResource
{
    public GoogleNetworkManagementConnectivityTest(string name) : base("google_network_management_connectivity_test", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("bypass_firewall_checks");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
        SetOutput("protocol");
        SetOutput("related_projects");
        SetOutput("round_trip");
    }

    /// <summary>
    /// Whether the analysis should skip firewall checking. Default value is false.
    /// </summary>
    public TerraformProperty<bool> BypassFirewallChecks
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bypass_firewall_checks");
        set => SetProperty("bypass_firewall_checks", value);
    }

    /// <summary>
    /// The user-supplied description of the Connectivity Test.
    /// Maximum of 512 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Resource labels to represent user-provided metadata.
    /// 
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
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// IP Protocol of the test. When not provided, &amp;quot;TCP&amp;quot; is assumed.
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// Other projects that may be relevant for reachability analysis.
    /// This is applicable to scenarios where a test can cross project
    /// boundaries.
    /// </summary>
    public List<TerraformProperty<string>> RelatedProjects
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("related_projects");
        set => SetProperty("related_projects", value);
    }

    /// <summary>
    /// Whether run analysis for the return path from destination to source.
    /// Default value is false.
    /// </summary>
    public TerraformProperty<bool> RoundTrip
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("round_trip");
        set => SetProperty("round_trip", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<GoogleNetworkManagementConnectivityTestDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<GoogleNetworkManagementConnectivityTestSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkManagementConnectivityTestTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
