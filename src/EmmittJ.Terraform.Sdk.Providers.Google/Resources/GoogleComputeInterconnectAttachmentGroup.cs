using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_interconnect_attachment_group resource.
/// </summary>
public class GoogleComputeInterconnectAttachmentGroup : TerraformResource
{
    public GoogleComputeInterconnectAttachmentGroup(string name) : base("google_compute_interconnect_attachment_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("configured");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("logical_structure");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The URL of an InterconnectGroup that groups these Attachments&#39;
    /// Interconnects. Customers do not need to set this unless directed by
    /// Google Support.
    /// </summary>
    public string? InterconnectGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interconnect_group")?.Value;
        set => this.WithProperty("interconnect_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
