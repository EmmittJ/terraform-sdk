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
        set => SetProperty("subnet_arn", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        set => SetProperty("zone", value);
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
        set => SetProperty("address", value);
    }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    public TerraformProperty<string>? Latitude
    {
        set => SetProperty("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    public TerraformProperty<string>? Longitude
    {
        set => SetProperty("longitude", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("model");
        SetOutput("serial_number");
        SetOutput("site_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
        SetOutput("vendor");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The model attribute.
    /// </summary>
    public TerraformProperty<string> Model
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model");
        set => SetProperty("model", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformProperty<string> SerialNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("serial_number");
        set => SetProperty("serial_number", value);
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformProperty<string> SiteId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("site_id");
        set => SetProperty("site_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformProperty<string> Vendor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vendor");
        set => SetProperty("vendor", value);
    }

    /// <summary>
    /// Block for aws_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLocation block(s) allowed")]
    public List<AwsNetworkmanagerDeviceAwsLocationBlock>? AwsLocation
    {
        set => SetProperty("aws_location", value);
    }

    /// <summary>
    /// Block for location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public List<AwsNetworkmanagerDeviceLocationBlock>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerDeviceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
