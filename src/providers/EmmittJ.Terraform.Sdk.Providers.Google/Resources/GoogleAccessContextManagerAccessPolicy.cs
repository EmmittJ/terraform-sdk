using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_access_context_manager_access_policy resource.
/// </summary>
public class GoogleAccessContextManagerAccessPolicy : TerraformResource
{
    public GoogleAccessContextManagerAccessPolicy(string name) : base("google_access_context_manager_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("update_time");
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
    /// The parent of this AccessPolicy in the Cloud Resource Hierarchy.
    /// Format: &#39;organizations/{{organization_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Folder or project on which this policy is applicable.
    /// Format: &#39;folders/{{folder_id}}&#39; or &#39;projects/{{project_number}}&#39;
    /// </summary>
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// Human readable title. Does not affect behavior.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAccessContextManagerAccessPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the AccessPolicy was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Resource name of the AccessPolicy. Format: &#39;{{policy_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Time the AccessPolicy was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
