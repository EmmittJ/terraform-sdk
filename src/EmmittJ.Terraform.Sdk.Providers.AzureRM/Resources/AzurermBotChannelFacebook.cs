using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for page in .
/// Nesting mode: set
/// </summary>
public class AzurermBotChannelFacebookPageBlock : TerraformBlock
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessToken is required")]
    public required TerraformProperty<string> AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => WithProperty("access_token", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelFacebookTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_bot_channel_facebook resource.
/// </summary>
public class AzurermBotChannelFacebook : TerraformResource
{
    public AzurermBotChannelFacebook(string name) : base("azurerm_bot_channel_facebook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetProperty<TerraformProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The facebook_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FacebookApplicationId is required")]
    public required TerraformProperty<string> FacebookApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("facebook_application_id");
        set => this.WithProperty("facebook_application_id", value);
    }

    /// <summary>
    /// The facebook_application_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FacebookApplicationSecret is required")]
    public required TerraformProperty<string> FacebookApplicationSecret
    {
        get => GetProperty<TerraformProperty<string>>("facebook_application_secret");
        set => this.WithProperty("facebook_application_secret", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for page.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Page block(s) required")]
    public HashSet<AzurermBotChannelFacebookPageBlock>? Page
    {
        get => GetProperty<HashSet<AzurermBotChannelFacebookPageBlock>>("page");
        set => this.WithProperty("page", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelFacebookTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBotChannelFacebookTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
