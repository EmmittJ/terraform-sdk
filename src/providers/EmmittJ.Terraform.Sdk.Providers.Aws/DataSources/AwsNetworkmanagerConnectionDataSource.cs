using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_networkmanager_connection Terraform data source.
/// Retrieves information about a aws_networkmanager_connection.
/// </summary>
public partial class AwsNetworkmanagerConnectionDataSource(string name) : TerraformDataSource("aws_networkmanager_connection", name)
{
    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => new TerraformReference<string>(this, "global_network_id");
        set => SetArgument("global_network_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectedDeviceId
    {
        get => new TerraformReference<string>(this, "connected_device_id");
    }

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    public TerraformValue<string> ConnectedLinkId
    {
        get => new TerraformReference<string>(this, "connected_link_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public TerraformValue<string> DeviceId
    {
        get => new TerraformReference<string>(this, "device_id");
    }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string> LinkId
    {
        get => new TerraformReference<string>(this, "link_id");
    }

}
