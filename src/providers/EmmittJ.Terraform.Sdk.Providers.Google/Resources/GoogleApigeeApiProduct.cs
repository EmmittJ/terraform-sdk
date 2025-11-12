using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: set
/// </summary>
public partial class GoogleApigeeApiProductAttributesBlock() : TerraformBlock("attributes")
{
    /// <summary>
    /// Key of the attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for graphql_operation_group in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeApiProductGraphqlOperationGroupBlock() : TerraformBlock("graphql_operation_group")
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    [TerraformProperty("operation_config_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperationConfigType { get; set; }

}

/// <summary>
/// Block type for grpc_operation_group in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeApiProductGrpcOperationGroupBlock() : TerraformBlock("grpc_operation_group")
{
}

/// <summary>
/// Block type for operation_group in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeApiProductOperationGroupBlock() : TerraformBlock("operation_group")
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    [TerraformProperty("operation_config_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperationConfigType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeApiProductTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_apigee_api_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeApiProduct : TerraformResource
{
    public GoogleApigeeApiProduct(string name) : base("google_apigee_api_product", name)
    {
    }

    /// <summary>
    /// Comma-separated list of API resources to be bundled in the API product. By default, the resource paths are mapped from the proxy.pathsuffix variable.
    /// The proxy path suffix is defined as the URI fragment following the ProxyEndpoint base path. For example, if the apiResources element is defined to be /forecastrss and the base path defined for the API proxy is /weather, then only requests to /weather/forecastrss are permitted by the API product.
    /// </summary>
    [TerraformProperty("api_resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ApiResources { get; set; }

    /// <summary>
    /// Flag that specifies how API keys are approved to access the APIs defined by the API product.
    /// Valid values are &#39;auto&#39; or &#39;manual&#39;. Possible values: [&amp;quot;auto&amp;quot;, &amp;quot;manual&amp;quot;]
    /// </summary>
    [TerraformProperty("approval_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApprovalType { get; set; }

    /// <summary>
    /// Description of the API product. Include key information about the API product that is not captured by other fields.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Name displayed in the UI or developer portal to developers registering for API access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Comma-separated list of environment names to which the API product is bound. Requests to environments that are not listed are rejected.
    /// By specifying one or more environments, you can bind the resources listed in the API product to a specific environment, preventing developers from accessing those resources through API proxies deployed in another environment.
    /// </summary>
    [TerraformProperty("environments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Environments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Internal name of the API product.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API product,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Comma-separated list of API proxy names to which this API product is bound. By specifying API proxies, you can associate resources in the API product with specific API proxies, preventing developers from accessing those resources through other API proxies.
    /// Apigee rejects requests to API proxies that are not listed.
    /// </summary>
    [TerraformProperty("proxies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Proxies { get; set; }

    /// <summary>
    /// Number of request messages permitted per app by this API product for the specified quotaInterval and quotaTimeUnit.
    /// For example, a quota of 50, for a quotaInterval of 12 and a quotaTimeUnit of hours means 50 requests are allowed every 12 hours.
    /// </summary>
    [TerraformProperty("quota")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Quota { get; set; }

    /// <summary>
    /// Scope of the quota decides how the quota counter gets applied and evaluate for quota violation. If the Scope is set as PROXY, then all the operations defined for the APIproduct that are associated with the same proxy will share the same quota counter set at the APIproduct level, making it a global counter at a proxy level. If the Scope is set as OPERATION, then each operations get the counter set at the API product dedicated, making it a local counter. Note that, the QuotaCounterScope applies only when an operation does not have dedicated quota set for itself. Possible values: [&amp;quot;QUOTA_COUNTER_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;OPERATION&amp;quot;]
    /// </summary>
    [TerraformProperty("quota_counter_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuotaCounterScope { get; set; }

    /// <summary>
    /// Time interval over which the number of request messages is calculated.
    /// </summary>
    [TerraformProperty("quota_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuotaInterval { get; set; }

    /// <summary>
    /// Time unit defined for the quotaInterval. Valid values include second, minute, hour, day, month or year.
    /// </summary>
    [TerraformProperty("quota_time_unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QuotaTimeUnit { get; set; }

    /// <summary>
    /// Comma-separated list of OAuth scopes that are validated at runtime. Apigee validates that the scopes in any access token presented match the scopes defined in the OAuth policy associated with the API product.
    /// </summary>
    [TerraformProperty("scopes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Scopes { get; set; }

    /// <summary>
    /// Optional. The resource ID of the parent Space. If not set, the parent resource will be the Organization.
    /// </summary>
    [TerraformProperty("space")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Space { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("attributes")]
    public TerraformSet<GoogleApigeeApiProductAttributesBlock> Attributes { get; set; } = new();

    /// <summary>
    /// Block for graphql_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GraphqlOperationGroup block(s) allowed")]
    [TerraformProperty("graphql_operation_group")]
    public TerraformList<GoogleApigeeApiProductGraphqlOperationGroupBlock> GraphqlOperationGroup { get; set; } = new();

    /// <summary>
    /// Block for grpc_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcOperationGroup block(s) allowed")]
    [TerraformProperty("grpc_operation_group")]
    public TerraformList<GoogleApigeeApiProductGrpcOperationGroupBlock> GrpcOperationGroup { get; set; } = new();

    /// <summary>
    /// Block for operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationGroup block(s) allowed")]
    [TerraformProperty("operation_group")]
    public TerraformList<GoogleApigeeApiProductOperationGroupBlock> OperationGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeApiProductTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Response only. Creation time of this environment as milliseconds since epoch.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// Response only. Modified time of this environment as milliseconds since epoch.
    /// </summary>
    [TerraformProperty("last_modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedAt { get; }

}
