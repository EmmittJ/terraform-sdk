using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationConnectionClassicCertificateTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_automation_connection_classic_certificate resource.
/// </summary>
public class AzurermAutomationConnectionClassicCertificate : TerraformResource
{
    public AzurermAutomationConnectionClassicCertificate(string name) : base("azurerm_automation_connection_classic_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The certificate_asset_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAssetName is required")]
    public required TerraformProperty<string> CertificateAssetName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_asset_name");
        set => this.WithProperty("certificate_asset_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    public required TerraformProperty<string> SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

    /// <summary>
    /// The subscription_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionName is required")]
    public required TerraformProperty<string> SubscriptionName
    {
        get => GetProperty<TerraformProperty<string>>("subscription_name");
        set => this.WithProperty("subscription_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationConnectionClassicCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationConnectionClassicCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
