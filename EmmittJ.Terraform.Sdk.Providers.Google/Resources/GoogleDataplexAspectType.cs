using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_aspect_type resource.
/// </summary>
public class GoogleDataplexAspectType : TerraformResource
{
    public GoogleDataplexAspectType(string name) : base("google_dataplex_aspect_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("transfer_status");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The aspect type id of the aspect type.
    /// </summary>
    public string? AspectTypeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aspect_type_id")?.Value;
        set => this.WithProperty("aspect_type_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Classifies the data stored by the aspect.
    /// &#39;DATA_CLASSIFICATION_UNSPECIFIED&#39; denotes that the aspect contains only metadata
    /// while &#39;METADATA_AND_DATA&#39; indicates data derived content.
    /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values: [&amp;quot;DATA_CLASSIFICATION_UNSPECIFIED&amp;quot;, &amp;quot;METADATA_AND_DATA&amp;quot;]
    /// </summary>
    public string? DataClassification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_classification")?.Value;
        set => this.WithProperty("data_classification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description of the AspectType.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// User-defined labels for the AspectType.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location where aspect type will be created in.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// MetadataTemplate of the Aspect.
    /// </summary>
    public string? MetadataTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata_template")?.Value;
        set => this.WithProperty("metadata_template", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time when the AspectType was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The relative resource name of the AspectType, of the form: projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Denotes the transfer status of the Aspect Type. It is unspecified
    /// for Aspect Type created from Dataplex API.
    /// </summary>
    public TerraformExpression TransferStatus => this["transfer_status"];

    /// <summary>
    /// System generated globally unique ID for the AspectType. This ID will be different if the AspectType is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time when the AspectType was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
