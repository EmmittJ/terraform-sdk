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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_key");
    }

    /// <summary>
    /// The enrollment_read attribute.
    /// </summary>
    public TerraformProperty<bool>? EnrollmentRead
    {
        get => GetProperty<TerraformProperty<bool>>("enrollment_read");
        set => this.WithProperty("enrollment_read", value);
    }

    /// <summary>
    /// The enrollment_write attribute.
    /// </summary>
    public TerraformProperty<bool>? EnrollmentWrite
    {
        get => GetProperty<TerraformProperty<bool>>("enrollment_write");
        set => this.WithProperty("enrollment_write", value);
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
    /// The iothub_dps_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubDpsName is required")]
    public required TerraformProperty<string> IothubDpsName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iothub_dps_name");
        set => this.WithProperty("iothub_dps_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registration_read attribute.
    /// </summary>
    public TerraformProperty<bool>? RegistrationRead
    {
        get => GetProperty<TerraformProperty<bool>>("registration_read");
        set => this.WithProperty("registration_read", value);
    }

    /// <summary>
    /// The registration_write attribute.
    /// </summary>
    public TerraformProperty<bool>? RegistrationWrite
    {
        get => GetProperty<TerraformProperty<bool>>("registration_write");
        set => this.WithProperty("registration_write", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_config attribute.
    /// </summary>
    public TerraformProperty<bool>? ServiceConfig
    {
        get => GetProperty<TerraformProperty<bool>>("service_config");
        set => this.WithProperty("service_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubDpsSharedAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIothubDpsSharedAccessPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
