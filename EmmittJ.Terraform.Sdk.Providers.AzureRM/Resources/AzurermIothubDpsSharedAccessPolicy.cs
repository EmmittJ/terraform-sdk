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
    public bool? EnrollmentRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enrollment_read")?.Value;
        set => this.WithProperty("enrollment_read", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enrollment_write attribute.
    /// </summary>
    public bool? EnrollmentWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enrollment_write")?.Value;
        set => this.WithProperty("enrollment_write", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iothub_dps_name attribute.
    /// </summary>
    public string? IothubDpsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_dps_name")?.Value;
        set => this.WithProperty("iothub_dps_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registration_read attribute.
    /// </summary>
    public bool? RegistrationRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registration_read")?.Value;
        set => this.WithProperty("registration_read", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The registration_write attribute.
    /// </summary>
    public bool? RegistrationWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registration_write")?.Value;
        set => this.WithProperty("registration_write", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_config attribute.
    /// </summary>
    public bool? ServiceConfig
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_config")?.Value;
        set => this.WithProperty("service_config", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
