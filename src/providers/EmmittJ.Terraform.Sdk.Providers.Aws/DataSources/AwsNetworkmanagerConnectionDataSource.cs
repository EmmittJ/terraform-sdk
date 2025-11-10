using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_connection.
/// </summary>
public class AwsNetworkmanagerConnectionDataSource : TerraformDataSource
{
    public AwsNetworkmanagerConnectionDataSource(string name) : base("aws_networkmanager_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("connected_device_id");
        SetOutput("connected_link_id");
        SetOutput("description");
        SetOutput("device_id");
        SetOutput("link_id");
        SetOutput("connection_id");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("tags");
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_network_id");
        set => SetProperty("global_network_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    public TerraformExpression ConnectedDeviceId => this["connected_device_id"];

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    public TerraformExpression ConnectedLinkId => this["connected_link_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public TerraformExpression DeviceId => this["device_id"];

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformExpression LinkId => this["link_id"];

}
