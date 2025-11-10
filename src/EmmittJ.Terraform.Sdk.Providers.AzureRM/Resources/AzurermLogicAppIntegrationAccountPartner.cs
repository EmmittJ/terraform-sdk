using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for business_identity in .
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    public required TerraformProperty<string> Qualifier
    {
        get => GetProperty<TerraformProperty<string>>("qualifier");
        set => WithProperty("qualifier", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_integration_account_partner resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountPartner : TerraformResource
{
    public AzurermLogicAppIntegrationAccountPartner(string name) : base("azurerm_logic_app_integration_account_partner", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformProperty<string> IntegrationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformProperty<string>? Metadata
    {
        get => GetProperty<TerraformProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for business_identity.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BusinessIdentity block(s) required")]
    public HashSet<AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock>? BusinessIdentity
    {
        get => GetProperty<HashSet<AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock>>("business_identity");
        set => this.WithProperty("business_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
