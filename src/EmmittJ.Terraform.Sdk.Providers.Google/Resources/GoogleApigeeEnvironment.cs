using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_ip_resolution_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentClientIpResolutionConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for node_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// The current total number of gateway nodes that each environment currently has across
    /// all instances.
    /// </summary>
    public TerraformProperty<string>? CurrentAggregateNodeCount
    {
        get => GetProperty<TerraformProperty<string>>("current_aggregate_node_count");
        set => WithProperty("current_aggregate_node_count", value);
    }

    /// <summary>
    /// The maximum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended maximum number of nodes for that gateway.
    /// </summary>
    public TerraformProperty<string>? MaxNodeCount
    {
        get => GetProperty<TerraformProperty<string>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// The minimum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended minimum number of nodes for that gateway.
    /// </summary>
    public TerraformProperty<string>? MinNodeCount
    {
        get => GetProperty<TerraformProperty<string>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

}

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentPropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_environment resource.
/// </summary>
public class GoogleApigeeEnvironment : TerraformResource
{
    public GoogleApigeeEnvironment(string name) : base("google_apigee_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Optional. API Proxy type supported by the environment. The type can be set when creating
    /// the Environment and cannot be changed. Possible values: [&amp;quot;API_PROXY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROGRAMMABLE&amp;quot;, &amp;quot;CONFIGURABLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ApiProxyType
    {
        get => GetProperty<TerraformProperty<string>>("api_proxy_type");
        set => this.WithProperty("api_proxy_type", value);
    }

    /// <summary>
    /// Optional. Deployment type supported by the environment. The deployment type can be
    /// set when creating the environment and cannot be changed. When you enable archive
    /// deployment, you will be prevented from performing a subset of actions within the
    /// environment, including:
    /// Managing the deployment of API proxy or shared flow revisions;
    /// Creating, updating, or deleting resource files;
    /// Creating, updating, or deleting target servers. Possible values: [&amp;quot;DEPLOYMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;ARCHIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DeploymentType
    {
        get => GetProperty<TerraformProperty<string>>("deployment_type");
        set => this.WithProperty("deployment_type", value);
    }

    /// <summary>
    /// Description of the environment.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Display name of the environment.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of &amp;quot;http&amp;quot; or &amp;quot;https&amp;quot;, and the port must be supplied.
    /// </summary>
    public TerraformProperty<string>? ForwardProxyUri
    {
        get => GetProperty<TerraformProperty<string>>("forward_proxy_uri");
        set => this.WithProperty("forward_proxy_uri", value);
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
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Types that can be selected for an Environment. Each of the types are
    /// limited by capability and capacity. Refer to Apigee&#39;s public documentation
    /// to understand about each of these types in details.
    /// An Apigee org can support heterogeneous Environments. Possible values: [&amp;quot;ENVIRONMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;BASE&amp;quot;, &amp;quot;INTERMEDIATE&amp;quot;, &amp;quot;COMPREHENSIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for client_ip_resolution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientIpResolutionConfig block(s) allowed")]
    public List<GoogleApigeeEnvironmentClientIpResolutionConfigBlock>? ClientIpResolutionConfig
    {
        get => GetProperty<List<GoogleApigeeEnvironmentClientIpResolutionConfigBlock>>("client_ip_resolution_config");
        set => this.WithProperty("client_ip_resolution_config", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleApigeeEnvironmentNodeConfigBlock>? NodeConfig
    {
        get => GetProperty<List<GoogleApigeeEnvironmentNodeConfigBlock>>("node_config");
        set => this.WithProperty("node_config", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleApigeeEnvironmentPropertiesBlock>? Properties
    {
        get => GetProperty<List<GoogleApigeeEnvironmentPropertiesBlock>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeEnvironmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
