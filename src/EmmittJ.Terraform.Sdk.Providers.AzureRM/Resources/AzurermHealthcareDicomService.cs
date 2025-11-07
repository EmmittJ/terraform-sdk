using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_healthcare_dicom_service resource.
/// </summary>
public class AzurermHealthcareDicomService : TerraformResource
{
    public AzurermHealthcareDicomService(string name) : base("azurerm_healthcare_dicom_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authentication");
        this.DeclareOutput("private_endpoint");
        this.DeclareOutput("service_url");
    }

    /// <summary>
    /// The data_partitions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataPartitionsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_partitions_enabled");
        set => this.WithProperty("data_partitions_enabled", value);
    }

    /// <summary>
    /// The encryption_key_url attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKeyUrl
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key_url");
        set => this.WithProperty("encryption_key_url", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
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
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The private_endpoint attribute.
    /// </summary>
    public TerraformExpression PrivateEndpoint => this["private_endpoint"];

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformExpression ServiceUrl => this["service_url"];

}
