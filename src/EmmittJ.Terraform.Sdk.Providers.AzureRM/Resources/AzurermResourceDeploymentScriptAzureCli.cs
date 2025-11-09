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
    public TerraformProperty<string>? CleanupPreference
    {
        get => GetProperty<TerraformProperty<string>>("cleanup_preference");
        set => this.WithProperty("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public TerraformProperty<string>? CommandLine
    {
        get => GetProperty<TerraformProperty<string>>("command_line");
        set => this.WithProperty("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformProperty<string>>("force_update_tag");
        set => this.WithProperty("force_update_tag", value);
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
    /// The primary_script_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryScriptUri
    {
        get => GetProperty<TerraformProperty<string>>("primary_script_uri");
        set => this.WithProperty("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    public TerraformProperty<string>? RetentionInterval
    {
        get => GetProperty<TerraformProperty<string>>("retention_interval");
        set => this.WithProperty("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptContent
    {
        get => GetProperty<TerraformProperty<string>>("script_content");
        set => this.WithProperty("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SupportingScriptUris
    {
        get => GetProperty<TerraformProperty<List<string>>>("supporting_script_uris");
        set => this.WithProperty("supporting_script_uris", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
