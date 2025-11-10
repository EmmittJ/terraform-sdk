using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_netapp_pool resource.
/// </summary>
public class AzurermNetappPool : TerraformResource
{
    public AzurermNetappPool(string name) : base("azurerm_netapp_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_name");
        SetOutput("cool_access_enabled");
        SetOutput("custom_throughput_mibps");
        SetOutput("encryption_type");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("qos_type");
        SetOutput("resource_group_name");
        SetOutput("service_level");
        SetOutput("size_in_tb");
        SetOutput("tags");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CoolAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cool_access_enabled");
        set => SetProperty("cool_access_enabled", value);
    }

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    public TerraformProperty<double> CustomThroughputMibps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("custom_throughput_mibps");
        set => SetProperty("custom_throughput_mibps", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_type");
        set => SetProperty("encryption_type", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The qos_type attribute.
    /// </summary>
    public TerraformProperty<string> QosType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qos_type");
        set => SetProperty("qos_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformProperty<string> ServiceLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_level");
        set => SetProperty("service_level", value);
    }

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInTb is required")]
    public required TerraformProperty<double> SizeInTb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size_in_tb");
        set => SetProperty("size_in_tb", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
