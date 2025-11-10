using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionDiskResourcePolicyAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_region_disk_resource_policy_attachment resource.
/// </summary>
public class GoogleComputeRegionDiskResourcePolicyAttachment : TerraformResource
{
    public GoogleComputeRegionDiskResourcePolicyAttachment(string name) : base("google_compute_region_disk_resource_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disk");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The name of the regional disk in which the resource policies are attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformProperty<string> Disk
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk");
        set => SetProperty("disk", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The resource policy to be attached to the disk for scheduling snapshot
    /// creation. Do not specify the self link.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// A reference to the region where the disk resides.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionDiskResourcePolicyAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
