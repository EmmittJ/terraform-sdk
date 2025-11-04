using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkmanager_device.
/// </summary>
public class AwsNetworkmanagerDeviceDataSource : TerraformDataSource
{
    public AwsNetworkmanagerDeviceDataSource(string name) : base("aws_networkmanager_device", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_location");
        this.DeclareOutput("description");
        this.DeclareOutput("location");
        this.DeclareOutput("model");
        this.DeclareOutput("serial_number");
        this.DeclareOutput("site_id");
        this.DeclareOutput("type");
        this.DeclareOutput("vendor");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_location attribute.
    /// </summary>
    public TerraformExpression AwsLocation => this["aws_location"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The model attribute.
    /// </summary>
    public TerraformExpression Model => this["model"];

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformExpression SerialNumber => this["serial_number"];

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformExpression SiteId => this["site_id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformExpression Vendor => this["vendor"];

}
