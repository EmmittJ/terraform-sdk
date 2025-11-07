using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket_acl resource.
/// </summary>
public class GoogleStorageBucketAcl : TerraformResource
{
    public GoogleStorageBucketAcl(string name) : base("google_storage_bucket_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The name of the bucket it applies to.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_acl");
        set => this.WithProperty("default_acl", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    public TerraformLiteralProperty<string>? PredefinedAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("predefined_acl");
        set => this.WithProperty("predefined_acl", value);
    }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RoleEntity
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("role_entity");
        set => this.WithProperty("role_entity", value);
    }

}
