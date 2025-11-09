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
    public TerraformProperty<bool>? CwLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cw_log_enabled");
        set => this.WithProperty("cw_log_enabled", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DomainList
    {
        get => GetProperty<TerraformProperty<List<string>>>("domain_list");
        set => this.WithProperty("domain_list", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
