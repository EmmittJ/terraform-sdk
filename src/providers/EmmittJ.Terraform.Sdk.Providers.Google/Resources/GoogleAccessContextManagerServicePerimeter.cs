using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for spec in GoogleAccessContextManagerServicePerimeter.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// 
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    public TerraformSet<string>? AccessLevels
    {
        get => GetArgument<TerraformSet<string>>("access_levels");
        set => SetArgument("access_levels", value);
    }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    public TerraformSet<string>? RestrictedServices
    {
        get => GetArgument<TerraformSet<string>>("restricted_services");
        set => SetArgument("restricted_services", value);
    }

    /// <summary>
    /// EgressPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlock>? EgressPolicies
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlock>>("egress_policies");
        set => SetArgument("egress_policies", value);
    }

    /// <summary>
    /// IngressPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlock>? IngressPolicies
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlock>>("ingress_policies");
        set => SetArgument("ingress_policies", value);
    }

    /// <summary>
    /// VpcAccessibleServices block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessibleServices block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockVpcAccessibleServicesBlock>? VpcAccessibleServices
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockVpcAccessibleServicesBlock>>("vpc_accessible_services");
        set => SetArgument("vpc_accessible_services", value);
    }

}

/// <summary>
/// Block type for egress_policies in GoogleAccessContextManagerServicePerimeterSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_policies";

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// EgressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlock>? EgressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlock>>("egress_from");
        set => SetArgument("egress_from", value);
    }

    /// <summary>
    /// EgressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlock>? EgressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlock>>("egress_to");
        set => SetArgument("egress_to", value);
    }

}

/// <summary>
/// Block type for egress_from in GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_from";

    /// <summary>
    /// A list of identities that are allowed access through this &#39;EgressPolicy&#39;.
    /// Should be in the format of email address. The email address should
    /// represent individual user or service account only.
    /// </summary>
    public TerraformSet<string>? Identities
    {
        get => GetArgument<TerraformSet<string>>("identities");
        set => SetArgument("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access to outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will
    /// be allowed access. Possible values: [&amp;quot;IDENTITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressFromBlockSourcesBlock : TerraformBlock
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
/// Block type for egress_to in GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlock : TerraformBlock
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
    public TerraformSet<string>? ExternalResources
    {
        get => GetArgument<TerraformSet<string>>("external_resources");
        set => SetArgument("external_resources", value);
    }

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, that match this to stanza. A request matches
    /// if it contains a resource in this list. If * is specified for resources,
    /// then this &#39;EgressTo&#39; rule will authorize access to all resources outside
    /// the perimeter.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlock : TerraformBlock
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
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
/// Block type for ingress_policies in GoogleAccessContextManagerServicePerimeterSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_policies";

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// IngressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlock>? IngressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlock>>("ingress_from");
        set => SetArgument("ingress_from", value);
    }

    /// <summary>
    /// IngressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlock>? IngressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlock>>("ingress_to");
        set => SetArgument("ingress_to", value);
    }

}

