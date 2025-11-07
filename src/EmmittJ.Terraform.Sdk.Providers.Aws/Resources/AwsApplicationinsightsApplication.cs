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
    public TerraformLiteralProperty<bool>? AutoConfigEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_config_enabled");
        set => this.WithProperty("auto_config_enabled", value);
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_create");
        set => this.WithProperty("auto_create", value);
    }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CweMonitorEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("cwe_monitor_enabled");
        set => this.WithProperty("cwe_monitor_enabled", value);
    }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GroupingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grouping_type");
        set => this.WithProperty("grouping_type", value);
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
    /// The ops_center_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OpsCenterEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ops_center_enabled");
        set => this.WithProperty("ops_center_enabled", value);
    }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OpsItemSnsTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ops_item_sns_topic_arn");
        set => this.WithProperty("ops_item_sns_topic_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
