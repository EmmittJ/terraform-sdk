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
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// List of database roles this database user has.
    /// </summary>
    public List<string>? DatabaseRoles
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("database_roles")?.Value;
        set => this.WithProperty("database_roles", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Password for this database user.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database role name of the user.
    /// </summary>
    public string? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id")?.Value;
        set => this.WithProperty("user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of this user. Possible values: [&amp;quot;ALLOYDB_BUILT_IN&amp;quot;, &amp;quot;ALLOYDB_IAM_USER&amp;quot;]
    /// </summary>
    public string? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type")?.Value;
        set => this.WithProperty("user_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource in the form of projects/{project}/locations/{location}/clusters/{cluster}/users/{user}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
