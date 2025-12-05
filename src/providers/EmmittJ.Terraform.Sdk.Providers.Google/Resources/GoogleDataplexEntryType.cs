using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for required_aspects in GoogleDataplexEntryType.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryTypeRequiredAspectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "required_aspects";

    /// <summary>
    /// Required aspect type for the entry type.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexEntryType.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataplex_entry_type Terraform resource.
/// Manages a google_dataplex_entry_type resource.
/// </summary>
public partial class GoogleDataplexEntryType(string name) : TerraformResource("google_dataplex_entry_type", name)
{
    /// <summary>
    /// Description of the EntryType.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The entry type id of the entry type.
    /// </summary>
    public TerraformValue<string>? EntryTypeId
    {
        get => GetArgument<TerraformValue<string>>("entry_type_id");
        set => SetArgument("entry_type_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels for the EntryType.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where entry type will be created in.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The platform that Entries of this type belongs to.
    /// </summary>
    public TerraformValue<string>? Platform
    {
        get => GetArgument<TerraformValue<string>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The system that Entries of this type belongs to.
    /// </summary>
    public TerraformValue<string>? System
    {
        get => GetArgument<TerraformValue<string>>("system");
        set => SetArgument("system", value);
    }

    /// <summary>
    /// Indicates the class this Entry Type belongs to, for example, TABLE, DATABASE, MODEL.
    /// </summary>
    public TerraformList<string>? TypeAliases
    {
        get => GetArgument<TerraformList<string>>("type_aliases");
        set => SetArgument("type_aliases", value);
    }

    /// <summary>
    /// The time when the EntryType was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The relative resource name of the EntryType, of the form: projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// System generated globally unique ID for the EntryType. This ID will be different if the EntryType is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The time when the EntryType was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// RequiredAspects block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataplexEntryTypeRequiredAspectsBlock>? RequiredAspects
    {
        get => GetArgument<TerraformList<GoogleDataplexEntryTypeRequiredAspectsBlock>>("required_aspects");
        set => SetArgument("required_aspects", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexEntryTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexEntryTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
