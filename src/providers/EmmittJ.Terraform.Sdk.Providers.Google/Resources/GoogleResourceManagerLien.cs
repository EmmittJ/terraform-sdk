using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleResourceManagerLien.
/// Nesting mode: single
/// </summary>
public class GoogleResourceManagerLienTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_resource_manager_lien Terraform resource.
/// Manages a google_resource_manager_lien resource.
/// </summary>
public partial class GoogleResourceManagerLien(string name) : TerraformResource("google_resource_manager_lien", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A stable, user-visible/meaningful string identifying the origin
    /// of the Lien, intended to be inspected programmatically. Maximum length of
    /// 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    public required TerraformValue<string> Origin
    {
        get => new TerraformReference<string>(this, "origin");
        set => SetArgument("origin", value);
    }

    /// <summary>
    /// A reference to the resource this Lien is attached to.
    /// The server will validate the parent against those for which Liens are supported.
    /// Since a variety of objects can have Liens against them, you must provide the type
    /// prefix (e.g. &amp;quot;projects/my-project-name&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Concise user-visible strings indicating why an action cannot be performed
    /// on a resource. Maximum length of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformValue<string> Reason
    {
        get => new TerraformReference<string>(this, "reason");
        set => SetArgument("reason", value);
    }

    /// <summary>
    /// The types of operations which should be blocked as a result of this Lien.
    /// Each value should correspond to an IAM permission. The server will validate
    /// the permissions against those for which Liens are supported.  An empty
    /// list is meaningless and will be rejected.
    /// e.g. [&#39;resourcemanager.projects.delete&#39;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    public TerraformList<string>? Restrictions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "restrictions").ResolveNodes(ctx));
        set => SetArgument("restrictions", value);
    }

    /// <summary>
    /// Time of creation
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// A system-generated unique identifier for this Lien.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleResourceManagerLienTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleResourceManagerLienTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
