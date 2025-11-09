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
    public TerraformProperty<string>? AuthorityUrl
    {
        get => GetProperty<TerraformProperty<string>>("authority_url");
        set => this.WithProperty("authority_url", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The service_data_identity attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceDataIdentity
    {
        get => GetProperty<TerraformProperty<string>>("service_data_identity");
        set => this.WithProperty("service_data_identity", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

}
