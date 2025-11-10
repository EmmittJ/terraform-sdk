using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attachments in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupAttachmentsBlock : ITerraformBlock
{
    /// <summary>
    /// The attachment attribute.
    /// </summary>
    [TerraformPropertyName("attachment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Attachment { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for intent in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupIntentBlock : ITerraformBlock
{
    /// <summary>
    /// Which SLA the user intends this group to support. Possible values: [&amp;quot;PRODUCTION_NON_CRITICAL&amp;quot;, &amp;quot;PRODUCTION_CRITICAL&amp;quot;, &amp;quot;NO_SLA&amp;quot;, &amp;quot;AVAILABILITY_SLA_UNSPECIFIED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("availability_sla")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AvailabilitySla { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectAttachmentGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_interconnect_attachment_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInterconnectAttachmentGroup : TerraformResource
{
    public GoogleComputeInterconnectAttachmentGroup(string name) : base("google_compute_interconnect_attachment_group", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The URL of an InterconnectGroup that groups these Attachments&#39;
    /// Interconnects. Customers do not need to set this unless directed by
    /// Google Support.
    /// </summary>
    [TerraformPropertyName("interconnect_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InterconnectGroup { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for attachments.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("attachments")]
    public TerraformSet<TerraformBlock<GoogleComputeInterconnectAttachmentGroupAttachmentsBlock>>? Attachments { get; set; } = new();

    /// <summary>
    /// Block for intent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Intent block(s) allowed")]
    [TerraformPropertyName("intent")]
    public TerraformList<TerraformBlock<GoogleComputeInterconnectAttachmentGroupIntentBlock>>? Intent { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeInterconnectAttachmentGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The redundancy this group is configured to support. The way a
    /// user queries what SLA their Attachment gets is by looking at this field of
    /// the Attachment&#39;s AttachmentGroup.
    /// </summary>
    [TerraformPropertyName("configured")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Configured => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "configured");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// An analysis of the logical layout of Attachments in this
    /// group. Every Attachment in the group is shown once in this structure.
    /// </summary>
    [TerraformPropertyName("logical_structure")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LogicalStructure => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logical_structure");

}
