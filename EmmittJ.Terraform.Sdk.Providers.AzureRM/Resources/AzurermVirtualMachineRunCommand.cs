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
    public string? ErrorBlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("error_blob_uri")?.Value;
        set => this.WithProperty("error_blob_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The output_blob_uri attribute.
    /// </summary>
    public string? OutputBlobUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_blob_uri")?.Value;
        set => this.WithProperty("output_blob_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The run_as_password attribute.
    /// </summary>
    public string? RunAsPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_as_password")?.Value;
        set => this.WithProperty("run_as_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The run_as_user attribute.
    /// </summary>
    public string? RunAsUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_as_user")?.Value;
        set => this.WithProperty("run_as_user", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The virtual_machine_id attribute.
    /// </summary>
    public string? VirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_id")?.Value;
        set => this.WithProperty("virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_view attribute.
    /// </summary>
    public TerraformExpression InstanceView => this["instance_view"];

}
