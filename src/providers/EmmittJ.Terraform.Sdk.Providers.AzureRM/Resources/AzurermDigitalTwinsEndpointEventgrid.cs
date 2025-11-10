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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("dead_letter_storage_secret");
        SetOutput("digital_twins_id");
        SetOutput("eventgrid_topic_endpoint");
        SetOutput("eventgrid_topic_primary_access_key");
        SetOutput("eventgrid_topic_secondary_access_key");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    public TerraformProperty<string> DeadLetterStorageSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dead_letter_storage_secret");
        set => SetProperty("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformProperty<string> DigitalTwinsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("digital_twins_id");
        set => SetProperty("digital_twins_id", value);
    }

    /// <summary>
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicEndpoint is required")]
    public required TerraformProperty<string> EventgridTopicEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventgrid_topic_endpoint");
        set => SetProperty("eventgrid_topic_endpoint", value);
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicPrimaryAccessKey is required")]
    public required TerraformProperty<string> EventgridTopicPrimaryAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventgrid_topic_primary_access_key");
        set => SetProperty("eventgrid_topic_primary_access_key", value);
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicSecondaryAccessKey is required")]
    public required TerraformProperty<string> EventgridTopicSecondaryAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventgrid_topic_secondary_access_key");
        set => SetProperty("eventgrid_topic_secondary_access_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDigitalTwinsEndpointEventgridTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
