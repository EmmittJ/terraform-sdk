using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rum_app_monitor resource.
/// </summary>
public class AwsRumAppMonitor : TerraformResource
{
    public AwsRumAppMonitor(string name) : base("aws_rum_app_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_monitor_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("cw_log_group");
    }

    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    public bool? CwLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cw_log_enabled")?.Value;
        set => this.WithProperty("cw_log_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    public List<string>? DomainList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_list")?.Value;
        set => this.WithProperty("domain_list", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The app_monitor_id attribute.
    /// </summary>
    public TerraformExpression AppMonitorId => this["app_monitor_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cw_log_group attribute.
    /// </summary>
    public TerraformExpression CwLogGroup => this["cw_log_group"];

}
