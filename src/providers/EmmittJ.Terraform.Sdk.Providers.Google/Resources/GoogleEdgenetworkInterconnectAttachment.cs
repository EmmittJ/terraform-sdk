using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleEdgenetworkInterconnectAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleEdgenetworkInterconnectAttachmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_edgenetwork_interconnect_attachment Terraform resource.
/// Manages a google_edgenetwork_interconnect_attachment resource.
/// </summary>
public partial class GoogleEdgenetworkInterconnectAttachment(string name) : TerraformResource("google_edgenetwork_interconnect_attachment", name)
{
    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
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
    /// The ID of the underlying interconnect that this attachment&#39;s traffic will traverse through.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interconnect is required")]
    public required TerraformValue<string> Interconnect
    {
        get => new TerraformReference<string>(this, "interconnect");
        set => SetArgument("interconnect", value);
    }

    /// <summary>
    /// A unique ID that identifies this interconnect attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterconnectAttachmentId is required")]
    public required TerraformValue<string> InterconnectAttachmentId
    {
        get => new TerraformReference<string>(this, "interconnect_attachment_id");
        set => SetArgument("interconnect_attachment_id", value);
    }

    /// <summary>
    /// Labels associated with this resource.
    /// 
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
    /// The Google Cloud region to which the target Distributed Cloud Edge zone belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// IP (L3) MTU value of the virtual edge cloud. Default value is &#39;1500&#39;. Possible values are: &#39;1500&#39;, &#39;9000&#39;.
    /// </summary>
    public TerraformValue<double>? Mtu
    {
        get => new TerraformReference<double>(this, "mtu");
        set => SetArgument("mtu", value);
    }

    /// <summary>
    /// The ID of the network to which this interconnect attachment belongs.
    /// Must be of the form: &#39;projects/{{project}}/locations/{{location}}/zones/{{zone}}/networks/{{network_id}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
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
    /// VLAN ID provided by user. Must be site-wise unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    public required TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
        set => SetArgument("vlan_id", value);
    }

    /// <summary>
    /// The name of the target Distributed Cloud Edge zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The time when the resource was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The canonical name of this resource, with format
    /// &#39;projects/{{project}}/locations/{{location}}/zones/{{zone}}/interconnectAttachments/{{interconnect_attachment_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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
    /// The time when the resource was last updated.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleEdgenetworkInterconnectAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleEdgenetworkInterconnectAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
