using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingress_from in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_from";

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
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will be
    /// allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IdentityType
    {
        get => GetArgument<TerraformValue<string>>("identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// Sources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlockSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sources";

    /// <summary>
    /// An &#39;AccessLevel&#39; resource name that allow resources within the
    /// &#39;ServicePerimeters&#39; to be accessed from the internet. &#39;AccessLevels&#39; listed
    /// must be in the same policy as this &#39;ServicePerimeter&#39;. Referencing a nonexistent
    /// &#39;AccessLevel&#39; will cause an error. If no &#39;AccessLevel&#39; names are listed,
    /// resources within the perimeter can only be accessed via Google Cloud calls
    /// with request origins within the perimeter.
    /// Example &#39;accessPolicies/MY_POLICY/accessLevels/MY_LEVEL.&#39;
    /// If * is specified, then all IngressSources will be allowed.
    /// </summary>
    public TerraformValue<string>? AccessLevel
    {
        get => GetArgument<TerraformValue<string>>("access_level");
        set => SetArgument("access_level", value);
    }

    /// <summary>
    /// A Google Cloud resource that is allowed to ingress the perimeter.
    /// Requests from these resources will be allowed to access perimeter data.
    /// Currently only projects are allowed. Format &#39;projects/{project_number}&#39;
    /// The project may be in any Google Cloud organization, not just the
    /// organization that the perimeter is defined in. &#39;*&#39; is not allowed, the case
    /// of allowing all Google Cloud resources only is not supported.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

}


/// <summary>
/// Block type for ingress_to in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_to";

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, protected by this &#39;ServicePerimeter&#39;
    /// that are allowed to be accessed by sources defined in the
    /// corresponding &#39;IngressFrom&#39;. A request matches if it contains
    /// a resource in this list. If &#39;*&#39; is specified for resources,
    /// then this &#39;IngressTo&#39; rule will authorize access to all
    /// resources inside the perimeter, provided that the request
    /// also matches the &#39;operations&#39; field.
    /// </summary>
    public TerraformList<string>? Resources
    {
        get => GetArgument<TerraformList<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;IngressFrom&#39;
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operations";

    /// <summary>
    /// The name of the API whose methods or permissions the &#39;IngressPolicy&#39; or
    /// &#39;EgressPolicy&#39; want to allow. A single &#39;ApiOperation&#39; with &#39;serviceName&#39;
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "method_selectors";

    /// <summary>
    /// Value for method should be a valid method name for the corresponding
    /// serviceName in &#39;ApiOperation&#39;. If &#39;*&#39; used as value for &#39;method&#39;, then
    /// ALL methods and permissions are allowed.
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
/// Block type for timeouts in GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_access_context_manager_service_perimeter_dry_run_ingress_policy Terraform resource.
/// Manages a google_access_context_manager_service_perimeter_dry_run_ingress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy(string name) : TerraformResource("google_access_context_manager_service_perimeter_dry_run_ingress_policy", name)
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
    /// IngressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock>? IngressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock>>("ingress_from");
        set => SetArgument("ingress_from", value);
    }

    /// <summary>
    /// IngressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock>? IngressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock>>("ingress_to");
        set => SetArgument("ingress_to", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
