using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterSpecBlock
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
    [TerraformPropertyName("access_levels")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AccessLevels { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [TerraformPropertyName("resources")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    [TerraformPropertyName("restricted_services")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RestrictedServices { get; set; }

}

/// <summary>
/// Block type for status in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerServicePerimeterStatusBlock
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
    [TerraformPropertyName("access_levels")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AccessLevels { get; set; }

    /// <summary>
    /// A list of GCP resources that are inside of the service perimeter.
    /// Currently only projects are allowed.
    /// Format: projects/{project_number}
    /// </summary>
    [TerraformPropertyName("resources")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// GCP services that are subject to the Service Perimeter
    /// restrictions. Must contain a list of services. For example, if
    /// &#39;storage.googleapis.com&#39; is specified, access to the storage
    /// buckets inside the perimeter must meet the perimeter&#39;s access
    /// restrictions.
    /// </summary>
    [TerraformPropertyName("restricted_services")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RestrictedServices { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerServicePerimeterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_access_context_manager_service_perimeter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerServicePerimeter : TerraformResource
{
    public GoogleAccessContextManagerServicePerimeter(string name) : base("google_access_context_manager_service_perimeter", name)
    {
    }

    /// <summary>
    /// Description of the ServicePerimeter and its use. Does not affect
    /// behavior.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource name for the ServicePerimeter. The short_name component must
    /// begin with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The AccessPolicy this ServicePerimeter lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

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
    [TerraformPropertyName("perimeter_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PerimeterType { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformPropertyName("title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Title { get; set; }

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
    [TerraformPropertyName("use_explicit_dry_run_spec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseExplicitDryRunSpec { get; set; }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformPropertyName("spec")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterSpecBlock>>? Spec { get; set; }

    /// <summary>
    /// Block for status.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Status block(s) allowed")]
    [TerraformPropertyName("status")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerServicePerimeterStatusBlock>>? Status { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerServicePerimeterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the AccessPolicy was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Time the AccessPolicy was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
