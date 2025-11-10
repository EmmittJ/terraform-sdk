using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for partner_authorization in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The authorization_expiration_time_in_utc attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationExpirationTimeInUtc
    {
        get => GetProperty<TerraformProperty<string>>("authorization_expiration_time_in_utc");
        set => WithProperty("authorization_expiration_time_in_utc", value);
    }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerName is required")]
    public required TerraformProperty<string> PartnerName
    {
        get => GetProperty<TerraformProperty<string>>("partner_name");
        set => WithProperty("partner_name", value);
    }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
    public required TerraformProperty<string> PartnerRegistrationId
    {
        get => GetProperty<TerraformProperty<string>>("partner_registration_id");
        set => WithProperty("partner_registration_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridPartnerConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_eventgrid_partner_configuration resource.
/// </summary>
public class AzurermEventgridPartnerConfiguration : TerraformResource
{
    public AzurermEventgridPartnerConfiguration(string name) : base("azurerm_eventgrid_partner_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_maximum_expiration_time_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? DefaultMaximumExpirationTimeInDays
    {
        get => GetProperty<TerraformProperty<double>>("default_maximum_expiration_time_in_days");
        set => this.WithProperty("default_maximum_expiration_time_in_days", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for partner_authorization.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock>? PartnerAuthorization
    {
        get => GetProperty<List<AzurermEventgridPartnerConfigurationPartnerAuthorizationBlock>>("partner_authorization");
        set => this.WithProperty("partner_authorization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridPartnerConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermEventgridPartnerConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
