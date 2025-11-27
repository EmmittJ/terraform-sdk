using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_default_object_acl Terraform resource.
/// Manages a google_storage_default_object_acl resource.
/// </summary>
public partial class GoogleStorageDefaultObjectAcl(string name) : TerraformResource("google_storage_default_object_acl", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    public TerraformSet<string> RoleEntity
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "role_entity").ResolveNodes(ctx));
        set => SetArgument("role_entity", value);
    }

}
