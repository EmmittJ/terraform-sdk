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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The object attribute.
    /// </summary>
    public string? Object
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object")?.Value;
        set => this.WithProperty("object", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    public string? PredefinedAcl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("predefined_acl")?.Value;
        set => this.WithProperty("predefined_acl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    public HashSet<string>? RoleEntity
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("role_entity")?.Value;
        set => this.WithProperty("role_entity", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
