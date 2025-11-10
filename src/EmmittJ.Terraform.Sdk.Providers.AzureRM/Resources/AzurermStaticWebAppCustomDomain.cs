using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStaticWebAppCustomDomainTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_static_web_app_custom_domain resource.
/// </summary>
public class AzurermStaticWebAppCustomDomain : TerraformResource
{
    public AzurermStaticWebAppCustomDomain(string name) : base("azurerm_static_web_app_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("validation_token");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The static_web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticWebAppId is required")]
    public required TerraformProperty<string> StaticWebAppId
    {
        get => GetProperty<TerraformProperty<string>>("static_web_app_id");
        set => this.WithProperty("static_web_app_id", value);
    }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationType is required")]
    public required TerraformProperty<string> ValidationType
    {
        get => GetProperty<TerraformProperty<string>>("validation_type");
        set => this.WithProperty("validation_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStaticWebAppCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStaticWebAppCustomDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
