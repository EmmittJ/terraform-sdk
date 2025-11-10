using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlock : TerraformBlock
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied. Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CombiningFunction
    {
        set => SetProperty("combining_function", value);
    }

}

/// <summary>
/// Block type for custom in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelCustomBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_access_context_manager_access_level resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerAccessLevel : TerraformResource
{
    public GoogleAccessContextManagerAccessLevel(string name) : base("google_access_context_manager_access_level", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent");
        SetOutput("title");
    }

    /// <summary>
    /// Description of the AccessLevel and its use. Does not affect behavior.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// Block for basic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    public List<GoogleAccessContextManagerAccessLevelBasicBlock>? Basic
    {
        set => SetProperty("basic", value);
    }

    /// <summary>
    /// Block for custom.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Custom block(s) allowed")]
    public List<GoogleAccessContextManagerAccessLevelCustomBlock>? Custom
    {
        set => SetProperty("custom", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerAccessLevelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
