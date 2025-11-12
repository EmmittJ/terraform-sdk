using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_ip_resolution_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeEnvironmentClientIpResolutionConfigBlock() : TerraformBlock("client_ip_resolution_config")
{
}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeEnvironmentNodeConfigBlock() : TerraformBlock("node_config")
{

    /// <summary>
    /// The maximum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended maximum number of nodes for that gateway.
    /// </summary>
    [TerraformProperty("max_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxNodeCount { get; set; }

    /// <summary>
    /// The minimum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended minimum number of nodes for that gateway.
    /// </summary>
    [TerraformProperty("min_node_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinNodeCount { get; set; }

}

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeEnvironmentPropertiesBlock() : TerraformBlock("properties")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeEnvironmentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeEnvironment : TerraformResource
{
    public GoogleApigeeEnvironment(string name) : base("google_apigee_environment", name)
    {
    }

    /// <summary>
    /// Optional. API Proxy type supported by the environment. The type can be set when creating
    /// the Environment and cannot be changed. Possible values: [&amp;quot;API_PROXY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROGRAMMABLE&amp;quot;, &amp;quot;CONFIGURABLE&amp;quot;]
    /// </summary>
    [TerraformProperty("api_proxy_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ApiProxyType { get; set; }

    /// <summary>
    /// Optional. Deployment type supported by the environment. The deployment type can be
    /// set when creating the environment and cannot be changed. When you enable archive
    /// deployment, you will be prevented from performing a subset of actions within the
    /// environment, including:
    /// Managing the deployment of API proxy or shared flow revisions;
    /// Creating, updating, or deleting resource files;
    /// Creating, updating, or deleting target servers. Possible values: [&amp;quot;DEPLOYMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeploymentType { get; set; }

    /// <summary>
    /// Description of the environment.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Display name of the environment.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of &amp;quot;http&amp;quot; or &amp;quot;https&amp;quot;, and the port must be supplied.
    /// </summary>
    [TerraformProperty("forward_proxy_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardProxyUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Types that can be selected for an Environment. Each of the types are
    /// limited by capability and capacity. Refer to Apigee&#39;s public documentation
    /// to understand about each of these types in details.
    /// An Apigee org can support heterogeneous Environments. Possible values: [&amp;quot;ENVIRONMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;BASE&amp;quot;, &amp;quot;INTERMEDIATE&amp;quot;, &amp;quot;COMPREHENSIVE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for client_ip_resolution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientIpResolutionConfig block(s) allowed")]
    [TerraformProperty("client_ip_resolution_config")]
    public TerraformList<GoogleApigeeEnvironmentClientIpResolutionConfigBlock> ClientIpResolutionConfig { get; set; } = new();

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    [TerraformProperty("node_config")]
    public TerraformList<GoogleApigeeEnvironmentNodeConfigBlock> NodeConfig { get; set; } = new();

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformProperty("properties")]
    public TerraformList<GoogleApigeeEnvironmentPropertiesBlock> Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeEnvironmentTimeoutsBlock Timeouts { get; set; } = new();

}
