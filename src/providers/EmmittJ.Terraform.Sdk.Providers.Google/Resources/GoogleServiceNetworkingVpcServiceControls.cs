using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleServiceNetworkingVpcServiceControls.
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingVpcServiceControlsTimeoutsBlock : TerraformBlock
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
/// Represents a google_service_networking_vpc_service_controls Terraform resource.
/// Manages a google_service_networking_vpc_service_controls resource.
/// </summary>
public partial class GoogleServiceNetworkingVpcServiceControls(string name) : TerraformResource("google_service_networking_vpc_service_controls", name)
{
    /// <summary>
    /// Desired VPC Service Controls state service producer VPC network, as
    /// described at the top of this page.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The network that the consumer is using to connect with services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The id of the Google Cloud project containing the consumer network.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service that is managing peering connectivity for a service
    /// producer&#39;s organization. For Google services that support this
    /// functionality, this value is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleServiceNetworkingVpcServiceControlsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleServiceNetworkingVpcServiceControlsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
