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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("id");
        SetOutput("origin");
        SetOutput("parent");
        SetOutput("reason");
        SetOutput("restrictions");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A stable, user-visible/meaningful string identifying the origin
    /// of the Lien, intended to be inspected programmatically. Maximum length of
    /// 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Origin is required")]
    public required TerraformProperty<string> Origin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin");
        set => SetProperty("origin", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Concise user-visible strings indicating why an action cannot be performed
    /// on a resource. Maximum length of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reason is required")]
    public required TerraformProperty<string> Reason
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reason");
        set => SetProperty("reason", value);
    }

    /// <summary>
    /// The types of operations which should be blocked as a result of this Lien.
    /// Each value should correspond to an IAM permission. The server will validate
    /// the permissions against those for which Liens are supported.  An empty
    /// list is meaningless and will be rejected.
    /// e.g. [&#39;resourcemanager.projects.delete&#39;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Restrictions is required")]
    public List<TerraformProperty<string>> Restrictions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("restrictions");
        set => SetProperty("restrictions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleResourceManagerLienTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
