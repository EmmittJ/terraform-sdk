using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleTagsTagValue.
/// Nesting mode: single
/// </summary>
public class GoogleTagsTagValueTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_tags_tag_value Terraform resource.
/// Manages a google_tags_tag_value resource.
/// </summary>
public partial class GoogleTagsTagValue(string name) : TerraformResource("google_tags_tag_value", name)
{
    /// <summary>
    /// User-assigned description of the TagValue. Must not exceed 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Input only. The resource name of the new TagValue&#39;s parent. Must be of the form tagKeys/{tag_key_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Input only. User-assigned short name for TagValue. The short name should be unique for TagValues within the same parent TagKey.
    /// 
    /// The short name can have a maximum length of 256 characters. The permitted character set for the shortName includes all UTF-8 encoded Unicode characters except single quotes (&#39;), double quotes (&amp;quot;), backslashes (\\), and forward slashes (/).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
        set => SetArgument("short_name", value);
    }

    /// <summary>
    /// Output only. Creation time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The generated numeric id for the TagValue.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Namespaced name of the TagValue. Will be in the format {parentNamespace}/{tagKeyShortName}/{shortName}.
    /// </summary>
    public TerraformValue<string> NamespacedName
    {
        get => new TerraformReference<string>(this, "namespaced_name");
    }

    /// <summary>
    /// Output only. Update time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleTagsTagValueTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleTagsTagValueTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
