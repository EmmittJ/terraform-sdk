using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_catalog_tag resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleDataCatalogTag : TerraformResource
{
    public GoogleDataCatalogTag(string name) : base("google_data_catalog_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("template_displayname");
    }

    /// <summary>
    /// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
    /// individual column based on that schema.
    /// 
    /// For attaching a tag to a nested column, use &#39;.&#39; to separate the column names. Example:
    /// &#39;outer_column.inner_column&#39;
    /// </summary>
    public string? Column
    {
        get => GetProperty<TerraformLiteralProperty<string>>("column")?.Value;
        set => this.WithProperty("column", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
    /// all entries in that group.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the tag template that this tag uses. Example:
    /// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// This field cannot be modified after creation.
    /// </summary>
    public string? Template
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template")?.Value;
        set => this.WithProperty("template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the tag in URL format. Example:
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
    /// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id}
    /// where tag_id is a system-generated identifier. Note that this Tag may not actually be stored in the location in this name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The display name of the tag template.
    /// </summary>
    public TerraformExpression TemplateDisplayname => this["template_displayname"];

}
