using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? ApiProxyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_proxy_type")?.Value;
        set => this.WithProperty("api_proxy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type")?.Value;
        set => this.WithProperty("deployment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description of the environment.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display name of the environment.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. URI of the forward proxy to be applied to the runtime instances in this environment. Must be in the format of {scheme}://{hostname}:{port}. Note that the scheme must be one of &amp;quot;http&amp;quot; or &amp;quot;https&amp;quot;, and the port must be supplied.
    /// </summary>
    public string? ForwardProxyUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("forward_proxy_uri")?.Value;
        set => this.WithProperty("forward_proxy_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Types that can be selected for an Environment. Each of the types are
    /// limited by capability and capacity. Refer to Apigee&#39;s public documentation
    /// to understand about each of these types in details.
    /// An Apigee org can support heterogeneous Environments. Possible values: [&amp;quot;ENVIRONMENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;BASE&amp;quot;, &amp;quot;INTERMEDIATE&amp;quot;, &amp;quot;COMPREHENSIVE&amp;quot;]
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
