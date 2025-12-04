using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIapTunnelDestGroup.
/// Nesting mode: single
/// </summary>
public class GoogleIapTunnelDestGroupTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iap_tunnel_dest_group Terraform resource.
/// Manages a google_iap_tunnel_dest_group resource.
/// </summary>
public partial class GoogleIapTunnelDestGroup(string name) : TerraformResource("google_iap_tunnel_dest_group", name)
{
    /// <summary>
    /// List of CIDRs that this group applies to.
    /// </summary>
    public TerraformList<string>? Cidrs
    {
        get => GetArgument<TerraformList<string>>("cidrs");
        set => SetArgument("cidrs", value);
    }

    /// <summary>
    /// List of FQDNs that this group applies to.
    /// </summary>
    public TerraformList<string>? Fqdns
    {
        get => GetArgument<TerraformList<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// Unique tunnel destination group name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => GetArgument<TerraformValue<string>>("group_name");
        set => SetArgument("group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the tunnel group. Must be the same as the network resources in the group.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Full resource name.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIapTunnelDestGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIapTunnelDestGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
