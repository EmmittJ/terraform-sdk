using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: set
/// </summary>
public partial class GoogleDataCatalogTagTemplateFieldsBlock : TerraformBlockBase
{
    /// <summary>
    /// A description for this field.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display name for this field.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The field_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldId is required")]
    [TerraformProperty("field_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FieldId { get; set; }

    /// <summary>
    /// Whether this is a required field. Defaults to false.
    /// </summary>
    [TerraformProperty("is_required")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> IsRequired { get; set; }


    /// <summary>
    /// The order of this field with respect to other fields in this tag template.
    /// A higher value indicates a more important field. The value can be negative.
    /// Multiple fields can have the same order, and field orders within a tag do not have to be sequential.
    /// </summary>
    [TerraformProperty("order")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Order { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataCatalogTagTemplateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_catalog_tag_template resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataCatalogTagTemplate : TerraformResource
{
    public GoogleDataCatalogTagTemplate(string name) : base("google_data_catalog_tag_template", name)
    {
    }

    /// <summary>
    /// The display name for this template.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// This confirms the deletion of any possible tags using this template. Must be set to true in order to delete the tag template.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDelete { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Template location region.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id of the tag template to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagTemplateId is required")]
    [TerraformProperty("tag_template_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TagTemplateId { get; set; }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    [TerraformProperty("fields")]
    public TerraformSet<TerraformBlock<GoogleDataCatalogTagTemplateFieldsBlock>>? Fields { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataCatalogTagTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the tag template in URL format. Example: projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
