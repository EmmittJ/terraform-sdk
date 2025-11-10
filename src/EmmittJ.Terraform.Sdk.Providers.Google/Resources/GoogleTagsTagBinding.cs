using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleTagsTagBindingTimeoutsBlock : TerraformBlock
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
/// Manages a google_tags_tag_binding resource.
/// </summary>
public class GoogleTagsTagBinding : TerraformResource
{
    public GoogleTagsTagBinding(string name) : base("google_tags_tag_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
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
    /// The full resource name of the resource the TagValue is bound to. E.g. //cloudresourcemanager.googleapis.com/projects/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The TagValue of the TagBinding. Must be of the form tagValues/456.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValue is required")]
    public required TerraformProperty<string> TagValue
    {
        get => GetProperty<TerraformProperty<string>>("tag_value");
        set => this.WithProperty("tag_value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleTagsTagBindingTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleTagsTagBindingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The generated id for the TagBinding. This is a string of the form: &#39;tagBindings/{full-resource-name}/{tag-value-name}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
