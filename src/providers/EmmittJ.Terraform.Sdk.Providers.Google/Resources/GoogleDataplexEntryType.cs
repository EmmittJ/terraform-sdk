using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for required_aspects in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryTypeRequiredAspectsBlock : TerraformBlock
{
    /// <summary>
    /// Required aspect type for the entry type.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryTypeTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataplex_entry_type resource.
/// </summary>
public class GoogleDataplexEntryType : TerraformResource
{
    public GoogleDataplexEntryType(string name) : base("google_dataplex_entry_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("entry_type_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("platform");
        SetOutput("project");
        SetOutput("system");
        SetOutput("type_aliases");
    }

    /// <summary>
    /// Description of the EntryType.
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
    /// The entry type id of the entry type.
    /// </summary>
    public TerraformProperty<string> EntryTypeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_type_id");
        set => SetProperty("entry_type_id", value);
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
    /// User-defined labels for the EntryType.
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
    /// The location where entry type will be created in.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The platform that Entries of this type belongs to.
    /// </summary>
    public TerraformProperty<string> Platform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform");
        set => SetProperty("platform", value);
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
    /// The system that Entries of this type belongs to.
    /// </summary>
    public TerraformProperty<string> System
    {
        get => GetRequiredOutput<TerraformProperty<string>>("system");
        set => SetProperty("system", value);
    }

    /// <summary>
    /// Indicates the class this Entry Type belongs to, for example, TABLE, DATABASE, MODEL.
    /// </summary>
    public List<TerraformProperty<string>> TypeAliases
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("type_aliases");
        set => SetProperty("type_aliases", value);
    }

    /// <summary>
    /// Block for required_aspects.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataplexEntryTypeRequiredAspectsBlock>? RequiredAspects
    {
        set => SetProperty("required_aspects", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexEntryTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the EntryType was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The relative resource name of the EntryType, of the form: projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated globally unique ID for the EntryType. This ID will be different if the EntryType is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time when the EntryType was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
