using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbUserTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_alloydb_user resource.
/// </summary>
public class GoogleAlloydbUser : TerraformResource
{
    public GoogleAlloydbUser(string name) : base("google_alloydb_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Identifies the alloydb cluster. Must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// List of database roles this database user has.
    /// </summary>
    public List<TerraformProperty<string>>? DatabaseRoles
    {
        get => GetProperty<List<TerraformProperty<string>>>("database_roles");
        set => this.WithProperty("database_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Password for this database user.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The database role name of the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformProperty<string> UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// The type of this user. Possible values: [&amp;quot;ALLOYDB_BUILT_IN&amp;quot;, &amp;quot;ALLOYDB_IAM_USER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserType is required")]
    public required TerraformProperty<string> UserType
    {
        get => GetProperty<TerraformProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAlloydbUserTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAlloydbUserTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Name of the resource in the form of projects/{project}/locations/{location}/clusters/{cluster}/users/{user}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
