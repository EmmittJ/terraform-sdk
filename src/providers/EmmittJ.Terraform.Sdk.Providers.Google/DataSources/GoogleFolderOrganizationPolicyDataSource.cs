using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_folder_organization_policy Terraform data source.
/// Retrieves information about a google_folder_organization_policy.
/// </summary>
public partial class GoogleFolderOrganizationPolicyDataSource(string name) : TerraformDataSource("google_folder_organization_policy", name)
{
    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformValue<string> Constraint
    {
        get => new TerraformReference<string>(this, "constraint");
        set => SetArgument("constraint", value);
    }

    /// <summary>
    /// The resource name of the folder to set the policy for. Its format is folders/{folder_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformValue<string> Folder
    {
        get => new TerraformReference<string>(this, "folder");
        set => SetArgument("folder", value);
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
    /// A boolean policy is a constraint that is either enforced or not.
    /// </summary>
    public TerraformList<TerraformMap<object>> BooleanPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "boolean_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. 
    /// </summary>
    public TerraformList<TerraformMap<object>> ListPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "list_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// A restore policy is a constraint to restore the default policy.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestorePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "restore_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}
