using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFromTemplateTimeoutsBlock : TerraformBlock
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
        SetOutput("application_id");
        SetOutput("application_object_id");
        SetOutput("service_principal_id");
        SetOutput("service_principal_object_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("template_id");
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    /// The UUID of the template to instantiate for this application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    public required TerraformProperty<string> TemplateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_id");
        set => SetProperty("template_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationFromTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
