using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in GoogleNetworkManagementConnectivityTest.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    public TerraformValue<string>? CloudSqlInstance
    {
        get => GetArgument<TerraformValue<string>>("cloud_sql_instance");
        set => SetArgument("cloud_sql_instance", value);
    }

    /// <summary>
    /// Forwarding rule URI. Forwarding rules are frontends for load balancers,
    /// PSC endpoints, and Protocol Forwarding.
    /// </summary>
    public TerraformValue<string>? ForwardingRule
    {
        get => GetArgument<TerraformValue<string>>("forwarding_rule");
        set => SetArgument("forwarding_rule", value);
    }

    /// <summary>
    /// A DNS endpoint of Google Kubernetes Engine cluster control plane.
    /// Requires gke_master_cluster to be set, can&#39;t be used simultaneoulsly with
    /// ip_address or network. Applicable only to destination endpoint.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => GetArgument<TerraformValue<string>>("fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    public TerraformValue<string>? GkeMasterCluster
    {
        get => GetArgument<TerraformValue<string>>("gke_master_cluster");
        set => SetArgument("gke_master_cluster", value);
    }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
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
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// A Redis Cluster URI.
    /// </summary>
    public TerraformValue<string>? RedisCluster
    {
        get => GetArgument<TerraformValue<string>>("redis_cluster");
        set => SetArgument("redis_cluster", value);
    }

    /// <summary>
    /// A Redis Instance URI.
    /// </summary>
    public TerraformValue<string>? RedisInstance
    {
        get => GetArgument<TerraformValue<string>>("redis_instance");
        set => SetArgument("redis_instance", value);
    }

}


/// <summary>
/// Block type for source in GoogleNetworkManagementConnectivityTest.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    public TerraformValue<string>? CloudSqlInstance
    {
        get => GetArgument<TerraformValue<string>>("cloud_sql_instance");
        set => SetArgument("cloud_sql_instance", value);
    }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    public TerraformValue<string>? GkeMasterCluster
    {
        get => GetArgument<TerraformValue<string>>("gke_master_cluster");
        set => SetArgument("gke_master_cluster", value);
    }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Type of the network where the endpoint is located. Possible values: [&amp;quot;GCP_NETWORK&amp;quot;, &amp;quot;NON_GCP_NETWORK&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NetworkType
    {
        get => GetArgument<TerraformValue<string>>("network_type");
        set => SetArgument("network_type", value);
    }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
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
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// AppEngineVersion block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineVersion block(s) allowed")]
    public TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockAppEngineVersionBlock>? AppEngineVersion
    {
        get => GetArgument<TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockAppEngineVersionBlock>>("app_engine_version");
        set => SetArgument("app_engine_version", value);
    }

    /// <summary>
    /// CloudFunction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudFunction block(s) allowed")]
    public TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockCloudFunctionBlock>? CloudFunction
    {
        get => GetArgument<TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockCloudFunctionBlock>>("cloud_function");
        set => SetArgument("cloud_function", value);
    }

    /// <summary>
    /// CloudRunRevision block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudRunRevision block(s) allowed")]
    public TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockCloudRunRevisionBlock>? CloudRunRevision
    {
        get => GetArgument<TerraformList<GoogleNetworkManagementConnectivityTestSourceBlockCloudRunRevisionBlock>>("cloud_run_revision");
        set => SetArgument("cloud_run_revision", value);
    }

}

/// <summary>
/// Block type for app_engine_version in GoogleNetworkManagementConnectivityTestSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlockAppEngineVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_engine_version";

    /// <summary>
    /// An App Engine service version name.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for cloud_function in GoogleNetworkManagementConnectivityTestSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlockCloudFunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_function";

    /// <summary>
    /// A Cloud Function name.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for cloud_run_revision in GoogleNetworkManagementConnectivityTestSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlockCloudRunRevisionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_run_revision";

    /// <summary>
    /// A Cloud Run revision URI.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkManagementConnectivityTest.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementConnectivityTestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_management_connectivity_test Terraform resource.
/// Manages a google_network_management_connectivity_test resource.
/// </summary>
public partial class GoogleNetworkManagementConnectivityTest(string name) : TerraformResource("google_network_management_connectivity_test", name)
{
    /// <summary>
    /// Whether the analysis should skip firewall checking. Default value is false.
    /// </summary>
    public TerraformValue<bool>? BypassFirewallChecks
    {
        get => GetArgument<TerraformValue<bool>>("bypass_firewall_checks");
        set => SetArgument("bypass_firewall_checks", value);
    }

    /// <summary>
    /// The user-supplied description of the Connectivity Test.
    /// Maximum of 512 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
    /// IP Protocol of the test. When not provided, &amp;quot;TCP&amp;quot; is assumed.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Other projects that may be relevant for reachability analysis.
    /// This is applicable to scenarios where a test can cross project
    /// boundaries.
    /// </summary>
    public TerraformList<string>? RelatedProjects
    {
        get => GetArgument<TerraformList<string>>("related_projects");
        set => SetArgument("related_projects", value);
    }

    /// <summary>
    /// Whether run analysis for the return path from destination to source.
    /// Default value is false.
    /// </summary>
    public TerraformValue<bool>? RoundTrip
    {
        get => GetArgument<TerraformValue<bool>>("round_trip");
        set => SetArgument("round_trip", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<GoogleNetworkManagementConnectivityTestDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkManagementConnectivityTestDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleNetworkManagementConnectivityTestSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkManagementConnectivityTestSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkManagementConnectivityTestTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkManagementConnectivityTestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
