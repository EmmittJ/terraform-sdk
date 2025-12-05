using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleStorageBucketAccessControl.
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketAccessControlTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_bucket_access_control Terraform resource.
/// Manages a google_storage_bucket_access_control resource.
/// </summary>
public partial class GoogleStorageBucketAccessControl(string name) : TerraformResource("google_storage_bucket_access_control", name)
{
    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

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
    public required TerraformValue<string> Entity
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity");
        set => SetArgument("entity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;, &amp;quot;WRITER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    public TerraformValue<string> Domain
        => CreateReference("domain");

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageBucketAccessControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageBucketAccessControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
