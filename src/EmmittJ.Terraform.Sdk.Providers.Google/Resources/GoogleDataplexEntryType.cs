using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the EntryType.
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
    /// The entry type id of the entry type.
    /// </summary>
    public TerraformProperty<string>? EntryTypeId
    {
        get => GetProperty<TerraformProperty<string>>("entry_type_id");
        set => this.WithProperty("entry_type_id", value);
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
    /// User-defined labels for the EntryType.
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
    /// The location where entry type will be created in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The platform that Entries of this type belongs to.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        get => GetProperty<TerraformProperty<string>>("platform");
        set => this.WithProperty("platform", value);
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
    /// The system that Entries of this type belongs to.
    /// </summary>
    public TerraformProperty<string>? System
    {
        get => GetProperty<TerraformProperty<string>>("system");
        set => this.WithProperty("system", value);
    }

    /// <summary>
    /// Indicates the class this Entry Type belongs to, for example, TABLE, DATABASE, MODEL.
    /// </summary>
    public TerraformProperty<List<string>>? TypeAliases
    {
        get => GetProperty<TerraformProperty<List<string>>>("type_aliases");
        set => this.WithProperty("type_aliases", value);
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
