using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deidentify_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_loss_prevention_deidentify_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionDeidentifyTemplate : TerraformResource
{
    public GoogleDataLossPreventionDeidentifyTemplate(string name) : base("google_data_loss_prevention_deidentify_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// A description of the template.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User set display name of the template.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The parent of the template in any of the following formats:
    ///
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// Block for deidentify_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeidentifyConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeidentifyConfig block(s) allowed")]
    public List<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock>? DeidentifyConfig
    {
        get => GetProperty<List<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock>>("deidentify_config");
        set => this.WithProperty("deidentify_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The creation timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the template. Set by the server.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The last update timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
