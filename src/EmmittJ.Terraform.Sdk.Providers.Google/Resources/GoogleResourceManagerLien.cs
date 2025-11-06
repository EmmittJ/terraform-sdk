using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_resource_manager_lien resource.
/// </summary>
public class GoogleResourceManagerLien : TerraformResource
{
    public GoogleResourceManagerLien(string name) : base("google_resource_manager_lien", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
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
    /// A stable, user-visible/meaningful string identifying the origin
    /// of the Lien, intended to be inspected programmatically. Maximum length of
    /// 200 characters.
    /// </summary>
    public string? Origin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("origin")?.Value;
        set => this.WithProperty("origin", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A reference to the resource this Lien is attached to.
    /// The server will validate the parent against those for which Liens are supported.
    /// Since a variety of objects can have Liens against them, you must provide the type
    /// prefix (e.g. &amp;quot;projects/my-project-name&amp;quot;).
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Concise user-visible strings indicating why an action cannot be performed
    /// on a resource. Maximum length of 200 characters.
    /// </summary>
    public string? Reason
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reason")?.Value;
        set => this.WithProperty("reason", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The types of operations which should be blocked as a result of this Lien.
    /// Each value should correspond to an IAM permission. The server will validate
    /// the permissions against those for which Liens are supported.  An empty
    /// list is meaningless and will be rejected.
    /// e.g. [&#39;resourcemanager.projects.delete&#39;]
    /// </summary>
    public List<string>? Restrictions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("restrictions")?.Value;
        set => this.WithProperty("restrictions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Time of creation
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// A system-generated unique identifier for this Lien.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
