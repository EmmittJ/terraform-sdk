using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_synapse_spark resource.
/// </summary>
public class AzurermMachineLearningSynapseSpark : TerraformResource
{
    public AzurermMachineLearningSynapseSpark(string name) : base("azurerm_machine_learning_synapse_spark", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public bool? LocalAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_auth_enabled")?.Value;
        set => this.WithProperty("local_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    public string? MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_learning_workspace_id")?.Value;
        set => this.WithProperty("machine_learning_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The synapse_spark_pool_id attribute.
    /// </summary>
    public string? SynapseSparkPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("synapse_spark_pool_id")?.Value;
        set => this.WithProperty("synapse_spark_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
