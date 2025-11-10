using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageObjectAccessControlTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_object_access_control resource.
/// </summary>
public class GoogleStorageObjectAccessControl : TerraformResource
{
    public GoogleStorageObjectAccessControl(string name) : base("google_storage_object_access_control", name)
    {
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The entity holding the permission, in one of the following forms:
    ///   * user-{{userId}}
    ///   * user-{{email}} (such as &amp;quot;user-liz@example.com&amp;quot;)
    ///   * group-{{groupId}}
    ///   * group-{{email}} (such as &amp;quot;group-example@googlegroups.com&amp;quot;)
    ///   * domain-{{domain}} (such as &amp;quot;domain-example.com&amp;quot;)
    ///   * project-team-{{projectId}}
    ///   * allUsers
    ///   * allAuthenticatedUsers
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entity is required")]
    [TerraformPropertyName("entity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Entity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the object to apply the access control to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    [TerraformPropertyName("object")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Object { get; set; }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Role { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageObjectAccessControlTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The ID for the entity
    /// </summary>
    [TerraformPropertyName("entity_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EntityId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "entity_id");

    /// <summary>
    /// The content generation of the object, if applied to an object.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Generation => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "generation");

    /// <summary>
    /// The project team associated with the entity
    /// </summary>
    [TerraformPropertyName("project_team")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProjectTeam => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "project_team");

}
