using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_digital_twins_endpoint_servicebus resource.
/// </summary>
public class AzurermDigitalTwinsEndpointServicebus : TerraformResource
{
    public AzurermDigitalTwinsEndpointServicebus(string name) : base("azurerm_digital_twins_endpoint_servicebus", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    public TerraformProperty<string>? DeadLetterStorageSecret
    {
        get => GetProperty<TerraformProperty<string>>("dead_letter_storage_secret");
        set => this.WithProperty("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    public TerraformProperty<string>? DigitalTwinsId
    {
        get => GetProperty<TerraformProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The servicebus_primary_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ServicebusPrimaryConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("servicebus_primary_connection_string");
        set => this.WithProperty("servicebus_primary_connection_string", value);
    }

    /// <summary>
    /// The servicebus_secondary_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ServicebusSecondaryConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("servicebus_secondary_connection_string");
        set => this.WithProperty("servicebus_secondary_connection_string", value);
    }

}
