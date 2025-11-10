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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformProperty<string> DigitalTwinsId
    {
        get => GetProperty<TerraformProperty<string>>("digital_twins_id");
        set => this.WithProperty("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    public required TerraformProperty<string> EventhubPrimaryConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_primary_connection_string");
        set => this.WithProperty("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    public required TerraformProperty<string> EventhubSecondaryConnectionString
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
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDigitalTwinsEndpointEventhubTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
