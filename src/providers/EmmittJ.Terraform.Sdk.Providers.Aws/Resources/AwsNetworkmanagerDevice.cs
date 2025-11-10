using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for aws_location in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerDeviceAwsLocationBlock : TerraformBlock
{
    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetArn
    {
        get => GetProperty<TerraformProperty<string>>("subnet_arn");
        set => WithProperty("subnet_arn", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => WithProperty("zone", value);
    }

}

/// <summary>
/// Block type for location in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerDeviceLocationBlock : TerraformBlock
{
    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformProperty<string>? Address
    {
        get => GetProperty<TerraformProperty<string>>("address");
        set => WithProperty("address", value);
    }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    public TerraformProperty<string>? Latitude
    {
        get => GetProperty<TerraformProperty<string>>("latitude");
        set => WithProperty("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    public TerraformProperty<string>? Longitude
    {
        get => GetProperty<TerraformProperty<string>>("longitude");
        set => WithProperty("longitude", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerDeviceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_device resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerDevice : TerraformResource
{
    public AwsNetworkmanagerDevice(string name) : base("aws_networkmanager_device", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("global_network_id");
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
    /// The model attribute.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => this.WithProperty("model", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformProperty<string>? SerialNumber
    {
        get => GetProperty<TerraformProperty<string>>("serial_number");
        set => this.WithProperty("serial_number", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformProperty<string>? SiteId
    {
        get => GetProperty<TerraformProperty<string>>("site_id");
        set => this.WithProperty("site_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformProperty<string>? Vendor
    {
        get => GetProperty<TerraformProperty<string>>("vendor");
        set => this.WithProperty("vendor", value);
    }

    /// <summary>
    /// Block for aws_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLocation block(s) allowed")]
    public List<AwsNetworkmanagerDeviceAwsLocationBlock>? AwsLocation
    {
        get => GetProperty<List<AwsNetworkmanagerDeviceAwsLocationBlock>>("aws_location");
        set => this.WithProperty("aws_location", value);
    }

    /// <summary>
    /// Block for location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public List<AwsNetworkmanagerDeviceLocationBlock>? Location
    {
        get => GetProperty<List<AwsNetworkmanagerDeviceLocationBlock>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerDeviceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerDeviceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
