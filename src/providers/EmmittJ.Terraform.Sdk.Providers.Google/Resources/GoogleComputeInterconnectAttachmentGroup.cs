using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attachments in GoogleComputeInterconnectAttachmentGroup.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachments";

    /// <summary>
    /// The attachment attribute.
    /// </summary>
    public TerraformValue<string>? Attachment
    {
        get => new TerraformReference<string>(this, "attachment");
        set => SetArgument("attachment", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for intent in GoogleComputeInterconnectAttachmentGroup.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupIntentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intent";

    /// <summary>
    /// Which SLA the user intends this group to support. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AvailabilitySla
    {
        get => new TerraformReference<string>(this, "availability_sla");
        set => SetArgument("availability_sla", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInterconnectAttachmentGroup.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_interconnect_attachment_group Terraform resource.
/// Manages a google_compute_interconnect_attachment_group resource.
/// </summary>
public partial class GoogleComputeInterconnectAttachmentGroup(string name) : TerraformResource("google_compute_interconnect_attachment_group", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
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
    /// The URL of an InterconnectGroup that groups these Attachments&#39;
    /// Interconnects. Customers do not need to set this unless directed by
    /// Google Support.
    /// </summary>
    public TerraformValue<string>? InterconnectGroup
    {
        get => new TerraformReference<string>(this, "interconnect_group");
        set => SetArgument("interconnect_group", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The redundancy this group is configured to support. The way a
    /// user queries what SLA their Attachment gets is by looking at this field of
    /// the Attachment&#39;s AttachmentGroup.
    /// </summary>
    public TerraformList<TerraformMap<object>> Configured
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "configured").ResolveNodes(ctx));
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// An analysis of the logical layout of Attachments in this
    /// group. Every Attachment in the group is shown once in this structure.
    /// </summary>
    public TerraformList<TerraformMap<object>> LogicalStructure
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logical_structure").ResolveNodes(ctx));
    }

    /// <summary>
    /// Attachments block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInterconnectAttachmentGroupAttachmentsBlock>? Attachments
    {
        get => GetArgument<TerraformSet<GoogleComputeInterconnectAttachmentGroupAttachmentsBlock>>("attachments");
        set => SetArgument("attachments", value);
    }

    /// <summary>
    /// Intent block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    public required TerraformList<GoogleComputeInterconnectAttachmentGroupIntentBlock> Intent
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInterconnectAttachmentGroupIntentBlock>>("intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInterconnectAttachmentGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInterconnectAttachmentGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
