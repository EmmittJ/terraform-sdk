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
    public TerraformProperty<string>? AspectTypeId
    {
        get => GetProperty<TerraformProperty<string>>("aspect_type_id");
        set => this.WithProperty("aspect_type_id", value);
    }

    /// <summary>
    /// Classifies the data stored by the aspect.
    /// &#39;DATA_CLASSIFICATION_UNSPECIFIED&#39; denotes that the aspect contains only metadata
    /// while &#39;METADATA_AND_DATA&#39; indicates data derived content.
    /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values: [&amp;quot;DATA_CLASSIFICATION_UNSPECIFIED&amp;quot;, &amp;quot;METADATA_AND_DATA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DataClassification
    {
        get => GetProperty<TerraformProperty<string>>("data_classification");
        set => this.WithProperty("data_classification", value);
    }

    /// <summary>
    /// Description of the AspectType.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// User friendly display name.
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
    /// User-defined labels for the AspectType.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location where aspect type will be created in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// MetadataTemplate of the Aspect.
    /// </summary>
    public TerraformProperty<string>? MetadataTemplate
    {
        get => GetProperty<TerraformProperty<string>>("metadata_template");
        set => this.WithProperty("metadata_template", value);
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
