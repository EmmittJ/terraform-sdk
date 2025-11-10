using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlock : TerraformBlock
{
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
    public HashSet<TerraformProperty<string>>? AccessLevels
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("access_levels");
        set => WithProperty("access_levels", value);
    }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RestrictedServices
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("restricted_services");
        set => WithProperty("restricted_services", value);
    }

}

/// <summary>
/// Block type for status in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlock : TerraformBlock
{
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
    public HashSet<TerraformProperty<string>>? AccessLevels
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("access_levels");
        set => WithProperty("access_levels", value);
    }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RestrictedServices
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("restricted_services");
        set => WithProperty("restricted_services", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterTimeoutsBlock : TerraformBlock
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
/// Manages a google_access_context_manager_service_perimeter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerServicePerimeter : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeter(string name) : base("google_access_context_manager_service_perimeter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
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
    public TerraformProperty<string>? PerimeterType
    {
        get => GetProperty<TerraformProperty<string>>("perimeter_type");
        set => this.WithProperty("perimeter_type", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
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
    public TerraformProperty<bool>? UseExplicitDryRunSpec
    {
        get => GetProperty<TerraformProperty<bool>>("use_explicit_dry_run_spec");
        set => this.WithProperty("use_explicit_dry_run_spec", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<GoogleAccessContextManagerServicePerimeterSpecBlock>? Spec
    {
        get => GetProperty<List<GoogleAccessContextManagerServicePerimeterSpecBlock>>("spec");
        set => this.WithProperty("spec", value);
    }

    /// <summary>
    /// Block for status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    public List<GoogleAccessContextManagerServicePerimeterStatusBlock>? Status
    {
        get => GetProperty<List<GoogleAccessContextManagerServicePerimeterStatusBlock>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerServicePerimeterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAccessContextManagerServicePerimeterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the AccessPolicy was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the AccessPolicy was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
