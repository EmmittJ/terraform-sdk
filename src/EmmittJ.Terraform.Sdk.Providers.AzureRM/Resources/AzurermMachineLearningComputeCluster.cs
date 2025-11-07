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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_learning_workspace_id");
        set => this.WithProperty("machine_learning_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The ssh_public_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SshPublicAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssh_public_access_enabled");
        set => this.WithProperty("ssh_public_access_enabled", value);
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_resource_id");
        set => this.WithProperty("subnet_resource_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vm_priority attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmPriority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_priority");
        set => this.WithProperty("vm_priority", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

}
