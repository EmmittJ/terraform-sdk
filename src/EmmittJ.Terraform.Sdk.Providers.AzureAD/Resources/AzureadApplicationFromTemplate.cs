using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application_from_template resource.
/// </summary>
public class AzureadApplicationFromTemplate : TerraformResource
{
    public AzureadApplicationFromTemplate(string name) : base("azuread_application_from_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_id");
        this.DeclareOutput("application_object_id");
        this.DeclareOutput("service_principal_id");
        this.DeclareOutput("service_principal_object_id");
    }

    /// <summary>
    /// The display name for the application
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
    /// The UUID of the template to instantiate for this application
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// The resource ID for this application
    /// </summary>
    public TerraformExpression ApplicationId => this["application_id"];

    /// <summary>
    /// The object ID for this application
    /// </summary>
    public TerraformExpression ApplicationObjectId => this["application_object_id"];

    /// <summary>
    /// The resource ID for this service principal
    /// </summary>
    public TerraformExpression ServicePrincipalId => this["service_principal_id"];

    /// <summary>
    /// The object ID for this service principal
    /// </summary>
    public TerraformExpression ServicePrincipalObjectId => this["service_principal_object_id"];

}
