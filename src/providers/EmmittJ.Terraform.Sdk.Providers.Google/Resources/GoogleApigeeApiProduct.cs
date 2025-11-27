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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "operation_config_type");
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
        get => new TerraformReference<string>(this, "api_source");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// Required. GraphQL operation types. Valid values include query or mutation.
    /// Note: Apigee does not currently support subscription types.
    /// </summary>
    public TerraformSet<string>? OperationTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "operation_types").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => new TerraformReference<string>(this, "limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
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
        get => new TerraformReference<string>(this, "api_source");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "methods").ResolveNodes(ctx));
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// Required. gRPC Service name associated to be associated with the API proxy, on which quota rules can be applied upon.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => new TerraformReference<string>(this, "service");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => new TerraformReference<string>(this, "limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
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
        get => new TerraformReference<string>(this, "operation_config_type");
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
        get => new TerraformReference<string>(this, "api_source");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "methods").ResolveNodes(ctx));
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// Required. REST resource path associated with the API proxy or remote service.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => new TerraformReference<string>(this, "resource");
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
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Required. Upper limit allowed for the time interval and time unit specified. Requests exceeding this limit will be rejected.
    /// </summary>
    public TerraformValue<string>? Limit
    {
        get => new TerraformReference<string>(this, "limit");
        set => SetArgument("limit", value);
    }

    /// <summary>
    /// Time unit defined for the interval. Valid values include second, minute, hour, day, month or year. If limit and interval are valid, the default value is hour; otherwise, the default is null.
    /// </summary>
    public TerraformValue<string>? TimeUnit
    {
        get => new TerraformReference<string>(this, "time_unit");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "api_resources").ResolveNodes(ctx));
        set => SetArgument("api_resources", value);
    }

    /// <summary>
    /// Flag that specifies how API keys are approved to access the APIs defined by the API product.
    /// Valid values are &#39;auto&#39; or &#39;manual&#39;. Possible values: [&amp;quot;auto&amp;quot;, &amp;quot;manual&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ApprovalType
    {
        get => new TerraformReference<string>(this, "approval_type");
        set => SetArgument("approval_type", value);
    }

    /// <summary>
    /// Description of the API product. Include key information about the API product that is not captured by other fields.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Name displayed in the UI or developer portal to developers registering for API access.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Comma-separated list of environment names to which the API product is bound. Requests to environments that are not listed are rejected.
    /// By specifying one or more environments, you can bind the resources listed in the API product to a specific environment, preventing developers from accessing those resources through API proxies deployed in another environment.
    /// </summary>
    public TerraformSet<string>? Environments
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "environments").ResolveNodes(ctx));
        set => SetArgument("environments", value);
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
    /// Internal name of the API product.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API product,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Comma-separated list of API proxy names to which this API product is bound. By specifying API proxies, you can associate resources in the API product with specific API proxies, preventing developers from accessing those resources through other API proxies.
    /// Apigee rejects requests to API proxies that are not listed.
    /// </summary>
    public TerraformSet<string>? Proxies
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "proxies").ResolveNodes(ctx));
        set => SetArgument("proxies", value);
    }

    /// <summary>
    /// Number of request messages permitted per app by this API product for the specified quotaInterval and quotaTimeUnit.
    /// For example, a quota of 50, for a quotaInterval of 12 and a quotaTimeUnit of hours means 50 requests are allowed every 12 hours.
    /// </summary>
    public TerraformValue<string>? Quota
    {
        get => new TerraformReference<string>(this, "quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// Scope of the quota decides how the quota counter gets applied and evaluate for quota violation. If the Scope is set as PROXY, then all the operations defined for the APIproduct that are associated with the same proxy will share the same quota counter set at the APIproduct level, making it a global counter at a proxy level. If the Scope is set as OPERATION, then each operations get the counter set at the API product dedicated, making it a local counter. Note that, the QuotaCounterScope applies only when an operation does not have dedicated quota set for itself. Possible values: [&amp;quot;QUOTA_COUNTER_SCOPE_UNSPECIFIED&amp;quot;, &amp;quot;PROXY&amp;quot;, &amp;quot;OPERATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? QuotaCounterScope
    {
        get => new TerraformReference<string>(this, "quota_counter_scope");
        set => SetArgument("quota_counter_scope", value);
    }

    /// <summary>
    /// Time interval over which the number of request messages is calculated.
    /// </summary>
    public TerraformValue<string>? QuotaInterval
    {
        get => new TerraformReference<string>(this, "quota_interval");
        set => SetArgument("quota_interval", value);
    }

    /// <summary>
    /// Time unit defined for the quotaInterval. Valid values include second, minute, hour, day, month or year.
    /// </summary>
    public TerraformValue<string>? QuotaTimeUnit
    {
        get => new TerraformReference<string>(this, "quota_time_unit");
        set => SetArgument("quota_time_unit", value);
    }

    /// <summary>
    /// Comma-separated list of OAuth scopes that are validated at runtime. Apigee validates that the scopes in any access token presented match the scopes defined in the OAuth policy associated with the API product.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// Optional. The resource ID of the parent Space. If not set, the parent resource will be the Organization.
    /// </summary>
    public TerraformValue<string>? Space
    {
        get => new TerraformReference<string>(this, "space");
        set => SetArgument("space", value);
    }

    /// <summary>
    /// Response only. Creation time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Response only. Modified time of this environment as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedAt
    {
        get => new TerraformReference<string>(this, "last_modified_at");
    }

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
