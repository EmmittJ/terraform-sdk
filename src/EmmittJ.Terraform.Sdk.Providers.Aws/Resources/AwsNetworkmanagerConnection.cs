using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_connection resource.
/// </summary>
public class AwsNetworkmanagerConnection : TerraformResource
{
    public AwsNetworkmanagerConnection(string name) : base("aws_networkmanager_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The connected_device_id attribute.
    /// </summary>
    public string? ConnectedDeviceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connected_device_id")?.Value;
        set => this.WithProperty("connected_device_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connected_link_id attribute.
    /// </summary>
    public string? ConnectedLinkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connected_link_id")?.Value;
        set => this.WithProperty("connected_link_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    public string? DeviceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_id")?.Value;
        set => this.WithProperty("device_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public string? GlobalNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_id")?.Value;
        set => this.WithProperty("global_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The link_id attribute.
    /// </summary>
    public string? LinkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("link_id")?.Value;
        set => this.WithProperty("link_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
