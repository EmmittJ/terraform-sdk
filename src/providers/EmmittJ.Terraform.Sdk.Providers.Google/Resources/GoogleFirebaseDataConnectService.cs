using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseDataConnectService.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseDataConnectServiceTimeoutsBlock : TerraformBlock
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
/// Represents a google_firebase_data_connect_service Terraform resource.
/// Manages a google_firebase_data_connect_service resource.
/// </summary>
public partial class GoogleFirebaseDataConnectService(string name) : TerraformResource("google_firebase_data_connect_service", name)
{
    /// <summary>
    /// Optional. Stores small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The deletion policy for the database. Setting the field to FORCE allows the
    /// Service to be deleted even if a Schema or Connector is present. By default,
    /// the Service deletion will only succeed when no Schema or Connectors are
    /// present.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// Optional. Mutable human-readable name. 63 character limit.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// Optional. Labels as key value pairs.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The region in which the service resides, e.g. &amp;quot;us-central1&amp;quot; or &amp;quot;asia-east1&amp;quot;.
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
    /// Required. The ID to use for the service, which will become the final component of the
    /// service&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// Output only. [Output only] Create time stamp.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// [AIP-154](https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Identifier. The relative resource name of the Firebase Data Connect service, in the
    /// format:
    /// &#39;&#39;&#39;
    /// projects/{project}/locations/{location}/services/{service}
    /// &#39;&#39;&#39;
    /// Note that the service ID is specific to Firebase Data Connect and does not
    /// correspond to any of the instance IDs of the underlying data source
    /// connections.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. A field that if true, indicates that the system is working update the
    /// service.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. [Output only] Update time stamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseDataConnectServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseDataConnectServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