/// <summary>
/// Block type for ingress_from in GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_from";

    /// <summary>
    /// A list of identities that are allowed access through this ingress policy.
    /// Should be in the format of email address. The email address should represent
    /// individual user or service account only.
    /// </summary>
    public TerraformSet<string>? Identities
    {
        get => GetArgument<TerraformSet<string>>("identities");
        set => SetArgument("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will be
    /// allowed access. Possible values: [&amp;quot;IDENTITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IdentityType
    {
        get => GetArgument<TerraformValue<string>>("identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// Sources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressFromBlockSourcesBlock : TerraformBlock
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
/// Block type for ingress_to in GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlock : TerraformBlock
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
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlock : TerraformBlock
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
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
/// Block type for vpc_accessible_services in GoogleAccessContextManagerServicePerimeterSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlockVpcAccessibleServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_accessible_services";

    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless &#39;enableRestriction&#39; is True.
    /// </summary>
    public TerraformSet<string>? AllowedServices
    {
        get => GetArgument<TerraformSet<string>>("allowed_services");
        set => SetArgument("allowed_services", value);
    }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &#39;allowedServices&#39;.
    /// </summary>
    public TerraformValue<bool>? EnableRestriction
    {
        get => GetArgument<TerraformValue<bool>>("enable_restriction");
        set => SetArgument("enable_restriction", value);
    }

}


/// <summary>
/// Block type for status in GoogleAccessContextManagerServicePerimeter.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "status";

    /// <summary>
    /// A list of AccessLevel resource names that allow resources within
    /// the ServicePerimeter to be accessed from the internet.
    /// AccessLevels listed must be in the same policy as this
    /// ServicePerimeter. Referencing a nonexistent AccessLevel is a
    /// syntax error. If no AccessLevel names are listed, resources within
    /// the perimeter can only be accessed via GCP calls with request
    /// origins within the perimeter. For Service Perimeter Bridge, must
    /// be empty.
    /// 
    /// Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}
    /// </summary>
    public TerraformSet<string>? AccessLevels
    {
        get => GetArgument<TerraformSet<string>>("access_levels");
        set => SetArgument("access_levels", value);
    }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    public TerraformSet<string>? RestrictedServices
    {
        get => GetArgument<TerraformSet<string>>("restricted_services");
        set => SetArgument("restricted_services", value);
    }

    /// <summary>
    /// EgressPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlock>? EgressPolicies
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlock>>("egress_policies");
        set => SetArgument("egress_policies", value);
    }

    /// <summary>
    /// IngressPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlock>? IngressPolicies
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlock>>("ingress_policies");
        set => SetArgument("ingress_policies", value);
    }

    /// <summary>
    /// VpcAccessibleServices block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessibleServices block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockVpcAccessibleServicesBlock>? VpcAccessibleServices
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockVpcAccessibleServicesBlock>>("vpc_accessible_services");
        set => SetArgument("vpc_accessible_services", value);
    }

}

/// <summary>
/// Block type for egress_policies in GoogleAccessContextManagerServicePerimeterStatusBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "egress_policies";

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// EgressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlock>? EgressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlock>>("egress_from");
        set => SetArgument("egress_from", value);
    }

    /// <summary>
    /// EgressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EgressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlock>? EgressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlock>>("egress_to");
        set => SetArgument("egress_to", value);
    }

}

/// <summary>
/// Block type for egress_from in GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlock : TerraformBlock
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
    public TerraformSet<string>? Identities
    {
        get => GetArgument<TerraformSet<string>>("identities");
        set => SetArgument("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access to outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will
    /// be allowed access. Possible values: [&amp;quot;IDENTITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressFromBlockSourcesBlock : TerraformBlock
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
/// Block type for egress_to in GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlock : TerraformBlock
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
    public TerraformSet<string>? ExternalResources
    {
        get => GetArgument<TerraformSet<string>>("external_resources");
        set => SetArgument("external_resources", value);
    }

    /// <summary>
    /// A list of resources, currently only projects in the form
    /// &#39;projects/&amp;lt;projectnumber&amp;gt;&#39;, that match this to stanza. A request matches
    /// if it contains a resource in this list. If * is specified for resources,
    /// then this &#39;EgressTo&#39; rule will authorize access to all resources outside
    /// the perimeter.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlock : TerraformBlock
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockEgressPoliciesBlockEgressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
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
/// Block type for ingress_policies in GoogleAccessContextManagerServicePerimeterStatusBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingress_policies";

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// IngressFrom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressFrom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlock>? IngressFrom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlock>>("ingress_from");
        set => SetArgument("ingress_from", value);
    }

    /// <summary>
    /// IngressTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressTo block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlock>? IngressTo
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlock>>("ingress_to");
        set => SetArgument("ingress_to", value);
    }

}

/// <summary>
/// Block type for ingress_from in GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlock : TerraformBlock
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
    public TerraformSet<string>? Identities
    {
        get => GetArgument<TerraformSet<string>>("identities");
        set => SetArgument("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will be
    /// allowed access. Possible values: [&amp;quot;IDENTITY_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IdentityType
    {
        get => GetArgument<TerraformValue<string>>("identity_type");
        set => SetArgument("identity_type", value);
    }

    /// <summary>
    /// Sources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for sources in GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressFromBlockSourcesBlock : TerraformBlock
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
    /// Currently only projects and VPCs are allowed.
    /// Project format: &#39;projects/{projectNumber}&#39;
    /// VPC network format:
    /// &#39;//compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}&#39;.
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
/// Block type for ingress_to in GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlock : TerraformBlock
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
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for operations in GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlock : TerraformBlock
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
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock>? MethodSelectors
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock>>("method_selectors");
        set => SetArgument("method_selectors", value);
    }

}

