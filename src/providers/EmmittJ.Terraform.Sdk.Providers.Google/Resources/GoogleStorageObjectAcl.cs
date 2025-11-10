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
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("object");
        SetOutput("predefined_acl");
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
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    public required TerraformProperty<string> Object
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object");
        set => SetProperty("object", value);
    }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    public TerraformProperty<string> PredefinedAcl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("predefined_acl");
        set => SetProperty("predefined_acl", value);
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
