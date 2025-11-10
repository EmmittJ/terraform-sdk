using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketAccessControlTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_bucket_access_control resource.
/// </summary>
public class GoogleStorageBucketAccessControl : TerraformResource
{
    public GoogleStorageBucketAccessControl(string name) : base("google_storage_bucket_access_control", name)
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
    ///   user-userId
    ///   user-email
    ///   group-groupId
    ///   group-email
    ///   domain-domain
    ///   project-team-projectId
    ///   allUsers
    ///   allAuthenticatedUsers
    /// Examples:
    ///   The user liz@example.com would be user-liz@example.com.
    ///   The group example@googlegroups.com would be
    ///   group-example@googlegroups.com.
    ///   To refer to all members of the Google Apps for Business domain
    ///   example.com, the entity would be domain-example.com.
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
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;, &amp;quot;WRITER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Role { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBucketAccessControlTimeoutsBlock>? Timeouts { get; set; } = new();

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

}
