using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
        this.DeclareOutput("categories");
        this.DeclareOutput("homepage_url");
        this.DeclareOutput("logo_url");
        this.DeclareOutput("publisher");
        this.DeclareOutput("supported_provisioning_types");
        this.DeclareOutput("supported_single_sign_on_modes");
    }

    /// <summary>
    /// The display name for the application template
    /// </summary>
    public TerraformProperty<string>? DisplayName
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
    /// The application template&#39;s ID
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
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
