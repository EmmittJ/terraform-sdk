using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_synchronization_job resource.
/// </summary>
public class AzureadSynchronizationJob : TerraformResource
{
    public AzureadSynchronizationJob(string name) : base("azuread_synchronization_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("schedule");
    }

    /// <summary>
    /// Whether or not the synchronization job is enabled
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The ID of the service principal for which this synchronization job should be created
    /// </summary>
    public string? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id")?.Value;
        set => this.WithProperty("service_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifier of the synchronization template this job is based on.
    /// </summary>
    public string? TemplateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_id")?.Value;
        set => this.WithProperty("template_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformExpression Schedule => this["schedule"];

}
