using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAlloydbUser.
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbUserTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_alloydb_user Terraform resource.
/// Manages a google_alloydb_user resource.
/// </summary>
public partial class GoogleAlloydbUser(string name) : TerraformResource("google_alloydb_user", name)
{
    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// List of database roles this database user has.
    /// </summary>
    public TerraformList<string>? DatabaseRoles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "database_roles").ResolveNodes(ctx));
        set => SetArgument("database_roles", value);
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
    /// Password for this database user.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The database role name of the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The type of this user. Possible values: [&amp;quot;ALLOYDB_BUILT_IN&amp;quot;, &amp;quot;ALLOYDB_IAM_USER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserType is required")]
    public required TerraformValue<string> UserType
    {
        get => new TerraformReference<string>(this, "user_type");
        set => SetArgument("user_type", value);
    }

    /// <summary>
    /// Name of the resource in the form of projects/{project}/locations/{location}/clusters/{cluster}/users/{user}.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAlloydbUserTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAlloydbUserTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
