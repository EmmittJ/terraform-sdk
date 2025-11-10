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
        SetOutput("bucket");
        SetOutput("default_acl");
        SetOutput("id");
        SetOutput("predefined_acl");
        SetOutput("role_entity");
    }

    /// <summary>
    /// The name of the bucket it applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    public TerraformProperty<string> DefaultAcl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_acl");
        set => SetProperty("default_acl", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    public TerraformProperty<string> PredefinedAcl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("predefined_acl");
        set => SetProperty("predefined_acl", value);
    }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    public List<TerraformProperty<string>> RoleEntity
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("role_entity");
        set => SetProperty("role_entity", value);
    }

}
