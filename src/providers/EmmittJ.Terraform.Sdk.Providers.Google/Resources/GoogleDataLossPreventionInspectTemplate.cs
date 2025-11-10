using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlock : TerraformBlock
{
    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included. Possible values: [&amp;quot;CONTENT_TEXT&amp;quot;, &amp;quot;CONTENT_IMAGE&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? ContentOptions
    {
        set => SetProperty("content_options", value);
    }

    /// <summary>
    /// When true, excludes type information of the findings.
    /// </summary>
    public TerraformProperty<bool>? ExcludeInfoTypes
    {
        set => SetProperty("exclude_info_types", value);
    }

    /// <summary>
    /// When true, a contextual quote from the data that triggered a finding is included in the response.
    /// </summary>
    public TerraformProperty<bool>? IncludeQuote
    {
        set => SetProperty("include_quote", value);
    }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value: &amp;quot;POSSIBLE&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? MinLikelihood
    {
        set => SetProperty("min_likelihood", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionInspectTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_data_loss_prevention_inspect_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionInspectTemplate : TerraformResource
{
    public GoogleDataLossPreventionInspectTemplate(string name) : base("google_data_loss_prevention_inspect_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("parent");
        SetOutput("template_id");
    }

    /// <summary>
    /// A description of the inspect template.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User set display name of the inspect template.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parent of the inspect template in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformProperty<string> TemplateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_id");
        set => SetProperty("template_id", value);
    }

    /// <summary>
    /// Block for inspect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectConfig block(s) allowed")]
    public List<GoogleDataLossPreventionInspectTemplateInspectConfigBlock>? InspectConfig
    {
        set => SetProperty("inspect_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataLossPreventionInspectTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the inspect template. Set by the server.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
