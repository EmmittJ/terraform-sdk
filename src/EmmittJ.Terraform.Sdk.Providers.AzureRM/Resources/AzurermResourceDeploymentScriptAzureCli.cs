using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_resource_deployment_script_azure_cli resource.
/// </summary>
public class AzurermResourceDeploymentScriptAzureCli : TerraformResource
{
    public AzurermResourceDeploymentScriptAzureCli(string name) : base("azurerm_resource_deployment_script_azure_cli", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("outputs");
    }

    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CleanupPreference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cleanup_preference");
        set => this.WithProperty("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CommandLine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line");
        set => this.WithProperty("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("force_update_tag");
        set => this.WithProperty("force_update_tag", value);
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
    /// The primary_script_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryScriptUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_script_uri");
        set => this.WithProperty("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RetentionInterval
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retention_interval");
        set => this.WithProperty("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScriptContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_content");
        set => this.WithProperty("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SupportingScriptUris
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supporting_script_uris");
        set => this.WithProperty("supporting_script_uris", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
