using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_object_acl resource.
/// </summary>
public class GoogleStorageObjectAcl : TerraformResource
{
    public GoogleStorageObjectAcl(string name) : base("google_storage_object_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
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
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    public required TerraformProperty<string> Object
    {
        get => GetRequiredProperty<TerraformProperty<string>>("object");
        set => this.WithProperty("object", value);
    }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    public TerraformProperty<string>? PredefinedAcl
    {
        get => GetProperty<TerraformProperty<string>>("predefined_acl");
        set => this.WithProperty("predefined_acl", value);
    }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RoleEntity
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("role_entity");
        set => this.WithProperty("role_entity", value);
    }

}
