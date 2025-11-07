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
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    /// The object attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Object
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object");
        set => this.WithProperty("object", value);
    }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PredefinedAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("predefined_acl");
        set => this.WithProperty("predefined_acl", value);
    }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? RoleEntity
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("role_entity");
        set => this.WithProperty("role_entity", value);
    }

}