/// <summary>
/// Block type for method_selectors in GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockIngressPoliciesBlockIngressToBlockOperationsBlockMethodSelectorsBlock : TerraformBlock
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
/// Block type for vpc_accessible_services in GoogleAccessContextManagerServicePerimeterStatusBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlockVpcAccessibleServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_accessible_services";

    /// <summary>
    /// The list of APIs usable within the Service Perimeter.
    /// Must be empty unless &#39;enableRestriction&#39; is True.
    /// </summary>
    public TerraformSet<string>? AllowedServices
    {
        get => GetArgument<TerraformSet<string>>("allowed_services");
        set => SetArgument("allowed_services", value);
    }

    /// <summary>
    /// Whether to restrict API calls within the Service Perimeter to the
    /// list of APIs specified in &#39;allowedServices&#39;.
    /// </summary>
    public TerraformValue<bool>? EnableRestriction
    {
        get => GetArgument<TerraformValue<bool>>("enable_restriction");
        set => SetArgument("enable_restriction", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerServicePerimeter.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterTimeoutsBlock : TerraformBlock
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
/// Represents a google_access_context_manager_service_perimeter Terraform resource.
/// Manages a google_access_context_manager_service_perimeter resource.
/// </summary>
public partial class GoogleAccessContextManagerServicePerimeter(string name) : TerraformResource("google_access_context_manager_service_perimeter", name)
{
    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Specifies the type of the Perimeter. There are two types: regular and
    /// bridge. Regular Service Perimeter contains resources, access levels,
    /// and restricted services. Every resource can be in at most
    /// ONE regular Service Perimeter.
    /// 
    /// In addition to being in a regular service perimeter, a resource can also
    /// be in zero or more perimeter bridges. A perimeter bridge only contains
    /// resources. Cross project operations are permitted if all effected
    /// resources share some perimeter (whether bridge or regular). Perimeter
    /// Bridge does not contain access levels or services: those are governed
    /// entirely by the regular perimeter that resource is in.
    /// 
    /// Perimeter Bridges are typically useful when building more complex
    /// topologies with many independent perimeters that need to share some data
    /// with a common perimeter, but should not be able to share data among
    /// themselves. Default value: &amp;quot;PERIMETER_TYPE_REGULAR&amp;quot; Possible values: [&amp;quot;PERIMETER_TYPE_REGULAR&amp;quot;, &amp;quot;PERIMETER_TYPE_BRIDGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PerimeterType
    {
        get => GetArgument<TerraformValue<string>>("perimeter_type");
        set => SetArgument("perimeter_type", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists
    /// for all Service Perimeters, and that spec is identical to the status for those
    /// Service Perimeters. When this flag is set, it inhibits the generation of the
    /// implicit spec, thereby allowing the user to explicitly provide a
    /// configuration (&amp;quot;spec&amp;quot;) to use in a dry-run version of the Service Perimeter.
    /// This allows the user to test changes to the enforced config (&amp;quot;status&amp;quot;) without
    /// actually enforcing them. This testing is done through analyzing the differences
    /// between currently enforced and suggested restrictions. useExplicitDryRunSpec must
    /// bet set to True if any of the fields in the spec are set to non-default values.
    /// </summary>
    public TerraformValue<bool>? UseExplicitDryRunSpec
    {
        get => GetArgument<TerraformValue<bool>>("use_explicit_dry_run_spec");
        set => SetArgument("use_explicit_dry_run_spec", value);
    }

    /// <summary>
    /// Time the AccessPolicy was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Time the AccessPolicy was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Spec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlock>? Spec
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// Status block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlock>? Status
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerServicePerimeterStatusBlock>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerServicePerimeterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
