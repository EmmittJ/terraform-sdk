using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelSlackTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bot_channel_slack resource.
/// </summary>
public class AzurermBotChannelSlack : TerraformResource
{
    public AzurermBotChannelSlack(string name) : base("azurerm_bot_channel_slack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bot_name");
        SetOutput("client_id");
        SetOutput("client_secret");
        SetOutput("id");
        SetOutput("landing_page_url");
        SetOutput("location");
        SetOutput("resource_group_name");
        SetOutput("signing_secret");
        SetOutput("verification_token");
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bot_name");
        set => SetProperty("bot_name", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
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
    /// The landing_page_url attribute.
    /// </summary>
    public TerraformProperty<string> LandingPageUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("landing_page_url");
        set => SetProperty("landing_page_url", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The signing_secret attribute.
    /// </summary>
    public TerraformProperty<string> SigningSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("signing_secret");
        set => SetProperty("signing_secret", value);
    }

    /// <summary>
    /// The verification_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerificationToken is required")]
    public required TerraformProperty<string> VerificationToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verification_token");
        set => SetProperty("verification_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelSlackTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
