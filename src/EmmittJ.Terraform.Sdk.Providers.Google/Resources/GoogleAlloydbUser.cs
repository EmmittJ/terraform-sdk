using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformLiteralProperty<string>? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// List of database roles this database user has.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DatabaseRoles
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("database_roles");
        set => this.WithProperty("database_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Password for this database user.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The database role name of the user.
    /// </summary>
    public TerraformLiteralProperty<string>? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// The type of this user. Possible values: [&amp;quot;ALLOYDB_BUILT_IN&amp;quot;, &amp;quot;ALLOYDB_IAM_USER&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
    }

    /// <summary>
    /// Name of the resource in the form of projects/{project}/locations/{location}/clusters/{cluster}/users/{user}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
