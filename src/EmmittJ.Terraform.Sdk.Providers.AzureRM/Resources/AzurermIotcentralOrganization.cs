using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotcentralOrganizationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iotcentral_organization resource.
/// </summary>
public class AzurermIotcentralOrganization : TerraformResource
{
    public AzurermIotcentralOrganization(string name) : base("azurerm_iotcentral_organization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    public required TerraformProperty<string> IotcentralApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("iotcentral_application_id");
        set => this.WithProperty("iotcentral_application_id", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformProperty<string> OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
    }

    /// <summary>
    /// The parent_organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentOrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("parent_organization_id");
        set => this.WithProperty("parent_organization_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotcentralOrganizationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIotcentralOrganizationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
