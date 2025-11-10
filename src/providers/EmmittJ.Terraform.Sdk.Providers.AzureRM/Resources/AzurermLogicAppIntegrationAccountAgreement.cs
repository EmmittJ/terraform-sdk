using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for guest_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountAgreementGuestIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    public required TerraformProperty<string> Qualifier
    {
        set => SetProperty("qualifier", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for host_identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountAgreementHostIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    public required TerraformProperty<string> Qualifier
    {
        set => SetProperty("qualifier", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountAgreementTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_integration_account_agreement resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppIntegrationAccountAgreement : TerraformResource
{
    public AzurermLogicAppIntegrationAccountAgreement(string name) : base("azurerm_logic_app_integration_account_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("agreement_type");
        SetOutput("content");
        SetOutput("guest_partner_name");
        SetOutput("host_partner_name");
        SetOutput("id");
        SetOutput("integration_account_name");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The agreement_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgreementType is required")]
    public required TerraformProperty<string> AgreementType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agreement_type");
        set => SetProperty("agreement_type", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content");
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The guest_partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestPartnerName is required")]
    public required TerraformProperty<string> GuestPartnerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("guest_partner_name");
        set => SetProperty("guest_partner_name", value);
    }

    /// <summary>
    /// The host_partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostPartnerName is required")]
    public required TerraformProperty<string> HostPartnerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_partner_name");
        set => SetProperty("host_partner_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformProperty<string> IntegrationAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_account_name");
        set => SetProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for guest_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GuestIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GuestIdentity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GuestIdentity block(s) allowed")]
    public List<AzurermLogicAppIntegrationAccountAgreementGuestIdentityBlock>? GuestIdentity
    {
        set => SetProperty("guest_identity", value);
    }

    /// <summary>
    /// Block for host_identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HostIdentity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostIdentity block(s) allowed")]
    public List<AzurermLogicAppIntegrationAccountAgreementHostIdentityBlock>? HostIdentity
    {
        set => SetProperty("host_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppIntegrationAccountAgreementTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
