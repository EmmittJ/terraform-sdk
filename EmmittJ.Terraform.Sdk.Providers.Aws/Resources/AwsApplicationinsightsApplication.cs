using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_applicationinsights_application resource.
/// </summary>
public class AwsApplicationinsightsApplication : TerraformResource
{
    public AwsApplicationinsightsApplication(string name) : base("aws_applicationinsights_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    public bool? AutoConfigEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_config_enabled")?.Value;
        set => this.WithProperty("auto_config_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public bool? AutoCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create")?.Value;
        set => this.WithProperty("auto_create", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    public bool? CweMonitorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cwe_monitor_enabled")?.Value;
        set => this.WithProperty("cwe_monitor_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    public string? GroupingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grouping_type")?.Value;
        set => this.WithProperty("grouping_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ops_center_enabled attribute.
    /// </summary>
    public bool? OpsCenterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ops_center_enabled")?.Value;
        set => this.WithProperty("ops_center_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    public string? OpsItemSnsTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ops_item_sns_topic_arn")?.Value;
        set => this.WithProperty("ops_item_sns_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
