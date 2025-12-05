using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_networkmanager_device Terraform data source.
/// Retrieves information about a aws_networkmanager_device.
/// </summary>
public partial class AwsNetworkmanagerDeviceDataSource(string name) : TerraformDataSource("aws_networkmanager_device", name)
{
    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformValue<string> DeviceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_id");
        set => SetArgument("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The aws_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AwsLocation
        => CreateReference("aws_location");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Location
        => CreateReference("location");

    /// <summary>
    /// The model attribute.
    /// </summary>
    public TerraformValue<string> Model
        => CreateReference("model");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<string> SerialNumber
        => CreateReference("serial_number");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string> SiteId
        => CreateReference("site_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformValue<string> Vendor
        => CreateReference("vendor");

}
