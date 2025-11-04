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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Entity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entity")?.Value;
        set => this.WithProperty("entity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;, &amp;quot;WRITER&amp;quot;]
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
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
