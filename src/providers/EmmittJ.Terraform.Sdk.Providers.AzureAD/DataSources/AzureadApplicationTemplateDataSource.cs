using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTemplateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azuread_application_template.
/// </summary>
public class AzureadApplicationTemplateDataSource : TerraformDataSource
{
    public AzureadApplicationTemplateDataSource(string name) : base("azuread_application_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("categories");
        SetOutput("homepage_url");
        SetOutput("logo_url");
        SetOutput("publisher");
        SetOutput("supported_provisioning_types");
        SetOutput("supported_single_sign_on_modes");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("template_id");
    }

    /// <summary>
    /// The display name for the application template
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The application template&#39;s ID
    /// </summary>
    public TerraformProperty<string> TemplateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_id");
        set => SetProperty("template_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationTemplateDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// List of categories for this templated application
    /// </summary>
    public TerraformExpression Categories => this["categories"];

    /// <summary>
    /// Home page URL of the templated application
    /// </summary>
    public TerraformExpression HomepageUrl => this["homepage_url"];

    /// <summary>
    /// URL to retrieve the logo for this templated application
    /// </summary>
    public TerraformExpression LogoUrl => this["logo_url"];

    /// <summary>
    /// Name of the publisher for this templated application
    /// </summary>
    public TerraformExpression Publisher => this["publisher"];

    /// <summary>
    /// The provisioning modes supported by this templated application
    /// </summary>
    public TerraformExpression SupportedProvisioningTypes => this["supported_provisioning_types"];

    /// <summary>
    /// The single sign on modes supported by this templated application
    /// </summary>
    public TerraformExpression SupportedSingleSignOnModes => this["supported_single_sign_on_modes"];

}
