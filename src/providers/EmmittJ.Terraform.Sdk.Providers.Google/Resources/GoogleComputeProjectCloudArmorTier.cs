using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeProjectCloudArmorTier.
/// Nesting mode: single
/// </summary>
public class GoogleComputeProjectCloudArmorTierTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_project_cloud_armor_tier Terraform resource.
/// Manages a google_compute_project_cloud_armor_tier resource.
/// </summary>
public partial class GoogleComputeProjectCloudArmorTier(string name) : TerraformResource("google_compute_project_cloud_armor_tier", name)
{
    /// <summary>
    /// Managed protection tier to be set. Possible values: [&amp;quot;CA_STANDARD&amp;quot;, &amp;quot;CA_ENTERPRISE_PAYGO&amp;quot;, &amp;quot;CA_ENTERPRISE_ANNUAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudArmorTier is required")]
    public required TerraformValue<string> CloudArmorTier
    {
        get => new TerraformReference<string>(this, "cloud_armor_tier");
        set => SetArgument("cloud_armor_tier", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeProjectCloudArmorTierTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeProjectCloudArmorTierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
