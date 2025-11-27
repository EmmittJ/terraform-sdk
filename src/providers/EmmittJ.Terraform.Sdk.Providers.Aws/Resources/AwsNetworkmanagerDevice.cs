using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aws_location in AwsNetworkmanagerDevice.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerDeviceAwsLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_location";

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformValue<string>? SubnetArn
    {
        get => new TerraformReference<string>(this, "subnet_arn");
        set => SetArgument("subnet_arn", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

}


/// <summary>
/// Block type for location in AwsNetworkmanagerDevice.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerDeviceLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location";

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string>? Address
    {
        get => new TerraformReference<string>(this, "address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    public TerraformValue<string>? Latitude
    {
        get => new TerraformReference<string>(this, "latitude");
        set => SetArgument("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    public TerraformValue<string>? Longitude
    {
        get => new TerraformReference<string>(this, "longitude");
        set => SetArgument("longitude", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkmanagerDevice.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerDeviceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_networkmanager_device Terraform resource.
/// Manages a aws_networkmanager_device resource.
/// </summary>
public partial class AwsNetworkmanagerDevice(string name) : TerraformResource("aws_networkmanager_device", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The model attribute.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => new TerraformReference<string>(this, "model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<string>? SerialNumber
    {
        get => new TerraformReference<string>(this, "serial_number");
        set => SetArgument("serial_number", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string>? SiteId
    {
        get => new TerraformReference<string>(this, "site_id");
        set => SetArgument("site_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformValue<string>? Vendor
    {
        get => new TerraformReference<string>(this, "vendor");
        set => SetArgument("vendor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// AwsLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLocation block(s) allowed")]
    public TerraformList<AwsNetworkmanagerDeviceAwsLocationBlock>? AwsLocation
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerDeviceAwsLocationBlock>>("aws_location");
        set => SetArgument("aws_location", value);
    }

    /// <summary>
    /// Location block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public TerraformList<AwsNetworkmanagerDeviceLocationBlock>? Location
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerDeviceLocationBlock>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerDeviceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerDeviceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
