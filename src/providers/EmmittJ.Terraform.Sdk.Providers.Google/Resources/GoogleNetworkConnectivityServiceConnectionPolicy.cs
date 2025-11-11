using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock
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
    [TerraformPropertyName("allowed_google_producers_resource_hierarchy_level")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedGoogleProducersResourceHierarchyLevel { get; set; }

    /// <summary>
    /// Max number of PSC connections for this policy.
    /// </summary>
    [TerraformPropertyName("limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Limit { get; set; }

    /// <summary>
    /// ProducerInstanceLocation is used to specify which authorization mechanism to use to determine which projects
    /// the Producer instance can be within. Possible values: [&amp;quot;PRODUCER_INSTANCE_LOCATION_UNSPECIFIED&amp;quot;, &amp;quot;CUSTOM_RESOURCE_HIERARCHY_LEVELS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("producer_instance_location")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProducerInstanceLocation { get; set; } = default!;

    /// <summary>
    /// IDs of the subnetworks or fully qualified identifiers for the subnetworks
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetworks is required")]
    [TerraformPropertyName("subnetworks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Subnetworks { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_connectivity_service_connection_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkConnectivityServiceConnectionPolicy : TerraformResource
{
    public GoogleNetworkConnectivityServiceConnectionPolicy(string name) : base("google_network_connectivity_service_connection_policy", name)
    {
    }

    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the ServiceConnectionPolicy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of a ServiceConnectionPolicy. Format: projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy} See: https://google.aip.dev/122#fields-representing-resource-names
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource path of the consumer network. Example: - projects/{projectNumOrId}/global/networks/{resourceId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The service class identifier for which this ServiceConnectionPolicy is for. The service class identifier is a unique, symbolic representation of a ServiceClass.
    /// It is provided by the Service Producer. Google services have a prefix of gcp. For example, gcp-cloud-sql. 3rd party services do not. For example, test-service-a3dfcx.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceClass is required")]
    [TerraformPropertyName("service_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceClass { get; set; }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    [TerraformPropertyName("psc_config")]
    public TerraformList<TerraformBlock<GoogleNetworkConnectivityServiceConnectionPolicyPscConfigBlock>>? PscConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkConnectivityServiceConnectionPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The etag is computed by the server, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The type of underlying resources used to create the connection.
    /// </summary>
    [TerraformPropertyName("infrastructure")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Infrastructure => new TerraformReference(this, "infrastructure");

    /// <summary>
    /// Information about each Private Service Connect connection.
    /// </summary>
    [TerraformPropertyName("psc_connections")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscConnections => new TerraformReference(this, "psc_connections");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
