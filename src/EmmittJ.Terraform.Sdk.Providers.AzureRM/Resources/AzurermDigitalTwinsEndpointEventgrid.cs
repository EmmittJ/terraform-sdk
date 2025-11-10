using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsEndpointEventgridTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformProperty<string> DigitalTwinsId
    {
        get => GetProperty<TerraformProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
    }

    /// <summary>
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicEndpoint is required")]
    public required TerraformProperty<string> EventgridTopicEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_endpoint");
        set => this.WithProperty("eventgrid_topic_endpoint", value);
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicPrimaryAccessKey is required")]
    public required TerraformProperty<string> EventgridTopicPrimaryAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("eventgrid_topic_primary_access_key");
        set => this.WithProperty("eventgrid_topic_primary_access_key", value);
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicSecondaryAccessKey is required")]
    public required TerraformProperty<string> EventgridTopicSecondaryAccessKey
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDigitalTwinsEndpointEventgridTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDigitalTwinsEndpointEventgridTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
