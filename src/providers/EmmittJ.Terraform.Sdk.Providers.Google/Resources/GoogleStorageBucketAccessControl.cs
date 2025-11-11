using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageBucketAccessControlTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_storage_bucket_access_control resource.
/// </summary>
public partial class GoogleStorageBucketAccessControl : TerraformResource
{
    public GoogleStorageBucketAccessControl(string name) : base("google_storage_bucket_access_control", name)
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
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;, &amp;quot;WRITER&amp;quot;]
    /// </summary>
    [TerraformProperty("role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleStorageBucketAccessControlTimeoutsBlock>? Timeouts { get; set; }

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

}
