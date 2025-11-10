using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock : TerraformBlock
{
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
    public List<TerraformProperty<string>>? AllowedGoogleProducersResourceHierarchyLevel
    {
        set => SetProperty("allowed_google_producers_resource_hierarchy_level", value);
    }

    /// <summary>
    /// Max number of PSC connections for this policy.
    /// </summary>
    public TerraformProperty<string>? Limit
    {
        set => SetProperty("limit", value);
    }

    /// <summary>
    /// ProducerInstanceLocation is used to specify which authorization mechanism to use to determine which projects
    /// the Producer instance can be within. Possible values: [&amp;quot;PRODUCER_INSTANCE_LOCATION_UNSPECIFIED&amp;quot;, &amp;quot;CUSTOM_RESOURCE_HIERARCHY_LEVELS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ProducerInstanceLocation
    {
        set => SetProperty("producer_instance_location", value);
    }

    /// <summary>
    /// IDs of the subnetworks or fully qualified identifiers for the subnetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetworks is required")]
    public List<TerraformProperty<string>>? Subnetworks
    {
        set => SetProperty("subnetworks", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_connectivity_service_connection_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivityServiceConnectionPolicy : TerraformResource
{
    public GoogleNetworkConnectivityServiceConnectionPolicy(string name) : base("google_network_connectivity_service_connection_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("infrastructure");
        SetOutput("psc_connections");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network");
        SetOutput("project");
        SetOutput("service_class");
    }

    /// <summary>
    /// Free-text description of the resource.
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
    /// User-defined labels.
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
    /// The location of the ServiceConnectionPolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of a ServiceConnectionPolicy. Format: projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy} See: https://google.aip.dev/122#fields-representing-resource-names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource path of the consumer network. Example: - projects/{projectNumOrId}/global/networks/{resourceId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
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
    /// The service class identifier for which this ServiceConnectionPolicy is for. The service class identifier is a unique, symbolic representation of a ServiceClass.
    /// It is provided by the Service Producer. Google services have a prefix of gcp. For example, gcp-cloud-sql. 3rd party services do not. For example, test-service-a3dfcx.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceClass is required")]
    public required TerraformProperty<string> ServiceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_class");
        set => SetProperty("service_class", value);
    }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public List<GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock>? PscConfig
    {
        set => SetProperty("psc_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The etag is computed by the server, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The type of underlying resources used to create the connection.
    /// </summary>
    public TerraformExpression Infrastructure => this["infrastructure"];

    /// <summary>
    /// Information about each Private Service Connect connection.
    /// </summary>
    public TerraformExpression PscConnections => this["psc_connections"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
