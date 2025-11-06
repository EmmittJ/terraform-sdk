using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_credential_service_principal resource.
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipal : TerraformResource
{
    public AzurermDataFactoryCredentialServicePrincipal(string name) : base("azurerm_data_factory_credential_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// (Optional) Short text description
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The desired name of the credential resource
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Client ID of the Service Principal
    /// </summary>
    public string? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id")?.Value;
        set => this.WithProperty("service_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Tenant ID of the Service Principal
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
