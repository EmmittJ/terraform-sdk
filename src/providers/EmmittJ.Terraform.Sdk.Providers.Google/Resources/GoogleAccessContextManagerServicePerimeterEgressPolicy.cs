using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for egress_from in GoogleAccessContextManagerServicePerimeterEgressPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_from";

    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    public TerraformList<string>? Identities
    {
        get => GetArgument<TerraformList<string>>("identities");
        set => SetArgument("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access to outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will
    /// be allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IdentityType
    {
        get => GetArgument<TerraformValue<string>>("identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// Whether to enforce traffic restrictions based on &#39;sources&#39; field. If the &#39;sources&#39; field is non-empty, then this field must be set to &#39;SOURCE_RESTRICTION_ENABLED&#39;. Possible values: [&amp;quot;SOURCE_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;SOURCE_RESTRICTION_ENABLED&amp;quot;, &amp;quot;SOURCE_RESTRICTION_DISABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SourceRestriction
    {
        get => GetArgument<TerraformValue<string>>("source_restriction");
        set => SetArgument("source_restriction", value);
    }

    /// <summary>
    /// Sources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlockSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sources";

    /// <summary>
    /// An AccessLevel resource name that allows resources outside the ServicePerimeter to be accessed from the inside.
    /// </summary>
    public TerraformValue<string>? AccessLevel
    {
        get => GetArgument<TerraformValue<string>>("access_level");
        set => SetArgument("access_level", value);
    }

    /// <summary>
    /// A Google Cloud resource that is allowed to egress the perimeter.
    /// Requests from these resources are allowed to access data outside the perimeter.
    /// Currently only projects are allowed. Project format: &#39;projects/{project_number}&#39;.
    /// The resource may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. &#39;*&#39; is not allowed, the
    /// case of allowing all Google Cloud resources only is not supported.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

}


/// <summary>
/// Block type for egress_to in GoogleAccessContextManagerServicePerimeterEgressPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_to";

    /// <summary>
    /// A list of external resources that are allowed to be accessed. A request
    /// matches if it contains an external resource in this list (Example:
    /// s3://bucket/path). Currently &#39;*&#39; is not allowed.
    /// </summary>
    public TerraformList<string>? ExternalResources
    {
        get => GetArgument<TerraformList<string>>("external_resources");
        set => SetArgument("external_resources", value);
    }

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, that match this to stanza. A request matches
    /// if it contains a resource in this list. If * is specified for resources,
    /// then this &#39;EgressTo&#39; rule will authorize access to all resources outside
    /// the perimeter.
    /// </summary>
    public TerraformList<string>? Resources
    {
        get => GetArgument<TerraformList<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;EgressFrom&#39;
    /// are allowed to perform.
    /// </summary>
    public TerraformList<string>? Roles
    {
        get => GetArgument<TerraformList<string>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// Operations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operations";

    /// <summary>
    /// The name of the API whose methods or permissions the &#39;IngressPolicy&#39; or
    /// &#39;EgressPolicy&#39; want to allow. A single &#39;ApiOperation&#39; with serviceName
    /// field set to &#39;*&#39; will allow all methods AND permissions for all services.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// MethodSelectors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "method_selectors";

    /// <summary>
    /// Value for &#39;method&#39; should be a valid method name for the corresponding
    /// &#39;serviceName&#39; in &#39;ApiOperation&#39;. If &#39;*&#39; used as value for method,
    /// then ALL methods and permissions are allowed.
    /// </summary>
    public TerraformValue<string>? Method
    {
        get => GetArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// Value for permission should be a valid Cloud IAM permission for the
    /// corresponding &#39;serviceName&#39; in &#39;ApiOperation&#39;.
    /// </summary>
    public TerraformValue<string>? Permission
    {
        get => GetArgument<TerraformValue<string>>("permission");
        set => SetArgument("permission", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerServicePerimeterEgressPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterEgressPolicyTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_access_context_manager_service_perimeter_egress_policy Terraform resource.
/// Manages a google_access_context_manager_service_perimeter_egress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterEgressPolicy(string name) : TerraformResource("google_access_context_manager_service_perimeter_egress_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Perimeter is required")]
    public required TerraformValue<string> Perimeter
    {
        get => GetRequiredArgument<TerraformValue<string>>("perimeter");
        set => SetArgument("perimeter", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformValue<string> AccessPolicyId
        => AsReference("access_policy_id");

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// EgressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock>? EgressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressFromBlock>>("egress_from");
        set => SetArgument("egress_from", value);
    }

    /// <summary>
    /// EgressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock>? EgressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterEgressPolicyEgressToBlock>>("egress_to");
        set => SetArgument("egress_to", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterEgressPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerServicePerimeterEgressPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
