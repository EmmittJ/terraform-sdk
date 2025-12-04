using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerConnection.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a aws_networkmanager_connection Terraform resource.
/// Manages a aws_networkmanager_connection resource.
/// </summary>
public partial class AwsNetworkmanagerConnection(string name) : TerraformResource("aws_networkmanager_connection", name)
{
    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectedDeviceId is required")]
    public required TerraformValue<string> ConnectedDeviceId
    {
        get => GetArgument<TerraformValue<string>>("connected_device_id");
        set => SetArgument("connected_device_id", value);
    }

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    public TerraformValue<string>? ConnectedLinkId
    {
        get => GetArgument<TerraformValue<string>>("connected_link_id");
        set => SetArgument("connected_link_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformValue<string> DeviceId
    {
        get => GetArgument<TerraformValue<string>>("device_id");
        set => SetArgument("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
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
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string>? LinkId
    {
        get => GetArgument<TerraformValue<string>>("link_id");
        set => SetArgument("link_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
