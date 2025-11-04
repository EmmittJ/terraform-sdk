using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_digital_twins_endpoint_eventgrid resource.
/// </summary>
public class AzurermDigitalTwinsEndpointEventgrid : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventgrid(string name) : base("azurerm_digital_twins_endpoint_eventgrid", name)
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
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    public string? EventgridTopicEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventgrid_topic_endpoint")?.Value;
        set => this.WithProperty("eventgrid_topic_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    public string? EventgridTopicPrimaryAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventgrid_topic_primary_access_key")?.Value;
        set => this.WithProperty("eventgrid_topic_primary_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    public string? EventgridTopicSecondaryAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventgrid_topic_secondary_access_key")?.Value;
        set => this.WithProperty("eventgrid_topic_secondary_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
