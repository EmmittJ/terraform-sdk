using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsSharedAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_dps_shared_access_policy resource.
/// </summary>
public class AzurermIothubDpsSharedAccessPolicy : TerraformResource
{
    public AzurermIothubDpsSharedAccessPolicy(string name) : base("azurerm_iothub_dps_shared_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("primary_connection_string");
        SetOutput("primary_key");
        SetOutput("secondary_connection_string");
        SetOutput("secondary_key");
        SetOutput("enrollment_read");
        SetOutput("enrollment_write");
        SetOutput("id");
        SetOutput("iothub_dps_name");
        SetOutput("name");
        SetOutput("registration_read");
        SetOutput("registration_write");
        SetOutput("resource_group_name");
        SetOutput("service_config");
    }

    /// <summary>
    /// The enrollment_read attribute.
    /// </summary>
    public TerraformProperty<bool> EnrollmentRead
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enrollment_read");
        set => SetProperty("enrollment_read", value);
    }

    /// <summary>
    /// The enrollment_write attribute.
    /// </summary>
    public TerraformProperty<bool> EnrollmentWrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enrollment_write");
        set => SetProperty("enrollment_write", value);
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
    /// The iothub_dps_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubDpsName is required")]
    public required TerraformProperty<string> IothubDpsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_dps_name");
        set => SetProperty("iothub_dps_name", value);
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
    /// The registration_read attribute.
    /// </summary>
    public TerraformProperty<bool> RegistrationRead
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registration_read");
        set => SetProperty("registration_read", value);
    }

    /// <summary>
    /// The registration_write attribute.
    /// </summary>
    public TerraformProperty<bool> RegistrationWrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registration_write");
        set => SetProperty("registration_write", value);
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
    /// The service_config attribute.
    /// </summary>
    public TerraformProperty<bool> ServiceConfig
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("service_config");
        set => SetProperty("service_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubDpsSharedAccessPolicyTimeoutsBlock? Timeouts
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
