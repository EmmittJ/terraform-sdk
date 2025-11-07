using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_run_command resource.
/// </summary>
public class AzurermVirtualMachineRunCommand : TerraformResource
{
    public AzurermVirtualMachineRunCommand(string name) : base("azurerm_virtual_machine_run_command", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_view");
    }

    /// <summary>
    /// The error_blob_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ErrorBlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("error_blob_uri");
        set => this.WithProperty("error_blob_uri", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The output_blob_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutputBlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_blob_uri");
        set => this.WithProperty("output_blob_uri", value);
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunAsPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_as_password");
        set => this.WithProperty("run_as_password", value);
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunAsUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_as_user");
        set => this.WithProperty("run_as_user", value);
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
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    public TerraformExpression InstanceView => this["instance_view"];

}
