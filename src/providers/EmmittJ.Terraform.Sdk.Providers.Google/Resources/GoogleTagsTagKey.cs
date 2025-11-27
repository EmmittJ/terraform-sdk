using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleTagsTagKey.
/// Nesting mode: single
/// </summary>
public class GoogleTagsTagKeyTimeoutsBlock : TerraformBlock
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
/// Represents a google_tags_tag_key Terraform resource.
/// Manages a google_tags_tag_key resource.
/// </summary>
public partial class GoogleTagsTagKey(string name) : TerraformResource("google_tags_tag_key", name)
{
    /// <summary>
    /// User-assigned description of the TagKey. Must not exceed 256 characters.
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
    /// Input only. The resource name of the new TagKey&#39;s parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Optional. A purpose cannot be changed once set.
    /// 
    /// A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values: [&amp;quot;GCE_FIREWALL&amp;quot;, &amp;quot;DATA_GOVERNANCE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Purpose
    {
        get => new TerraformReference<string>(this, "purpose");
        set => SetArgument("purpose", value);
    }

    /// <summary>
    /// Optional. Purpose data cannot be changed once set.
    /// 
    /// Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: &#39;network = &amp;quot;&amp;lt;project-name&amp;gt;/&amp;lt;vpc-name&amp;gt;&amp;quot;&#39;.
    /// </summary>
    public TerraformMap<string>? PurposeData
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "purpose_data").ResolveNodes(ctx));
        set => SetArgument("purpose_data", value);
    }

    /// <summary>
    /// Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace.
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
    /// The generated numeric id for the TagKey.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Namespaced name of the TagKey.
    /// </summary>
    public TerraformValue<string> NamespacedName
    {
        get => new TerraformReference<string>(this, "namespaced_name");
    }

    /// <summary>
    /// Output only. Update time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleTagsTagKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleTagsTagKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
