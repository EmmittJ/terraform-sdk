using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApigeeApiProduct.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for graphql_operation_group in GoogleApigeeApiProduct.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "graphql_operation_group";

    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OperationConfigType
    {
        get => GetArgument<TerraformValue<string>>("operation_config_type");
        set => SetArgument("operation_config_type", value);
    }

    /// <summary>
    /// OperationConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock>? OperationConfigs
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock>>("operation_configs");
        set => SetArgument("operation_configs", value);
    }

}

/// <summary>
/// Block type for operation_configs in GoogleApigeeApiProductGraphqlOperationGroupBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_configs";

    /// <summary>
    /// Required. Name of the API proxy endpoint or remote service with which the GraphQL operation and quota are associated.
    /// </summary>
    public TerraformValue<string>? ApiSource
    {
        get => GetArgument<TerraformValue<string>>("api_source");
        set => SetArgument("api_source", value);
    }

    /// <summary>
    /// Attributes block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Operations block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

}

/// <summary>
/// Block type for attributes in GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for operations in GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operations";

    /// <summary>
    /// GraphQL operation name. The name and operation type will be used to apply quotas. If no name is specified, the quota will be applied to all GraphQL operations irrespective of their operation names in the payload.
    /// </summary>
    public TerraformValue<string>? Operation
    {
        get => GetArgument<TerraformValue<string>>("operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// Required. GraphQL operation types. Valid values include query or mutation.
    /// Note: Apigee does not currently support subscription types.
    /// </summary>
    public TerraformSet<string>? OperationTypes
    {
        get => GetArgument<TerraformSet<string>>("operation_types");
        set => SetArgument("operation_types", value);
    }

}

/// <summary>
/// Block type for quota in GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGraphqlOperationGroupBlockOperationConfigsBlockQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// Required. Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformValue<string>? Interval
    {
        get => GetArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => GetArgument<TerraformValue<string>>("limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => GetArgument<TerraformValue<string>>("time_unit");
        set => SetArgument("time_unit", value);
    }

}


/// <summary>
/// Block type for grpc_operation_group in GoogleApigeeApiProduct.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_operation_group";

    /// <summary>
    /// OperationConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlock>? OperationConfigs
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlock>>("operation_configs");
        set => SetArgument("operation_configs", value);
    }

}

/// <summary>
/// Block type for operation_configs in GoogleApigeeApiProductGrpcOperationGroupBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_configs";

    /// <summary>
    /// Required. Name of the API proxy with which the gRPC operation and quota are associated.
    /// </summary>
    public TerraformValue<string>? ApiSource
    {
        get => GetArgument<TerraformValue<string>>("api_source");
        set => SetArgument("api_source", value);
    }

    /// <summary>
    /// List of unqualified gRPC method names for the proxy to which quota will be applied. If this field is empty, the Quota will apply to all operations on the gRPC service defined on the proxy.
    /// 
    /// Example: Given a proxy that is configured to serve com.petstore.PetService, the methods com.petstore.PetService.ListPets and com.petstore.PetService.GetPet would be specified here as simply [&amp;quot;ListPets&amp;quot;, &amp;quot;GetPet&amp;quot;].
    /// 
    /// Note: Currently, you can specify only a single GraphQLOperation. Specifying more than one will cause the operation to fail.
    /// </summary>
    public TerraformSet<string>? Methods
    {
        get => GetArgument<TerraformSet<string>>("methods");
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// Required. gRPC Service name associated to be associated with the API proxy, on which quota rules can be applied upon.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Attributes block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

}

/// <summary>
/// Block type for attributes in GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for quota in GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductGrpcOperationGroupBlockOperationConfigsBlockQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// Required. Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformValue<string>? Interval
    {
        get => GetArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => GetArgument<TerraformValue<string>>("limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => GetArgument<TerraformValue<string>>("time_unit");
        set => SetArgument("time_unit", value);
    }

}


/// <summary>
/// Block type for operation_group in GoogleApigeeApiProduct.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_group";

    /// <summary>
    /// Flag that specifes whether the configuration is for Apigee API proxy or a remote service. Valid values include proxy or remoteservice. Defaults to proxy. Set to proxy when Apigee API proxies are associated with the API product. Set to remoteservice when non-Apigee proxies like Istio-Envoy are associated with the API product. Possible values: [&amp;quot;proxy&amp;quot;, &amp;quot;remoteservice&amp;quot;]
    /// </summary>
    public TerraformValue<string>? OperationConfigType
    {
        get => GetArgument<TerraformValue<string>>("operation_config_type");
        set => SetArgument("operation_config_type", value);
    }

    /// <summary>
    /// OperationConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock>? OperationConfigs
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock>>("operation_configs");
        set => SetArgument("operation_configs", value);
    }

}

/// <summary>
/// Block type for operation_configs in GoogleApigeeApiProductOperationGroupBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_configs";

    /// <summary>
    /// Required. Name of the API proxy or remote service with which the resources, methods, and quota are associated.
    /// </summary>
    public TerraformValue<string>? ApiSource
    {
        get => GetArgument<TerraformValue<string>>("api_source");
        set => SetArgument("api_source", value);
    }

    /// <summary>
    /// Attributes block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Operations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

}

/// <summary>
/// Block type for attributes in GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for operations in GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operations";

    /// <summary>
    /// Methods refers to the REST verbs, when none specified, all verb types are allowed.
    /// </summary>
    public TerraformSet<string>? Methods
    {
        get => GetArgument<TerraformSet<string>>("methods");
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// Required. REST resource path associated with the API proxy or remote service.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

}

