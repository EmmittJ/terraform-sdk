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
    public TerraformLiteralProperty<string>? DeadLetterStorageSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dead_letter_storage_secret");
        set => this.WithProperty("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DigitalTwinsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The servicebus_primary_connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicebusPrimaryConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("servicebus_primary_connection_string");
        set => this.WithProperty("servicebus_primary_connection_string", value);
    }

    /// <summary>
    /// The servicebus_secondary_connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicebusSecondaryConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("servicebus_secondary_connection_string");
        set => this.WithProperty("servicebus_secondary_connection_string", value);
    }

}
