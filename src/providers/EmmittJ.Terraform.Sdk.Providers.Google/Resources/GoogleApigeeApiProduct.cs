using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductAttributesBlock : ITerraformBlock
{
    /// <summary>
    /// Key of the attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for graphql_operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlock : ITerraformBlock
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    [TerraformPropertyName("operation_config_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OperationConfigType { get; set; }

}

/// <summary>
/// Block type for grpc_operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for operation_group in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlock : ITerraformBlock
{
    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    [TerraformPropertyName("operation_config_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OperationConfigType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiProductTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_api_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeApiProduct : TerraformResource
{
    public GoogleApigeeApiProduct(string name) : base("google_apigee_api_product", name)
    {
    }

    /// <summary>
    /// Comma-separated list of API resources to be bundled in the API product. By default, the resource paths are mapped from the proxy.pathsuffix variable.
    /// The proxy path suffix is defined as the URI fragment following the ProxyEndpoint base path. For example, if the apiResources element is defined to be /forecastrss and the base path defined for the API proxy is /weather, then only requests to /weather/forecastrss are permitted by the API product.
    /// </summary>
    [TerraformPropertyName("api_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ApiResources { get; set; }

    /// <summary>
    /// Flag that specifies how API keys are approved to access the APIs defined by the API product.
    /// Valid values are &#39;auto&#39; or &#39;manual&#39;. Possible values: [&amp;quot;auto&amp;quot;, &amp;quot;manual&amp;quot;]
    /// </summary>
    [TerraformPropertyName("approval_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApprovalType { get; set; }

    /// <summary>
    /// Description of the API product. Include key information about the API product that is not captured by other fields.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Name displayed in the UI or developer portal to developers registering for API access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Comma-separated list of environment names to which the API product is bound. Requests to environments that are not listed are rejected.
    /// By specifying one or more environments, you can bind the resources listed in the API product to a specific environment, preventing developers from accessing those resources through API proxies deployed in another environment.
    /// </summary>
    [TerraformPropertyName("environments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Environments { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Internal name of the API product.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API product,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Comma-separated list of API proxy names to which this API product is bound. By specifying API proxies, you can associate resources in the API product with specific API proxies, preventing developers from accessing those resources through other API proxies.
    /// Apigee rejects requests to API proxies that are not listed.
    /// </summary>
    [TerraformPropertyName("proxies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Proxies { get; set; }

    /// <summary>
    /// Number of request messages permitted per app by this API product for the specified quotaInterval and quotaTimeUnit.
    /// For example, a quota of 50, for a quotaInterval of 12 and a quotaTimeUnit of hours means 50 requests are allowed every 12 hours.
    /// </summary>
    [TerraformPropertyName("quota")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Quota { get; set; }

    /// <summary>
    /// Scope of the quota decides how the quota counter gets applied and evaluate for quota violation. If the Scope is set as PROXY, then all the operations defined for the APIproduct that are associated with the same proxy will share the same quota counter set at the APIproduct level, making it a global counter at a proxy level. If the Scope is set as OPERATION, then each operations get the counter set at the API product dedicated, making it a local counter. Note that, the QuotaCounterScope applies only when an operation does not have dedicated quota set for itself. Possible values: [&amp;quot;QUOTA_COUNTER_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;OPERATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("quota_counter_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuotaCounterScope { get; set; }

    /// <summary>
    /// Time interval over which the number of request messages is calculated.
    /// </summary>
    [TerraformPropertyName("quota_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuotaInterval { get; set; }

    /// <summary>
    /// Time unit defined for the quotaInterval. Valid values include second, minute, hour, day, month or year.
    /// </summary>
    [TerraformPropertyName("quota_time_unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QuotaTimeUnit { get; set; }

    /// <summary>
    /// Comma-separated list of OAuth scopes that are validated at runtime. Apigee validates that the scopes in any access token presented match the scopes defined in the OAuth policy associated with the API product.
    /// </summary>
    [TerraformPropertyName("scopes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// Optional. The resource ID of the parent Space. If not set, the parent resource will be the Organization.
    /// </summary>
    [TerraformPropertyName("space")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Space { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attributes")]
    public TerraformSet<TerraformBlock<GoogleApigeeApiProductAttributesBlock>>? Attributes { get; set; } = new();

    /// <summary>
    /// Block for graphql_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GraphqlOperationGroup block(s) allowed")]
    [TerraformPropertyName("graphql_operation_group")]
    public TerraformList<TerraformBlock<GoogleApigeeApiProductGraphqlOperationGroupBlock>>? GraphqlOperationGroup { get; set; } = new();

    /// <summary>
    /// Block for grpc_operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcOperationGroup block(s) allowed")]
    [TerraformPropertyName("grpc_operation_group")]
    public TerraformList<TerraformBlock<GoogleApigeeApiProductGrpcOperationGroupBlock>>? GrpcOperationGroup { get; set; } = new();

    /// <summary>
    /// Block for operation_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationGroup block(s) allowed")]
    [TerraformPropertyName("operation_group")]
    public TerraformList<TerraformBlock<GoogleApigeeApiProductOperationGroupBlock>>? OperationGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeApiProductTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Response only. Creation time of this environment as milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// Response only. Modified time of this environment as milliseconds since epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_at");

}
