using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_default_object_acl resource.
/// </summary>
public class GoogleStorageDefaultObjectAcl : TerraformResource
{
    public GoogleStorageDefaultObjectAcl(string name) : base("google_storage_default_object_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    /// The role_entity attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RoleEntity
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("role_entity");
        set => this.WithProperty("role_entity", value);
    }

}
