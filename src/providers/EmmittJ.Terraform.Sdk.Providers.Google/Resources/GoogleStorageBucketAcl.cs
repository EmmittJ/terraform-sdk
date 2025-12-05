using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_bucket_acl Terraform resource.
/// Manages a google_storage_bucket_acl resource.
/// </summary>
public partial class GoogleStorageBucketAcl(string name) : TerraformResource("google_storage_bucket_acl", name)
{
    /// <summary>
    /// The name of the bucket it applies to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Configure this ACL to be the default ACL.
    /// </summary>
    public TerraformValue<string>? DefaultAcl
    {
        get => GetArgument<TerraformValue<string>>("default_acl");
        set => SetArgument("default_acl", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The canned GCS ACL to apply. Must be set if role_entity is not.
    /// </summary>
    public TerraformValue<string>? PredefinedAcl
    {
        get => GetArgument<TerraformValue<string>>("predefined_acl");
        set => SetArgument("predefined_acl", value);
    }

    /// <summary>
    /// List of role/entity pairs in the form ROLE:entity. See GCS Bucket ACL documentation  for more details. Must be set if predefined_acl is not.
    /// </summary>
    public TerraformList<string> RoleEntity
    {
        get => GetArgument<TerraformList<string>>("role_entity") ?? CreateReference("role_entity");
        set => SetArgument("role_entity", value);
    }

}
