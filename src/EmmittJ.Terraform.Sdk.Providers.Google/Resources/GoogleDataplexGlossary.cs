using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("category_count");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("term_count");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The user-mutable description of the glossary.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User friendly display name of the glossary. This is user-mutable. This will be same as the glossaryId, if not specified.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The glossary id for creation.
    /// </summary>
    public TerraformProperty<string>? GlossaryId
    {
        get => GetProperty<TerraformProperty<string>>("glossary_id");
        set => this.WithProperty("glossary_id", value);
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
    /// User-defined labels for the Glossary.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location where the glossary should reside.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
