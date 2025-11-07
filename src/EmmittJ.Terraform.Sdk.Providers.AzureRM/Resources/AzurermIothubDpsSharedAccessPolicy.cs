using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<bool>? EnrollmentRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enrollment_read");
        set => this.WithProperty("enrollment_read", value);
    }

    /// <summary>
    /// The enrollment_write attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnrollmentWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enrollment_write");
        set => this.WithProperty("enrollment_write", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The iothub_dps_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubDpsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_dps_name");
        set => this.WithProperty("iothub_dps_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registration_read attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RegistrationRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registration_read");
        set => this.WithProperty("registration_read", value);
    }

    /// <summary>
    /// The registration_write attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RegistrationWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registration_write");
        set => this.WithProperty("registration_write", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_config attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ServiceConfig
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_config");
        set => this.WithProperty("service_config", value);
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
