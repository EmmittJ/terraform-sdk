using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeDiskResourcePolicyAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleComputeDiskResourcePolicyAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_disk_resource_policy_attachment Terraform resource.
/// Manages a google_compute_disk_resource_policy_attachment resource.
/// </summary>
public partial class GoogleComputeDiskResourcePolicyAttachment(string name) : TerraformResource("google_compute_disk_resource_policy_attachment", name)
{
    /// <summary>
    /// The name of the disk in which the resource policies are attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformValue<string> Disk
    {
        get => new TerraformReference<string>(this, "disk");
        set => SetArgument("disk", value);
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
    /// The resource policy to be attached to the disk for scheduling snapshot
    /// creation. Do not specify the self link.
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
    /// A reference to the zone where the disk resides.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeDiskResourcePolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeDiskResourcePolicyAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
