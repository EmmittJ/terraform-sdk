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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    public TerraformProperty<string>? DefaultAcl
    {
        get => GetProperty<TerraformProperty<string>>("default_acl");
        set => this.WithProperty("default_acl", value);
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
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    public TerraformProperty<string>? PredefinedAcl
    {
        get => GetProperty<TerraformProperty<string>>("predefined_acl");
        set => this.WithProperty("predefined_acl", value);
    }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    public List<TerraformProperty<string>>? RoleEntity
    {
        get => GetProperty<List<TerraformProperty<string>>>("role_entity");
        set => this.WithProperty("role_entity", value);
    }

}
