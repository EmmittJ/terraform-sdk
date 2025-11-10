using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubSharedAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_shared_access_policy resource.
/// </summary>
public class AzurermIothubSharedAccessPolicy : TerraformResource
{
    public AzurermIothubSharedAccessPolicy(string name) : base("azurerm_iothub_shared_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_connection_string");
        SetOutput("primary_key");
        SetOutput("secondary_connection_string");
        SetOutput("secondary_key");
        SetOutput("device_connect");
        SetOutput("id");
        SetOutput("iothub_name");
        SetOutput("name");
        SetOutput("registry_read");
        SetOutput("registry_write");
        SetOutput("resource_group_name");
        SetOutput("service_connect");
    }

    /// <summary>
    /// The device_connect attribute.
    /// </summary>
    public TerraformProperty<bool> DeviceConnect
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("device_connect");
        set => SetProperty("device_connect", value);
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
    /// The iothub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubName is required")]
    public required TerraformProperty<string> IothubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_name");
        set => SetProperty("iothub_name", value);
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
    /// The registry_read attribute.
    /// </summary>
    public TerraformProperty<bool> RegistryRead
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registry_read");
        set => SetProperty("registry_read", value);
    }

    /// <summary>
    /// The registry_write attribute.
    /// </summary>
    public TerraformProperty<bool> RegistryWrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registry_write");
        set => SetProperty("registry_write", value);
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
    /// The service_connect attribute.
    /// </summary>
    public TerraformProperty<bool> ServiceConnect
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("service_connect");
        set => SetProperty("service_connect", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubSharedAccessPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
