using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubFileUploadTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_file_upload resource.
/// </summary>
public class AzurermIothubFileUpload : TerraformResource
{
    public AzurermIothubFileUpload(string name) : base("azurerm_iothub_file_upload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication_type");
        SetOutput("connection_string");
        SetOutput("container_name");
        SetOutput("default_ttl");
        SetOutput("id");
        SetOutput("identity_id");
        SetOutput("iothub_id");
        SetOutput("lock_duration");
        SetOutput("max_delivery_count");
        SetOutput("notifications_enabled");
        SetOutput("sas_ttl");
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_name");
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<string> DefaultTtl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_ttl");
        set => SetProperty("default_ttl", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformProperty<string> IothubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_id");
        set => SetProperty("iothub_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string> LockDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lock_duration");
        set => SetProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double> MaxDeliveryCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_delivery_count");
        set => SetProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> NotificationsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("notifications_enabled");
        set => SetProperty("notifications_enabled", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformProperty<string> SasTtl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sas_ttl");
        set => SetProperty("sas_ttl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubFileUploadTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
