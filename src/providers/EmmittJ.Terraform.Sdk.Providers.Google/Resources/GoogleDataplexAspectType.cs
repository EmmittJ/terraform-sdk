using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexAspectTypeTimeoutsBlock : TerraformBlock
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
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("transfer_status");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("aspect_type_id");
        SetOutput("data_classification");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("metadata_template");
        SetOutput("project");
    }

    /// <summary>
    /// The aspect type id of the aspect type.
    /// </summary>
    public TerraformProperty<string> AspectTypeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aspect_type_id");
        set => SetProperty("aspect_type_id", value);
    }

    /// <summary>
    /// Classifies the data stored by the aspect.
    /// &#39;DATA_CLASSIFICATION_UNSPECIFIED&#39; denotes that the aspect contains only metadata
    /// while &#39;METADATA_AND_DATA&#39; indicates data derived content.
    /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values: [&amp;quot;DATA_CLASSIFICATION_UNSPECIFIED&amp;quot;, &amp;quot;METADATA_AND_DATA&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DataClassification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_classification");
        set => SetProperty("data_classification", value);
    }

    /// <summary>
    /// Description of the AspectType.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User friendly display name.
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
    /// User-defined labels for the AspectType.
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
    /// The location where aspect type will be created in.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// MetadataTemplate of the Aspect.
    /// </summary>
    public TerraformProperty<string> MetadataTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata_template");
        set => SetProperty("metadata_template", value);
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
    public GoogleDataplexAspectTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
