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
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("role_entity");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
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
    /// The role_entity attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RoleEntity
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("role_entity");
        set => SetProperty("role_entity", value);
    }

}
