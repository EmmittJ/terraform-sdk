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
        set => SetProperty("current_aggregate_node_count", value);
    }

    /// <summary>
    /// The maximum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended maximum number of nodes for that gateway.
    /// </summary>
    public TerraformProperty<string>? MaxNodeCount
    {
        set => SetProperty("max_node_count", value);
    }

    /// <summary>
    /// The minimum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended minimum number of nodes for that gateway.
    /// </summary>
    public TerraformProperty<string>? MinNodeCount
    {
        set => SetProperty("min_node_count", value);
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
/// Manages a google_apigee_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeEnvironment : TerraformResource
{
    public GoogleApigeeEnvironment(string name) : base("google_apigee_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_proxy_type");
        SetOutput("deployment_type");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("forward_proxy_uri");
        SetOutput("id");
        SetOutput("name");
        SetOutput("org_id");
        SetOutput("type");
    }

    /// <summary>
    /// Optional. API Proxy type supported by the environment. The type can be set when creating
    /// the Environment and cannot be changed. Possible values: [&amp;quot;API_PROXY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROGRAMMABLE&amp;quot;, &amp;quot;CONFIGURABLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ApiProxyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_proxy_type");
        set => SetProperty("api_proxy_type", value);
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
    public TerraformProperty<string> DeploymentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_type");
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// Description of the environment.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Display name of the environment.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of &amp;quot;http&amp;quot; or &amp;quot;https&amp;quot;, and the port must be supplied.
    /// </summary>
    public TerraformProperty<string> ForwardProxyUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forward_proxy_uri");
        set => SetProperty("forward_proxy_uri", value);
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
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Types that can be selected for an Environment. Each of the types are
    /// limited by capability and capacity. Refer to Apigee&#39;s public documentation
    /// to understand about each of these types in details.
    /// An Apigee org can support heterogeneous Environments. Possible values: [&amp;quot;ENVIRONMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;BASE&amp;quot;, &amp;quot;INTERMEDIATE&amp;quot;, &amp;quot;COMPREHENSIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for client_ip_resolution_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientIpResolutionConfig block(s) allowed")]
    public List<GoogleApigeeEnvironmentClientIpResolutionConfigBlock>? ClientIpResolutionConfig
    {
        set => SetProperty("client_ip_resolution_config", value);
    }

    /// <summary>
    /// Block for node_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public List<GoogleApigeeEnvironmentNodeConfigBlock>? NodeConfig
    {
        set => SetProperty("node_config", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleApigeeEnvironmentPropertiesBlock>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
