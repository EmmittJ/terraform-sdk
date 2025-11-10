using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleTagsTagValueTimeoutsBlock : TerraformBlock
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
/// Manages a google_tags_tag_value resource.
/// </summary>
public class GoogleTagsTagValue : TerraformResource
{
    public GoogleTagsTagValue(string name) : base("google_tags_tag_value", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("namespaced_name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User-assigned description of the TagValue. Must not exceed 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Input only. The resource name of the new TagValue&#39;s parent. Must be of the form tagKeys/{tag_key_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Input only. User-assigned short name for TagValue. The short name should be unique for TagValues within the same parent TagKey.
    /// 
    /// The short name can have a maximum length of 256 characters. The permitted character set for the shortName includes all UTF-8 encoded Unicode characters except single quotes (&#39;), double quotes (&amp;quot;), backslashes (\\), and forward slashes (/).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShortName is required")]
    public required TerraformProperty<string> ShortName
    {
        get => GetProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleTagsTagValueTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleTagsTagValueTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Creation time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The generated numeric id for the TagValue.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Namespaced name of the TagValue. Will be in the format {parentNamespace}/{tagKeyShortName}/{shortName}.
    /// </summary>
    public TerraformExpression NamespacedName => this["namespaced_name"];

    /// <summary>
    /// Output only. Update time.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
