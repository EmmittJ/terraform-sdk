using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleResourceManagerLienTimeoutsBlock : TerraformBlock
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

}

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
        this.WithOutput("create_time");
        this.WithOutput("name");
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
    /// A stable, user-visible/meaningful string identifying the origin
    /// of the Lien, intended to be inspected programmatically. Maximum length of
    /// 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    public required TerraformProperty<string> Origin
    {
        get => GetRequiredProperty<TerraformProperty<string>>("origin");
        set => this.WithProperty("origin", value);
    }

    /// <summary>
    /// A reference to the resource this Lien is attached to.
    /// The server will validate the parent against those for which Liens are supported.
    /// Since a variety of objects can have Liens against them, you must provide the type
    /// prefix (e.g. &amp;quot;projects/my-project-name&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Concise user-visible strings indicating why an action cannot be performed
    /// on a resource. Maximum length of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformProperty<string> Reason
    {
        get => GetRequiredProperty<TerraformProperty<string>>("reason");
        set => this.WithProperty("reason", value);
    }

    /// <summary>
    /// The types of operations which should be blocked as a result of this Lien.
    /// Each value should correspond to an IAM permission. The server will validate
    /// the permissions against those for which Liens are supported.  An empty
    /// list is meaningless and will be rejected.
    /// e.g. [&#39;resourcemanager.projects.delete&#39;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    public List<TerraformProperty<string>>? Restrictions
    {
        get => GetProperty<List<TerraformProperty<string>>>("restrictions");
        set => this.WithProperty("restrictions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleResourceManagerLienTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleResourceManagerLienTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
