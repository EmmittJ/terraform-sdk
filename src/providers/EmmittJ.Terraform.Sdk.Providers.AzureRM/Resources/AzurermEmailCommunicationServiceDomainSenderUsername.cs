using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEmailCommunicationServiceDomainSenderUsernameTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_email_communication_service_domain_sender_username resource.
/// </summary>
public class AzurermEmailCommunicationServiceDomainSenderUsername : TerraformResource
{
    public AzurermEmailCommunicationServiceDomainSenderUsername(string name) : base("azurerm_email_communication_service_domain_sender_username", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("email_service_domain_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The email_service_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailServiceDomainId is required")]
    public required TerraformProperty<string> EmailServiceDomainId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_service_domain_id");
        set => SetProperty("email_service_domain_id", value);
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
    public AzurermEmailCommunicationServiceDomainSenderUsernameTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
