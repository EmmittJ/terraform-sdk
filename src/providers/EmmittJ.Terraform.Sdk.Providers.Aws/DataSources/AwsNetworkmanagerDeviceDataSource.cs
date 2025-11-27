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
        get => new TerraformReference<string>(this, "device_id");
        set => SetArgument("device_id", value);
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
    /// The aws_location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AwsLocation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "aws_location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Location
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "location").ResolveNodes(ctx));
    }

    /// <summary>
    /// The model attribute.
    /// </summary>
    public TerraformValue<string> Model
    {
        get => new TerraformReference<string>(this, "model");
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<string> SerialNumber
    {
        get => new TerraformReference<string>(this, "serial_number");
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string> SiteId
    {
        get => new TerraformReference<string>(this, "site_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformValue<string> Vendor
    {
        get => new TerraformReference<string>(this, "vendor");
    }

}
