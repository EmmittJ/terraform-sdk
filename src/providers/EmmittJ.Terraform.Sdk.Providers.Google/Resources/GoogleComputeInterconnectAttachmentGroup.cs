using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attachments in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// The attachment attribute.
    /// </summary>
    public TerraformProperty<string>? Attachment
    {
        get => GetProperty<TerraformProperty<string>>("attachment");
        set => WithProperty("attachment", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for intent in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupIntentBlock : TerraformBlock
{
    /// <summary>
    /// Which SLA the user intends this group to support. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AvailabilitySla
    {
        get => GetProperty<TerraformProperty<string>>("availability_sla");
        set => WithProperty("availability_sla", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_interconnect_attachment_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInterconnectAttachmentGroup : TerraformResource
{
    public GoogleComputeInterconnectAttachmentGroup(string name) : base("google_compute_interconnect_attachment_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("configured");
        this.WithOutput("creation_timestamp");
        this.WithOutput("logical_structure");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The URL of an InterconnectGroup that groups these Attachments&#39;
    /// Interconnects. Customers do not need to set this unless directed by
    /// Google Support.
    /// </summary>
    public TerraformProperty<string>? InterconnectGroup
    {
        get => GetProperty<TerraformProperty<string>>("interconnect_group");
        set => this.WithProperty("interconnect_group", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for attachments.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeInterconnectAttachmentGroupAttachmentsBlock>? Attachments
    {
        get => GetProperty<HashSet<GoogleComputeInterconnectAttachmentGroupAttachmentsBlock>>("attachments");
        set => this.WithProperty("attachments", value);
    }

    /// <summary>
    /// Block for intent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    public List<GoogleComputeInterconnectAttachmentGroupIntentBlock>? Intent
    {
        get => GetProperty<List<GoogleComputeInterconnectAttachmentGroupIntentBlock>>("intent");
        set => this.WithProperty("intent", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInterconnectAttachmentGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInterconnectAttachmentGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The redundancy this group is configured to support. The way a
    /// user queries what SLA their Attachment gets is by looking at this field of
    /// the Attachment&#39;s AttachmentGroup.
    /// </summary>
    public TerraformExpression Configured => this["configured"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An analysis of the logical layout of Attachments in this
    /// group. Every Attachment in the group is shown once in this structure.
    /// </summary>
    public TerraformExpression LogicalStructure => this["logical_structure"];

}
