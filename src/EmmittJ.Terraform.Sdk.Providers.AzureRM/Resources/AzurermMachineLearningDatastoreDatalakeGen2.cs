using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_datastore_datalake_gen2 resource.
/// </summary>
public class AzurermMachineLearningDatastoreDatalakeGen2 : TerraformResource
{
    public AzurermMachineLearningDatastoreDatalakeGen2(string name) : base("azurerm_machine_learning_datastore_datalake_gen2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("is_default");
    }

    /// <summary>
    /// The authority_url attribute.
    /// </summary>
    public string? AuthorityUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authority_url")?.Value;
        set => this.WithProperty("authority_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public string? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret")?.Value;
        set => this.WithProperty("client_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_data_identity attribute.
    /// </summary>
    public string? ServiceDataIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_data_identity")?.Value;
        set => this.WithProperty("service_data_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public string? StorageContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_id")?.Value;
        set => this.WithProperty("storage_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

}
