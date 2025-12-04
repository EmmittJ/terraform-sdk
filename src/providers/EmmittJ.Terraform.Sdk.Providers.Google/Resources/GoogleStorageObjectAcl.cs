using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_object_acl Terraform resource.
/// Manages a google_storage_object_acl resource.
/// </summary>
public partial class GoogleStorageObjectAcl(string name) : TerraformResource("google_storage_object_acl", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    public TerraformValue<string>? PredefinedAcl
    {
        get => GetArgument<TerraformValue<string>>("predefined_acl");
        set => SetArgument("predefined_acl", value);
    }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    public TerraformSet<string> RoleEntity
    {
        get => GetArgument<TerraformSet<string>>("role_entity") ?? AsReference("role_entity");
        set => SetArgument("role_entity", value);
    }

}
