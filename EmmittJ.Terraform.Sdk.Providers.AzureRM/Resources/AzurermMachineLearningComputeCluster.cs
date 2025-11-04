using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_machine_learning_compute_cluster resource.
/// </summary>
public class AzurermMachineLearningComputeCluster : TerraformResource
{
    public AzurermMachineLearningComputeCluster(string name) : base("azurerm_machine_learning_compute_cluster", name)
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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public bool? NodePublicIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_enabled")?.Value;
        set => this.WithProperty("node_public_ip_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ssh_public_access_enabled attribute.
    /// </summary>
    public bool? SshPublicAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_public_access_enabled")?.Value;
        set => this.WithProperty("ssh_public_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The vm_priority attribute.
    /// </summary>
    public string? VmPriority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_priority")?.Value;
        set => this.WithProperty("vm_priority", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public string? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size")?.Value;
        set => this.WithProperty("vm_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
