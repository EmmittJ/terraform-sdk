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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    public string? DefaultAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_acl")?.Value;
        set => this.WithProperty("default_acl", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    public string? PredefinedAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("predefined_acl")?.Value;
        set => this.WithProperty("predefined_acl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    public List<string>? RoleEntity
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("role_entity")?.Value;
        set => this.WithProperty("role_entity", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
