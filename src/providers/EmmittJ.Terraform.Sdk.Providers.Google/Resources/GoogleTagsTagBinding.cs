using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleTagsTagBinding.
/// Nesting mode: single
/// </summary>
public class GoogleTagsTagBindingTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_tags_tag_binding Terraform resource.
/// Manages a google_tags_tag_binding resource.
/// </summary>
public partial class GoogleTagsTagBinding(string name) : TerraformResource("google_tags_tag_binding", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The full resource name of the resource the TagValue is bound to. E.g. //cloudresourcemanager.googleapis.com/projects/123
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The TagValue of the TagBinding. Must be of the form tagValues/456.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValue is required")]
    public required TerraformValue<string> TagValue
    {
        get => GetArgument<TerraformValue<string>>("tag_value");
        set => SetArgument("tag_value", value);
    }

    /// <summary>
    /// The generated id for the TagBinding. This is a string of the form: &#39;tagBindings/{full-resource-name}/{tag-value-name}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleTagsTagBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleTagsTagBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
