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
        SetOutput("arn");
        SetOutput("aws_location");
        SetOutput("description");
        SetOutput("location");
        SetOutput("model");
        SetOutput("serial_number");
        SetOutput("site_id");
        SetOutput("type");
        SetOutput("vendor");
        SetOutput("device_id");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("tags");
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformProperty<string> DeviceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_id");
        set => SetProperty("device_id", value);
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
