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
        this.DeclareOutput("arn");
        this.DeclareOutput("connected_device_id");
        this.DeclareOutput("connected_link_id");
        this.DeclareOutput("description");
        this.DeclareOutput("device_id");
        this.DeclareOutput("link_id");
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
