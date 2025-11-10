using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexGlossaryTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataplex_glossary resource.
/// </summary>
public class GoogleDataplexGlossary : TerraformResource
{
    public GoogleDataplexGlossary(string name) : base("google_dataplex_glossary", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("category_count");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("term_count");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("glossary_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The user-mutable description of the glossary.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User friendly display name of the glossary. This is user-mutable. This will be same as the glossaryId, if not specified.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The glossary id for creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryId is required")]
    public required TerraformProperty<string> GlossaryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("glossary_id");
        set => SetProperty("glossary_id", value);
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
    /// User-defined labels for the Glossary.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location where the glossary should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexGlossaryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The number of categories in the glossary.
    /// </summary>
    public TerraformExpression CategoryCount => this["category_count"];

    /// <summary>
    /// The time at which the glossary was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of the Glossary. Format: projects/{projectId}/locations/{locationId}/glossaries/{glossaryId}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The number of terms in the glossary.
    /// </summary>
    public TerraformExpression TermCount => this["term_count"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated unique id for the Glossary. This ID will be different if the Glossary is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time at which the glossary was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
