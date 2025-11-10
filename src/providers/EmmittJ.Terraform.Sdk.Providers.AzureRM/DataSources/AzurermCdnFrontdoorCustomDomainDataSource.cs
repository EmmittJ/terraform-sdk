using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_custom_domain.
/// </summary>
public class AzurermCdnFrontdoorCustomDomainDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorCustomDomainDataSource(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("cdn_frontdoor_profile_id");
        this.WithOutput("dns_zone_id");
        this.WithOutput("expiration_date");
        this.WithOutput("host_name");
        this.WithOutput("tls");
        this.WithOutput("validation_token");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("profile_name");
        set => this.WithProperty("profile_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorCustomDomainDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorProfileId => this["cdn_frontdoor_profile_id"];

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    public TerraformExpression DnsZoneId => this["dns_zone_id"];

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformExpression HostName => this["host_name"];

    /// <summary>
    /// The tls attribute.
    /// </summary>
    public TerraformExpression Tls => this["tls"];

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
