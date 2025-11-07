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
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? EventgridTopicEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_endpoint");
        set => this.WithProperty("eventgrid_topic_endpoint", value);
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? EventgridTopicPrimaryAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_primary_access_key");
        set => this.WithProperty("eventgrid_topic_primary_access_key", value);
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? EventgridTopicSecondaryAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_secondary_access_key");
        set => this.WithProperty("eventgrid_topic_secondary_access_key", value);
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
