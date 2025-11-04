using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_compute_instance resource.
/// </summary>
public class AzurermMachineLearningComputeInstance : TerraformResource
{
    public AzurermMachineLearningComputeInstance(string name) : base("azurerm_machine_learning_compute_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    public string? AuthorizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_type")?.Value;
        set => this.WithProperty("authorization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public bool? NodePublicIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_enabled")?.Value;
        set => this.WithProperty("node_public_ip_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    public string? SubnetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_resource_id")?.Value;
        set => this.WithProperty("subnet_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The virtual_machine_size attribute.
    /// </summary>
    public string? VirtualMachineSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_size")?.Value;
        set => this.WithProperty("virtual_machine_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
