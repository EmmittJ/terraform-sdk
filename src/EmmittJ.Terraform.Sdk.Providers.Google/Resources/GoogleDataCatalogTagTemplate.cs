using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public class GoogleDataCatalogTagTemplateFieldsBlock : TerraformBlock
{
    /// <summary>
    /// A description for this field.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The display name for this field.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// The field_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldId is required")]
    public required TerraformProperty<string> FieldId
    {
        get => GetProperty<TerraformProperty<string>>("field_id");
        set => WithProperty("field_id", value);
    }

    /// <summary>
    /// Whether this is a required field. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? IsRequired
    {
        get => GetProperty<TerraformProperty<bool>>("is_required");
        set => WithProperty("is_required", value);
    }

    /// <summary>
    /// The resource name of the tag template field in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}/fields/{field}
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The order of this field with respect to other fields in this tag template.
    /// A higher value indicates a more important field. The value can be negative.
    /// Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogTagTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_catalog_tag_template resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataCatalogTagTemplate : TerraformResource
{
    public GoogleDataCatalogTagTemplate(string name) : base("google_data_catalog_tag_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The display name for this template.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Template location region.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id of the tag template to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagTemplateId is required")]
    public required TerraformProperty<string> TagTemplateId
    {
        get => GetProperty<TerraformProperty<string>>("tag_template_id");
        set => this.WithProperty("tag_template_id", value);
    }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public HashSet<GoogleDataCatalogTagTemplateFieldsBlock>? Fields
    {
        get => GetProperty<HashSet<GoogleDataCatalogTagTemplateFieldsBlock>>("fields");
        set => this.WithProperty("fields", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataCatalogTagTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataCatalogTagTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the tag template in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// </summary>
    public TerraformExpression Name => this["name"];

}
