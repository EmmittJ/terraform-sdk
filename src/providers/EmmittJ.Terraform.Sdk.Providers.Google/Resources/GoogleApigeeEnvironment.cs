using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_ip_resolution_config in GoogleApigeeEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentClientIpResolutionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_ip_resolution_config";

    /// <summary>
    /// HeaderIndexAlgorithm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderIndexAlgorithm block(s) allowed")]
    public TerraformList<GoogleApigeeEnvironmentClientIpResolutionConfigBlockHeaderIndexAlgorithmBlock>? HeaderIndexAlgorithm
    {
        get => GetArgument<TerraformList<GoogleApigeeEnvironmentClientIpResolutionConfigBlockHeaderIndexAlgorithmBlock>>("header_index_algorithm");
        set => SetArgument("header_index_algorithm", value);
    }

}

/// <summary>
/// Block type for header_index_algorithm in GoogleApigeeEnvironmentClientIpResolutionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentClientIpResolutionConfigBlockHeaderIndexAlgorithmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_index_algorithm";

    /// <summary>
    /// The index of the ip in the header. Positive indices 0, 1, 2, 3 chooses indices from the left (first ips). Negative indices -1, -2, -3 chooses indices from the right (last ips).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpHeaderIndex is required")]
    public required TerraformValue<double> IpHeaderIndex
    {
        get => new TerraformReference<double>(this, "ip_header_index");
        set => SetArgument("ip_header_index", value);
    }

    /// <summary>
    /// The name of the header to extract the client ip from. We are currently only supporting the X-Forwarded-For header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpHeaderName is required")]
    public required TerraformValue<string> IpHeaderName
    {
        get => new TerraformReference<string>(this, "ip_header_name");
        set => SetArgument("ip_header_name", value);
    }

}


/// <summary>
/// Block type for node_config in GoogleApigeeEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentNodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_config";

    /// <summary>
    /// The current total number of gateway nodes that each environment currently has across
    /// all instances.
    /// </summary>
    public TerraformValue<string> CurrentAggregateNodeCount
    {
        get => new TerraformReference<string>(this, "current_aggregate_node_count");
    }

    /// <summary>
    /// The maximum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended maximum number of nodes for that gateway.
    /// </summary>
    public TerraformValue<string>? MaxNodeCount
    {
        get => new TerraformReference<string>(this, "max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The minimum total number of gateway nodes that the is reserved for all instances that
    /// has the specified environment. If not specified, the default is determined by the
    /// recommended minimum number of nodes for that gateway.
    /// </summary>
    public TerraformValue<string>? MinNodeCount
    {
        get => new TerraformReference<string>(this, "min_node_count");
        set => SetArgument("min_node_count", value);
    }

}


/// <summary>
/// Block type for properties in GoogleApigeeEnvironment.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// Property block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeEnvironmentPropertiesBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformList<GoogleApigeeEnvironmentPropertiesBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for property in GoogleApigeeEnvironmentPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeEnvironmentPropertiesBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The property key.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The property value.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeEnvironment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_environment Terraform resource.
/// Manages a google_apigee_environment resource.
/// </summary>
public partial class GoogleApigeeEnvironment(string name) : TerraformResource("google_apigee_environment", name)
{
    /// <summary>
    /// Optional. API Proxy type supported by the environment. The type can be set when creating
    /// the Environment and cannot be changed. Possible values: [&amp;quot;API_PROXY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PROGRAMMABLE&amp;quot;, &amp;quot;CONFIGURABLE&amp;quot;]
    /// </summary>
    public TerraformValue<string> ApiProxyType
    {
        get => new TerraformReference<string>(this, "api_proxy_type");
        set => SetArgument("api_proxy_type", value);
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
    public TerraformValue<string> DeploymentType
    {
        get => new TerraformReference<string>(this, "deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// Description of the environment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name of the environment.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of &amp;quot;http&amp;quot; or &amp;quot;https&amp;quot;, and the port must be supplied.
    /// </summary>
    public TerraformValue<string>? ForwardProxyUri
    {
        get => new TerraformReference<string>(this, "forward_proxy_uri");
        set => SetArgument("forward_proxy_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Types that can be selected for an Environment. Each of the types are
    /// limited by capability and capacity. Refer to Apigee&#39;s public documentation
    /// to understand about each of these types in details.
    /// An Apigee org can support heterogeneous Environments. Possible values: [&amp;quot;ENVIRONMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;BASE&amp;quot;, &amp;quot;INTERMEDIATE&amp;quot;, &amp;quot;COMPREHENSIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// ClientIpResolutionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientIpResolutionConfig block(s) allowed")]
    public TerraformList<GoogleApigeeEnvironmentClientIpResolutionConfigBlock>? ClientIpResolutionConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeEnvironmentClientIpResolutionConfigBlock>>("client_ip_resolution_config");
        set => SetArgument("client_ip_resolution_config", value);
    }

    /// <summary>
    /// NodeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeConfig block(s) allowed")]
    public TerraformList<GoogleApigeeEnvironmentNodeConfigBlock>? NodeConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeEnvironmentNodeConfigBlock>>("node_config");
        set => SetArgument("node_config", value);
    }

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleApigeeEnvironmentPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleApigeeEnvironmentPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
