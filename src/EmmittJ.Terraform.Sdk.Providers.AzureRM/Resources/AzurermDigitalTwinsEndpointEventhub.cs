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
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubPrimaryConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_primary_connection_string");
        set => this.WithProperty("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubSecondaryConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_secondary_connection_string");
        set => this.WithProperty("eventhub_secondary_connection_string", value);
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

}
