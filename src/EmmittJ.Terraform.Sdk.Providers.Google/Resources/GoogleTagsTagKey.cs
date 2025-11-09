using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_tags_tag_key resource.
/// </summary>
public class GoogleTagsTagKey : TerraformResource
{
    public GoogleTagsTagKey(string name) : base("google_tags_tag_key", name)
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
    /// User-assigned description of the TagKey. Must not exceed 256 characters.
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
    /// Input only. The resource name of the new TagKey&#39;s parent. Must be of the form organizations/{org_id} or projects/{project_id_or_number}.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Optional. A purpose cannot be changed once set.
    /// 
    /// A purpose denotes that this Tag is intended for use in policies of a specific policy engine, and will involve that policy engine in management operations involving this Tag. Possible values: [&amp;quot;GCE_FIREWALL&amp;quot;, &amp;quot;DATA_GOVERNANCE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// Optional. Purpose data cannot be changed once set.
    /// 
    /// Purpose data corresponds to the policy system that the tag is intended for. For example, the GCE_FIREWALL purpose expects data in the following format: &#39;network = &amp;quot;&amp;lt;project-name&amp;gt;/&amp;lt;vpc-name&amp;gt;&amp;quot;&#39;.
    /// </summary>
    public TerraformMapProperty<string>? PurposeData
    {
        get => GetProperty<TerraformMapProperty<string>>("purpose_data");
        set => this.WithProperty("purpose_data", value);
    }

    /// <summary>
    /// Input only. The user friendly name for a TagKey. The short name should be unique for TagKeys within the same tag namespace.
    /// 
    /// The short name can have a maximum length of 256 characters. The permitted character set for the shortName includes all UTF-8 encoded Unicode characters except single quotes (&#39;), double quotes (&amp;quot;), backslashes (\\), and forward slashes (/).
    /// </summary>
    public TerraformProperty<string>? ShortName
    {
        get => GetProperty<TerraformProperty<string>>("short_name");
        set => this.WithProperty("short_name", value);
    }

    /// <summary>
    /// Output only. Creation time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The generated numeric id for the TagKey.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Namespaced name of the TagKey.
    /// </summary>
    public TerraformExpression NamespacedName => this["namespaced_name"];

    /// <summary>
    /// Output only. Update time.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
