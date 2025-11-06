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
    public string? CleanupPreference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cleanup_preference")?.Value;
        set => this.WithProperty("cleanup_preference", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public string? CommandLine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("command_line")?.Value;
        set => this.WithProperty("command_line", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public string? ForceUpdateTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("force_update_tag")?.Value;
        set => this.WithProperty("force_update_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The primary_script_uri attribute.
    /// </summary>
    public string? PrimaryScriptUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_script_uri")?.Value;
        set => this.WithProperty("primary_script_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    public string? RetentionInterval
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retention_interval")?.Value;
        set => this.WithProperty("retention_interval", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public string? ScriptContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("script_content")?.Value;
        set => this.WithProperty("script_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public List<string>? SupportingScriptUris
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supporting_script_uris")?.Value;
        set => this.WithProperty("supporting_script_uris", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The timeout attribute.
    /// </summary>
    public string? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
