using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for ingress_from in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock : TerraformBlock
{
    /// <summary>
    /// Identities can be an individual user, service account, Google group,
    /// or third-party identity. For third-party identity, only single identities
    /// are supported and other identity types are not supported.The v1 identities
    /// that have the prefix user, group and serviceAccount in
    /// https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.
    /// </summary>
    public List<TerraformProperty<string>>? Identities
    {
        get => GetProperty<List<TerraformProperty<string>>>("identities");
        set => WithProperty("identities", value);
    }

    /// <summary>
    /// Specifies the type of identities that are allowed access from outside the
    /// perimeter. If left unspecified, then members of &#39;identities&#39; field will be
    /// allowed access. Possible values: [&amp;quot;ANY_IDENTITY&amp;quot;, &amp;quot;ANY_USER_ACCOUNT&amp;quot;, &amp;quot;ANY_SERVICE_ACCOUNT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IdentityType
    {
        get => GetProperty<TerraformProperty<string>>("identity_type");
        set => WithProperty("identity_type", value);
    }

}

/// <summary>
/// Block type for ingress_to in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock : TerraformBlock
{
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
    public List<TerraformProperty<string>>? Resources
    {
        get => GetProperty<List<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

    /// <summary>
    /// A list of IAM roles that represent the set of operations that the sources
    /// specified in the corresponding &#39;IngressFrom&#39;
    /// are allowed to perform.
    /// </summary>
    public List<TerraformProperty<string>>? Roles
    {
        get => GetProperty<List<TerraformProperty<string>>>("roles");
        set => WithProperty("roles", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter_dry_run_ingress_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeterDryRunIngressPolicy(string name) : base("google_access_context_manager_service_perimeter_dry_run_ingress_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_id");
        this.DeclareOutput("etag");
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
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Perimeter is required")]
    public required TerraformProperty<string> Perimeter
    {
        get => GetProperty<TerraformProperty<string>>("perimeter");
        set => this.WithProperty("perimeter", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the perimeter. Does not affect behavior.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// Block for ingress_from.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressFrom block(s) allowed")]
    public List<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock>? IngressFrom
    {
        get => GetProperty<List<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressFromBlock>>("ingress_from");
        set => this.WithProperty("ingress_from", value);
    }

    /// <summary>
    /// Block for ingress_to.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngressTo block(s) allowed")]
    public List<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock>? IngressTo
    {
        get => GetProperty<List<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyIngressToBlock>>("ingress_to");
        set => this.WithProperty("ingress_to", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAccessContextManagerServicePerimeterDryRunIngressPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

    /// <summary>
    /// The perimeter etag is internally used to prevent overwriting the list of policies on PATCH calls. It is retrieved from the same GET perimeter API call that&#39;s used to get the current list of policies. The policy defined in this resource is added or removed from that list, and then this etag is sent with the PATCH call along with the updated policies.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
