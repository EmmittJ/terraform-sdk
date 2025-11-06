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
    public string? DebugLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("debug_level")?.Value;
        set => this.WithProperty("debug_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public string? ParametersContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameters_content")?.Value;
        set => this.WithProperty("parameters_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The template_content attribute.
    /// </summary>
    public string? TemplateContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_content")?.Value;
        set => this.WithProperty("template_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    public string? TemplateSpecVersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_spec_version_id")?.Value;
        set => this.WithProperty("template_spec_version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    public TerraformExpression OutputContent => this["output_content"];

}
