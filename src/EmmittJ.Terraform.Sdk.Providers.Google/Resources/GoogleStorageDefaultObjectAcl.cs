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
    /// The role_entity attribute.
    /// </summary>
    public HashSet<string>? RoleEntity
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("role_entity")?.Value;
        set => this.WithProperty("role_entity", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
