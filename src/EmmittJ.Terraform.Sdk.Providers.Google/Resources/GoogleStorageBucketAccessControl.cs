using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket_access_control resource.
/// </summary>
public class GoogleStorageBucketAccessControl : TerraformResource
{
    public GoogleStorageBucketAccessControl(string name) : base("google_storage_bucket_access_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("domain");
        this.DeclareOutput("email");
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    public TerraformProperty<string>? Entity
    {
        get => GetProperty<TerraformProperty<string>>("entity");
        set => this.WithProperty("entity", value);
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
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;, &amp;quot;WRITER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    public TerraformExpression Email => this["email"];

}
