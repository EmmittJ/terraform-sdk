using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_config in GoogleNetworkConnectivityServiceConnectionPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_config";

    /// <summary>
    /// List of Projects, Folders, or Organizations from where the Producer instance can be within. For example,
    /// a network administrator can provide both &#39;organizations/foo&#39; and &#39;projects/bar&#39; as
    /// allowed_google_producers_resource_hierarchy_levels. This allowlists this network to connect with any Producer
    /// instance within the &#39;foo&#39; organization or the &#39;bar&#39; project. By default,
    /// allowedGoogleProducersResourceHierarchyLevel is empty. The format for each
    /// allowedGoogleProducersResourceHierarchyLevel is / where is one of &#39;projects&#39;, &#39;folders&#39;, or &#39;organizations&#39;
    /// and is either the ID or the number of the resource type. Format for each
    /// allowedGoogleProducersResourceHierarchyLevel value: &#39;projects/&#39; or &#39;folders/&#39; or &#39;organizations/&#39; Eg.
    /// [projects/my-project-id, projects/567, folders/891, organizations/123]
    /// </summary>
    public TerraformList<string>? AllowedGoogleProducersResourceHierarchyLevel
    {
        get => GetArgument<TerraformList<string>>("allowed_google_producers_resource_hierarchy_level");
        set => SetArgument("allowed_google_producers_resource_hierarchy_level", value);
    }

    /// <summary>
    /// Max number of PSC connections for this policy.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => GetArgument<TerraformValue<string>>("limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// ProducerInstanceLocation is used to specify which authorization mechanism to use to determine which projects
    /// the Producer instance can be within. Possible values: [&amp;quot;PRODUCER_INSTANCE_LOCATION_UNSPECIFIED&amp;quot;, &amp;quot;CUSTOM_RESOURCE_HIERARCHY_LEVELS&amp;quot;]
    /// </summary>
    public TerraformValue<string> ProducerInstanceLocation
    {
        get => GetArgument<TerraformValue<string>>("producer_instance_location") ?? AsReference("producer_instance_location");
        set => SetArgument("producer_instance_location", value);
    }

    /// <summary>
    /// IDs of the subnetworks or fully qualified identifiers for the subnetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetworks is required")]
    public TerraformList<string>? Subnetworks
    {
        get => GetArgument<TerraformList<string>>("subnetworks");
        set => SetArgument("subnetworks", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkConnectivityServiceConnectionPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_connectivity_service_connection_policy Terraform resource.
/// Manages a google_network_connectivity_service_connection_policy resource.
/// </summary>
public partial class GoogleNetworkConnectivityServiceConnectionPolicy(string name) : TerraformResource("google_network_connectivity_service_connection_policy", name)
{
    /// <summary>
    /// Free-text description of the resource.
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels.
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
    /// The location of the ServiceConnectionPolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of a ServiceConnectionPolicy. Format: projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy} See: https://google.aip.dev/122#fields-representing-resource-names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource path of the consumer network. Example: - projects/{projectNumOrId}/global/networks/{resourceId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service class identifier for which this ServiceConnectionPolicy is for. The service class identifier is a unique, symbolic representation of a ServiceClass.
    /// It is provided by the Service Producer. Google services have a prefix of gcp. For example, gcp-cloud-sql. 3rd party services do not. For example, test-service-a3dfcx.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceClass is required")]
    public required TerraformValue<string> ServiceClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_class");
        set => SetArgument("service_class", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The etag is computed by the server, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The type of underlying resources used to create the connection.
    /// </summary>
    public TerraformValue<string> Infrastructure
        => AsReference("infrastructure");

    /// <summary>
    /// Information about each Private Service Connect connection.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConnections
        => AsReference("psc_connections");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// PscConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public TerraformList<GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock>? PscConfig
    {
        get => GetArgument<TerraformList<GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock>>("psc_config");
        set => SetArgument("psc_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
