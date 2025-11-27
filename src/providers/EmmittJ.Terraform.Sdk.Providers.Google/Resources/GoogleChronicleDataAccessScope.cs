using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowed_data_access_labels in GoogleChronicleDataAccessScope.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_data_access_labels";

    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    public TerraformValue<string>? AssetNamespace
    {
        get => new TerraformReference<string>(this, "asset_namespace");
        set => SetArgument("asset_namespace", value);
    }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    public TerraformValue<string>? DataAccessLabel
    {
        get => new TerraformReference<string>(this, "data_access_label");
        set => SetArgument("data_access_label", value);
    }

    /// <summary>
    /// Output only. The display name of the label.
    /// Data access label and log types&#39;s name
    /// will match the display name of the resource.
    /// The asset namespace will match the namespace itself.
    /// The ingestion key value pair will match the key of the tuple.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The name of the log type.
    /// </summary>
    public TerraformValue<string>? LogType
    {
        get => new TerraformReference<string>(this, "log_type");
        set => SetArgument("log_type", value);
    }

    /// <summary>
    /// IngestionLabel block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngestionLabel block(s) allowed")]
    public TerraformList<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlockIngestionLabelBlock>? IngestionLabel
    {
        get => GetArgument<TerraformList<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlockIngestionLabelBlock>>("ingestion_label");
        set => SetArgument("ingestion_label", value);
    }

}

/// <summary>
/// Block type for ingestion_label in GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlockIngestionLabelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingestion_label";

    /// <summary>
    /// Required. The key of the ingestion label. Always required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionLabelKey is required")]
    public required TerraformValue<string> IngestionLabelKey
    {
        get => new TerraformReference<string>(this, "ingestion_label_key");
        set => SetArgument("ingestion_label_key", value);
    }

    /// <summary>
    /// Optional. The value of the ingestion label. Optional. An object
    /// with no provided value and some key provided would match
    /// against the given key and ANY value.
    /// </summary>
    public TerraformValue<string>? IngestionLabelValue
    {
        get => new TerraformReference<string>(this, "ingestion_label_value");
        set => SetArgument("ingestion_label_value", value);
    }

}


/// <summary>
/// Block type for denied_data_access_labels in GoogleChronicleDataAccessScope.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "denied_data_access_labels";

    /// <summary>
    /// The asset namespace configured in the forwarder
    /// of the customer&#39;s events.
    /// </summary>
    public TerraformValue<string>? AssetNamespace
    {
        get => new TerraformReference<string>(this, "asset_namespace");
        set => SetArgument("asset_namespace", value);
    }

    /// <summary>
    /// The name of the data access label.
    /// </summary>
    public TerraformValue<string>? DataAccessLabel
    {
        get => new TerraformReference<string>(this, "data_access_label");
        set => SetArgument("data_access_label", value);
    }

    /// <summary>
    /// Output only. The display name of the label.
    /// Data access label and log types&#39;s name
    /// will match the display name of the resource.
    /// The asset namespace will match the namespace itself.
    /// The ingestion key value pair will match the key of the tuple.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The name of the log type.
    /// </summary>
    public TerraformValue<string>? LogType
    {
        get => new TerraformReference<string>(this, "log_type");
        set => SetArgument("log_type", value);
    }

    /// <summary>
    /// IngestionLabel block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IngestionLabel block(s) allowed")]
    public TerraformList<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlockIngestionLabelBlock>? IngestionLabel
    {
        get => GetArgument<TerraformList<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlockIngestionLabelBlock>>("ingestion_label");
        set => SetArgument("ingestion_label", value);
    }

}

/// <summary>
/// Block type for ingestion_label in GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlockIngestionLabelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ingestion_label";

    /// <summary>
    /// Required. The key of the ingestion label. Always required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionLabelKey is required")]
    public required TerraformValue<string> IngestionLabelKey
    {
        get => new TerraformReference<string>(this, "ingestion_label_key");
        set => SetArgument("ingestion_label_key", value);
    }

    /// <summary>
    /// Optional. The value of the ingestion label. Optional. An object
    /// with no provided value and some key provided would match
    /// against the given key and ANY value.
    /// </summary>
    public TerraformValue<string>? IngestionLabelValue
    {
        get => new TerraformReference<string>(this, "ingestion_label_value");
        set => SetArgument("ingestion_label_value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleChronicleDataAccessScope.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleDataAccessScopeTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_chronicle_data_access_scope Terraform resource.
/// Manages a google_chronicle_data_access_scope resource.
/// </summary>
public partial class GoogleChronicleDataAccessScope(string name) : TerraformResource("google_chronicle_data_access_scope", name)
{
    /// <summary>
    /// Optional. Whether or not the scope allows all labels, allow_all and
    /// allowed_data_access_labels are mutually exclusive and one of them must be
    /// present. denied_data_access_labels can still be used along with allow_all.
    /// When combined with denied_data_access_labels, access will be granted to all
    /// data that doesn&#39;t have labels mentioned in denied_data_access_labels. E.g.:
    /// A customer with scope with denied labels A and B and allow_all will be able
    /// to see all data except data labeled with A and data labeled with B and data
    /// with labels A and B.
    /// </summary>
    public TerraformValue<bool>? AllowAll
    {
        get => new TerraformReference<bool>(this, "allow_all");
        set => SetArgument("allow_all", value);
    }

    /// <summary>
    /// Required. The user provided scope id which will become the last part of the name
    /// of the scope resource.
    /// Needs to be compliant with https://google.aip.dev/122
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessScopeId is required")]
    public required TerraformValue<string> DataAccessScopeId
    {
        get => new TerraformReference<string>(this, "data_access_scope_id");
        set => SetArgument("data_access_scope_id", value);
    }

    /// <summary>
    /// Optional. A description of the data access scope for a human reader.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The user who created the data access scope.
    /// </summary>
    public TerraformValue<string> Author
    {
        get => new TerraformReference<string>(this, "author");
    }

    /// <summary>
    /// Output only. The time at which the data access scope was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. The name to be used for display to customers of the data access scope.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// Output only. The user who last updated the data access scope.
    /// </summary>
    public TerraformValue<string> LastEditor
    {
        get => new TerraformReference<string>(this, "last_editor");
    }

    /// <summary>
    /// The unique full name of the data access scope. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope_id}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The time at which the data access scope was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// AllowedDataAccessLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock>? AllowedDataAccessLabels
    {
        get => GetArgument<TerraformList<GoogleChronicleDataAccessScopeAllowedDataAccessLabelsBlock>>("allowed_data_access_labels");
        set => SetArgument("allowed_data_access_labels", value);
    }

    /// <summary>
    /// DeniedDataAccessLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock>? DeniedDataAccessLabels
    {
        get => GetArgument<TerraformList<GoogleChronicleDataAccessScopeDeniedDataAccessLabelsBlock>>("denied_data_access_labels");
        set => SetArgument("denied_data_access_labels", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleDataAccessScopeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleDataAccessScopeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
