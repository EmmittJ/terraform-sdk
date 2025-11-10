using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub_private_link_resource.
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSource : TerraformDataSource
{
    public AzurermWebPubsubPrivateLinkResourceDataSource(string name) : base("azurerm_web_pubsub_private_link_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("shared_private_link_resource_types");
        SetOutput("id");
        SetOutput("web_pubsub_id");
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
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_pubsub_id");
        set => SetProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    public TerraformExpression SharedPrivateLinkResourceTypes => this["shared_private_link_resource_types"];

}
