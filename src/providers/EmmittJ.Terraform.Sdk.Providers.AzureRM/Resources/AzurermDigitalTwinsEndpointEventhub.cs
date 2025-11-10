using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsEndpointEventhubTimeoutsBlock : TerraformBlock
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
        SetOutput("dead_letter_storage_secret");
        SetOutput("digital_twins_id");
        SetOutput("eventhub_primary_connection_string");
        SetOutput("eventhub_secondary_connection_string");
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
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    public required TerraformProperty<string> EventhubPrimaryConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_primary_connection_string");
        set => SetProperty("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    public required TerraformProperty<string> EventhubSecondaryConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_secondary_connection_string");
        set => SetProperty("eventhub_secondary_connection_string", value);
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
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
