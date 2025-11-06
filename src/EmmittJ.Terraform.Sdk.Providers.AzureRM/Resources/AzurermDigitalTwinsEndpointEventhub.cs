using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_digital_twins_endpoint_eventhub resource.
/// </summary>
public class AzurermDigitalTwinsEndpointEventhub : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventhub(string name) : base("azurerm_digital_twins_endpoint_eventhub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    public string? DeadLetterStorageSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dead_letter_storage_secret")?.Value;
        set => this.WithProperty("dead_letter_storage_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    public string? DigitalTwinsId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("digital_twins_id")?.Value;
        set => this.WithProperty("digital_twins_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    public string? EventhubPrimaryConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_primary_connection_string")?.Value;
        set => this.WithProperty("eventhub_primary_connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    public string? EventhubSecondaryConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_secondary_connection_string")?.Value;
        set => this.WithProperty("eventhub_secondary_connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
