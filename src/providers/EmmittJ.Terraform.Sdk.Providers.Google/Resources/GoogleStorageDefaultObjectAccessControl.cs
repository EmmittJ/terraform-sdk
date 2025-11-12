using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageDefaultObjectAccessControlTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_default_object_access_control resource.
/// </summary>
public partial class GoogleStorageDefaultObjectAccessControl : TerraformResource
{
    public GoogleStorageDefaultObjectAccessControl(string name) : base("google_storage_default_object_access_control", name)
    {
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

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
    [TerraformProperty("entity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Entity { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the object, if applied to an object.
    /// </summary>
    [TerraformProperty("object")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Object { get; set; }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleStorageDefaultObjectAccessControlTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Domain { get; }

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Email { get; }

    /// <summary>
    /// The ID for the entity
    /// </summary>
    [TerraformProperty("entity_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EntityId { get; }

    /// <summary>
    /// The content generation of the object, if applied to an object.
    /// </summary>
    [TerraformProperty("generation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Generation { get; }

    /// <summary>
    /// The project team associated with the entity
    /// </summary>
    [TerraformProperty("project_team")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ProjectTeam { get; }

}
