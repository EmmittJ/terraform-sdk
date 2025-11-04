using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_nginx_deployment resource.
/// </summary>
public class AzurermNginxDeployment : TerraformResource
{
    public AzurermNginxDeployment(string name) : base("azurerm_nginx_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dataplane_api_endpoint");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("nginx_version");
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    public string? AutomaticUpgradeChannel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automatic_upgrade_channel")?.Value;
        set => this.WithProperty("automatic_upgrade_channel", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public double? Capacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("capacity")?.Value;
        set => this.WithProperty("capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    public bool? DiagnoseSupportEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("diagnose_support_enabled")?.Value;
        set => this.WithProperty("diagnose_support_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ManagedResourceGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_resource_group")?.Value;
        set => this.WithProperty("managed_resource_group", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    public TerraformExpression DataplaneApiEndpoint => this["dataplane_api_endpoint"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    public TerraformExpression NginxVersion => this["nginx_version"];

}
