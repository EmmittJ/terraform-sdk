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
    public TerraformProperty<string>? AuthorizationType
    {
        get => GetProperty<TerraformProperty<string>>("authorization_type");
        set => this.WithProperty("authorization_type", value);
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
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? MachineLearningWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("machine_learning_workspace_id");
        set => this.WithProperty("machine_learning_workspace_id", value);
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
    /// The node_public_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NodePublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("node_public_ip_enabled");
        set => this.WithProperty("node_public_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_resource_id");
        set => this.WithProperty("subnet_resource_id", value);
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
    /// The virtual_machine_size attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineSize
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_size");
        set => this.WithProperty("virtual_machine_size", value);
    }

}
