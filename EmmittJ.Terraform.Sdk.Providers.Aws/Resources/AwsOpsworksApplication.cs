using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_application resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksApplication : TerraformResource
{
    public AwsOpsworksApplication(string name) : base("aws_opsworks_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_bundle_on_deploy attribute.
    /// </summary>
    public string? AutoBundleOnDeploy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_bundle_on_deploy")?.Value;
        set => this.WithProperty("auto_bundle_on_deploy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aws_flow_ruby_settings attribute.
    /// </summary>
    public string? AwsFlowRubySettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_flow_ruby_settings")?.Value;
        set => this.WithProperty("aws_flow_ruby_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_source_arn attribute.
    /// </summary>
    public string? DataSourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_arn")?.Value;
        set => this.WithProperty("data_source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_source_database_name attribute.
    /// </summary>
    public string? DataSourceDatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_database_name")?.Value;
        set => this.WithProperty("data_source_database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    public string? DataSourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_type")?.Value;
        set => this.WithProperty("data_source_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The document_root attribute.
    /// </summary>
    public string? DocumentRoot
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_root")?.Value;
        set => this.WithProperty("document_root", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    public List<string>? Domains
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domains")?.Value;
        set => this.WithProperty("domains", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The enable_ssl attribute.
    /// </summary>
    public bool? EnableSsl
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ssl")?.Value;
        set => this.WithProperty("enable_ssl", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The rails_env attribute.
    /// </summary>
    public string? RailsEnv
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rails_env")?.Value;
        set => this.WithProperty("rails_env", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The short_name attribute.
    /// </summary>
    public string? ShortName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("short_name")?.Value;
        set => this.WithProperty("short_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public string? StackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_id")?.Value;
        set => this.WithProperty("stack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
