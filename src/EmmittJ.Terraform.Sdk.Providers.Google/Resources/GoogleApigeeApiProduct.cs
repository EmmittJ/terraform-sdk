using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Key of the attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for graphql_operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlock : TerraformBlock
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? OperationConfigType
    {
        get => GetProperty<TerraformProperty<string>>("operation_config_type");
        set => WithProperty("operation_config_type", value);
    }

}

/// <summary>
/// Block type for grpc_operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlock : TerraformBlock
{
}

/// <summary>
/// Block type for operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlock : TerraformBlock
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? OperationConfigType
    {
        get => GetProperty<TerraformProperty<string>>("operation_config_type");
        set => WithProperty("operation_config_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiProductTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_api_product resource.
/// </summary>
public class GoogleApigeeApiProduct : TerraformResource
{
    public GoogleApigeeApiProduct(string name) : base("google_apigee_api_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("last_modified_at");
    }

    /// <summary>
    /// Comma-separated list of API resources to be bundled in the API product. By default, the resource paths are mapped from the proxy.pathsuffix variable.
    /// The proxy path suffix is defined as the URI fragment following the ProxyEndpoint base path. For example, if the apiResources element is defined to be /forecastrss and the base path defined for the API proxy is /weather, then only requests to /weather/forecastrss are permitted by the API product.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ApiResources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("api_resources");
        set => this.WithProperty("api_resources", value);
    }

    /// <summary>
    /// Flag that specifies how API keys are approved to access the APIs defined by the API product.
    /// Valid values are &#39;auto&#39; or &#39;manual&#39;. Possible values: [&amp;quot;auto&amp;quot;, &amp;quot;manual&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ApprovalType
    {
        get => GetProperty<TerraformProperty<string>>("approval_type");
        set => this.WithProperty("approval_type", value);
    }

    /// <summary>
    /// Description of the API product. Include key information about the API product that is not captured by other fields.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Name displayed in the UI or developer portal to developers registering for API access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Comma-separated list of environment names to which the API product is bound. Requests to environments that are not listed are rejected.
    /// By specifying one or more environments, you can bind the resources listed in the API product to a specific environment, preventing developers from accessing those resources through API proxies deployed in another environment.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Environments
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("environments");
        set => this.WithProperty("environments", value);
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
    /// Internal name of the API product.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API product,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Comma-separated list of API proxy names to which this API product is bound. By specifying API proxies, you can associate resources in the API product with specific API proxies, preventing developers from accessing those resources through other API proxies.
    /// Apigee rejects requests to API proxies that are not listed.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Proxies
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("proxies");
        set => this.WithProperty("proxies", value);
    }

    /// <summary>
    /// Number of request messages permitted per app by this API product for the specified quotaInterval and quotaTimeUnit.
    /// For example, a quota of 50, for a quotaInterval of 12 and a quotaTimeUnit of hours means 50 requests are allowed every 12 hours.
    /// </summary>
    public TerraformProperty<string>? Quota
    {
        get => GetProperty<TerraformProperty<string>>("quota");
        set => this.WithProperty("quota", value);
    }

    /// <summary>
    /// Scope of the quota decides how the quota counter gets applied and evaluate for quota violation. If the Scope is set as PROXY, then all the operations defined for the APIproduct that are associated with the same proxy will share the same quota counter set at the APIproduct level, making it a global counter at a proxy level. If the Scope is set as OPERATION, then each operations get the counter set at the API product dedicated, making it a local counter. Note that, the QuotaCounterScope applies only when an operation does not have dedicated quota set for itself. Possible values: [&amp;quot;QUOTA_COUNTER_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;OPERATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? QuotaCounterScope
    {
        get => GetProperty<TerraformProperty<string>>("quota_counter_scope");
        set => this.WithProperty("quota_counter_scope", value);
    }

    /// <summary>
    /// Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformProperty<string>? QuotaInterval
    {
        get => GetProperty<TerraformProperty<string>>("quota_interval");
        set => this.WithProperty("quota_interval", value);
    }

    /// <summary>
    /// Time unit defined for the quotaInterval. Valid values include second, minute, hour, day, month or year.
    /// </summary>
    public TerraformProperty<string>? QuotaTimeUnit
    {
        get => GetProperty<TerraformProperty<string>>("quota_time_unit");
        set => this.WithProperty("quota_time_unit", value);
    }

    /// <summary>
    /// Comma-separated list of OAuth scopes that are validated at runtime. Apigee validates that the scopes in any access token presented match the scopes defined in the OAuth policy associated with the API product.
    /// </summary>
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// Optional. The resource ID of the parent Space. If not set, the parent resource will be the Organization.
    /// </summary>
    public TerraformProperty<string>? Space
    {
        get => GetProperty<TerraformProperty<string>>("space");
        set => this.WithProperty("space", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleApigeeApiProductAttributesBlock>? Attributes
    {
        get => GetProperty<HashSet<GoogleApigeeApiProductAttributesBlock>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// Block for graphql_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GraphqlOperationGroup block(s) allowed")]
    public List<GoogleApigeeApiProductGraphqlOperationGroupBlock>? GraphqlOperationGroup
    {
        get => GetProperty<List<GoogleApigeeApiProductGraphqlOperationGroupBlock>>("graphql_operation_group");
        set => this.WithProperty("graphql_operation_group", value);
    }

    /// <summary>
    /// Block for grpc_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcOperationGroup block(s) allowed")]
    public List<GoogleApigeeApiProductGrpcOperationGroupBlock>? GrpcOperationGroup
    {
        get => GetProperty<List<GoogleApigeeApiProductGrpcOperationGroupBlock>>("grpc_operation_group");
        set => this.WithProperty("grpc_operation_group", value);
    }

    /// <summary>
    /// Block for operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationGroup block(s) allowed")]
    public List<GoogleApigeeApiProductOperationGroupBlock>? OperationGroup
    {
        get => GetProperty<List<GoogleApigeeApiProductOperationGroupBlock>>("operation_group");
        set => this.WithProperty("operation_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeApiProductTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeApiProductTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Response only. Creation time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Response only. Modified time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformExpression LastModifiedAt => this["last_modified_at"];

}
