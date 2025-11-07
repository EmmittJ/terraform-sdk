using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_tenant_template_deployment resource.
/// </summary>
public class AzurermTenantTemplateDeployment : TerraformResource
{
    public AzurermTenantTemplateDeployment(string name) : base("azurerm_tenant_template_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("output_content");
    }

    /// <summary>
    /// The debug_level attribute.
    /// </summary>
    public TerraformProperty<string>? DebugLevel
    {
        get => GetProperty<TerraformProperty<string>>("debug_level");
        set => this.WithProperty("debug_level", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public TerraformProperty<string>? ParametersContent
    {
        get => GetProperty<TerraformProperty<string>>("parameters_content");
        set => this.WithProperty("parameters_content", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateContent
    {
        get => GetProperty<TerraformProperty<string>>("template_content");
        set => this.WithProperty("template_content", value);
    }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateSpecVersionId
    {
        get => GetProperty<TerraformProperty<string>>("template_spec_version_id");
        set => this.WithProperty("template_spec_version_id", value);
    }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    public TerraformExpression OutputContent => this["output_content"];

}
