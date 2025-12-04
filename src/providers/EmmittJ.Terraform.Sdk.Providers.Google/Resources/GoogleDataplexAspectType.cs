using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDataplexAspectType.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexAspectTypeTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataplex_aspect_type Terraform resource.
/// Manages a google_dataplex_aspect_type resource.
/// </summary>
public partial class GoogleDataplexAspectType(string name) : TerraformResource("google_dataplex_aspect_type", name)
{
    /// <summary>
    /// The aspect type id of the aspect type.
    /// </summary>
    public TerraformValue<string>? AspectTypeId
    {
        get => GetArgument<TerraformValue<string>>("aspect_type_id");
        set => SetArgument("aspect_type_id", value);
    }

    /// <summary>
    /// Classifies the data stored by the aspect.
    /// &#39;DATA_CLASSIFICATION_UNSPECIFIED&#39; denotes that the aspect contains only metadata
    /// while &#39;METADATA_AND_DATA&#39; indicates data derived content.
    /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values: [&amp;quot;DATA_CLASSIFICATION_UNSPECIFIED&amp;quot;, &amp;quot;METADATA_AND_DATA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DataClassification
    {
        get => GetArgument<TerraformValue<string>>("data_classification");
        set => SetArgument("data_classification", value);
    }

    /// <summary>
    /// Description of the AspectType.
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels for the AspectType.
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
    /// The location where aspect type will be created in.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// MetadataTemplate of the Aspect.
    /// </summary>
    public TerraformValue<string>? MetadataTemplate
    {
        get => GetArgument<TerraformValue<string>>("metadata_template");
        set => SetArgument("metadata_template", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the AspectType was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The relative resource name of the AspectType, of the form: projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Denotes the transfer status of the Aspect Type. It is unspecified
    /// for Aspect Type created from Dataplex API.
    /// </summary>
    public TerraformValue<string> TransferStatus
        => AsReference("transfer_status");

    /// <summary>
    /// System generated globally unique ID for the AspectType. This ID will be different if the AspectType is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time when the AspectType was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexAspectTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexAspectTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