/// <summary>
/// Block type for quota in GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeApiProductOperationGroupBlockOperationConfigsBlockQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// Required. Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformValue<string>? Interval
    {
        get => GetArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => GetArgument<TerraformValue<string>>("limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => GetArgument<TerraformValue<string>>("time_unit");
        set => SetArgument("time_unit", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeApiProduct.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiProductTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_api_product Terraform resource.
/// Manages a google_apigee_api_product resource.
/// </summary>
public partial class GoogleApigeeApiProduct(string name) : TerraformResource("google_apigee_api_product", name)
{
    /// <summary>
    /// Comma-separated list of API resources to be bundled in the API product. By default, the resource paths are mapped from the proxy.pathsuffix variable.
    /// The proxy path suffix is defined as the URI fragment following the ProxyEndpoint base path. For example, if the apiResources element is defined to be /forecastrss and the base path defined for the API proxy is /weather, then only requests to /weather/forecastrss are permitted by the API product.
    /// </summary>
    public TerraformSet<string>? ApiResources
    {
        get => GetArgument<TerraformSet<string>>("api_resources");
        set => SetArgument("api_resources", value);
    }

    /// <summary>
    /// Flag that specifies how API keys are approved to access the APIs defined by the API product.
    /// Valid values are &#39;auto&#39; or &#39;manual&#39;. Possible values: [&amp;quot;auto&amp;quot;, &amp;quot;manual&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ApprovalType
    {
        get => GetArgument<TerraformValue<string>>("approval_type");
        set => SetArgument("approval_type", value);
    }

    /// <summary>
    /// Description of the API product. Include key information about the API product that is not captured by other fields.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Name displayed in the UI or developer portal to developers registering for API access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Comma-separated list of environment names to which the API product is bound. Requests to environments that are not listed are rejected.
    /// By specifying one or more environments, you can bind the resources listed in the API product to a specific environment, preventing developers from accessing those resources through API proxies deployed in another environment.
    /// </summary>
    public TerraformSet<string>? Environments
    {
        get => GetArgument<TerraformSet<string>>("environments");
        set => SetArgument("environments", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Internal name of the API product.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API product,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Comma-separated list of API proxy names to which this API product is bound. By specifying API proxies, you can associate resources in the API product with specific API proxies, preventing developers from accessing those resources through other API proxies.
    /// Apigee rejects requests to API proxies that are not listed.
    /// </summary>
    public TerraformSet<string>? Proxies
    {
        get => GetArgument<TerraformSet<string>>("proxies");
        set => SetArgument("proxies", value);
    }

    /// <summary>
    /// Number of request messages permitted per app by this API product for the specified quotaInterval and quotaTimeUnit.
    /// For example, a quota of 50, for a quotaInterval of 12 and a quotaTimeUnit of hours means 50 requests are allowed every 12 hours.
    /// </summary>
    public TerraformValue<string>? Quota
    {
        get => GetArgument<TerraformValue<string>>("quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// Scope of the quota decides how the quota counter gets applied and evaluate for quota violation. If the Scope is set as PROXY, then all the operations defined for the APIproduct that are associated with the same proxy will share the same quota counter set at the APIproduct level, making it a global counter at a proxy level. If the Scope is set as OPERATION, then each operations get the counter set at the API product dedicated, making it a local counter. Note that, the QuotaCounterScope applies only when an operation does not have dedicated quota set for itself. Possible values: [&amp;quot;QUOTA_COUNTER_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;OPERATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? QuotaCounterScope
    {
        get => GetArgument<TerraformValue<string>>("quota_counter_scope");
        set => SetArgument("quota_counter_scope", value);
    }

    /// <summary>
    /// Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformValue<string>? QuotaInterval
    {
        get => GetArgument<TerraformValue<string>>("quota_interval");
        set => SetArgument("quota_interval", value);
    }

    /// <summary>
    /// Time unit defined for the quotaInterval. Valid values include second, minute, hour, day, month or year.
    /// </summary>
    public TerraformValue<string>? QuotaTimeUnit
    {
        get => GetArgument<TerraformValue<string>>("quota_time_unit");
        set => SetArgument("quota_time_unit", value);
    }

    /// <summary>
    /// Comma-separated list of OAuth scopes that are validated at runtime. Apigee validates that the scopes in any access token presented match the scopes defined in the OAuth policy associated with the API product.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// Optional. The resource ID of the parent Space. If not set, the parent resource will be the Organization.
    /// </summary>
    public TerraformValue<string>? Space
    {
        get => GetArgument<TerraformValue<string>>("space");
        set => SetArgument("space", value);
    }

    /// <summary>
    /// Response only. Creation time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// Response only. Modified time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedAt
        => CreateReference("last_modified_at");

    /// <summary>
    /// Attributes block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleApigeeApiProductAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformSet<GoogleApigeeApiProductAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// GraphqlOperationGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GraphqlOperationGroup block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductGraphqlOperationGroupBlock>? GraphqlOperationGroup
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductGraphqlOperationGroupBlock>>("graphql_operation_group");
        set => SetArgument("graphql_operation_group", value);
    }

    /// <summary>
    /// GrpcOperationGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcOperationGroup block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductGrpcOperationGroupBlock>? GrpcOperationGroup
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductGrpcOperationGroupBlock>>("grpc_operation_group");
        set => SetArgument("grpc_operation_group", value);
    }

    /// <summary>
    /// OperationGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationGroup block(s) allowed")]
    public TerraformList<GoogleApigeeApiProductOperationGroupBlock>? OperationGroup
    {
        get => GetArgument<TerraformList<GoogleApigeeApiProductOperationGroupBlock>>("operation_group");
        set => SetArgument("operation_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeApiProductTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeApiProductTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
